//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		BaseConverter.cs
//	Description:		Converts from base 10 to any other base 2-16 and back.
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Koi Stephanos, stepanos@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:			Friday, April 9, 2015
//	Copyright:		Koi Stephanos, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    /// <summary>
    /// 
    /// </summary>
    class BaseConverter
    {
        //Stack to be used with conversion
        public static Stack<int> DecimalStack = new Stack<int>();

        //Properties for use with conversion
        public static int DecimalValue { get; set; }                //the actual decimal value
        public static int BaseValue { get; set; }                   //the actual value in whatever base
        public static string Base { get; set; }                     //the base that we are working in
        public static int DecimalStackSize { get; set; }            //the size of the decimal stack
        public static int NumSpaces { get; set; }                   //the amount of spaces for base output


        /// <summary>
        /// Converts from some base back to the decimal value.
        /// </summary>
        /// <returns></returns> The converted number.
        /// <exception cref="System.Exception">Error! Input not within bounds of base.</exception>
        public static int ToDecimal()
        {
            //pulls in the fields from the form that we need for conversion
            BaseValue = DecimalConversionForm.BaseValue;
            Base = DecimalConversionForm.Base;
            DecimalValue = 0;
            List<int> BaseDigits = new List<int>();    //created list for storing digits of base value

            //converts the base value to a character array and adds each item to the list of digits
            char[] digits = Base.ToCharArray();
            foreach(char c in digits)
            {
                int temp = HexToDecimal(c);
                //test to make sure that digit is within the scope of the base, throw exception if not
                if (temp >= BaseValue)
                    throw new Exception("Error! Input not within bounds of base.");
                else
                    BaseDigits.Add(temp);               //adds digit to list
            }


            //calculates the decimal value by multiplying the previous value by the BaseValue and adding the next value from the list
            for (int i = 0; i < BaseDigits.Count; i++)
            {
                DecimalValue = (DecimalValue * BaseValue) + BaseDigits[i];          //converts to decimal
            }

            return DecimalValue;
        }


        /// <summary>
        /// Converts to a given base from the decimal.
        /// </summary>
        /// <returns></returns> A string containing the converted value.
        public static string FromDecimal()
        {
            //pulls in the values from the form we need for conversion
            DecimalValue = DecimalConversionForm.DecimalValue;
            BaseValue = DecimalConversionForm.BaseValue;
            NumSpaces = DecimalConversionForm.NumSpaces;
            
            int remainder = 1;      //sets remainder so loop will start
            int quotient = 0;            //initializes the quotient 
            int temp = 0;                //temp value used for parsing
            string baseValue = "";       //the string to be returned
           
            //calculates the remainder from base conversion and adds it to the stack until the remainder = zero
            while (DecimalValue > 0)
            {
                quotient = DecimalValue / BaseValue;                //obtains quotient
                remainder = DecimalValue % BaseValue;               //obtains remainder
                DecimalValue = quotient;                            //resets decimal value to previous quotient
                if(remainder >= 0)                                  //checks to see if valid remainder
                    DecimalStack.Push(remainder);                   //if so, pushes it onto stack
            }

                //calculates amount of 0 required to reach user's specified amount of digits and pushes them onto the stack
                DecimalStackSize = DecimalStack.Count;
                int spaces = NumSpaces - DecimalStackSize;
                for (int i = 0; i < spaces; i++)
                {
                    baseValue += "0";
                    NumSpaces--;
                } 

            //determines if NumSpaces will allow for full display, if not, sets the size
                if (NumSpaces < DecimalStackSize)
                    NumSpaces = DecimalStackSize;

            //places digits from stack into string
            for(int j = 0; j < NumSpaces; j++)
            {
                //obtains the converted digits in correct order
                temp = DecimalStack.Pop();
                //converts to Hex value if neccessary and adds digit to string
                if (temp > 9)
                    baseValue += DecimalToHex(temp);
                else
                 baseValue += temp.ToString();
            }
            return baseValue;
        }

        /// <summary>
        /// Hexadecimals to decimal.
        /// </summary>
        /// <param name="value">The value to be converted to decimal.</param>
        /// <returns></returns> The integer value of the passed character.
        public static int HexToDecimal(char value)
        {
            int iValue;             //possible value to be returned

            //compares value with Hex characters and returns the corresponding number if a match is found
            //else Parses value into iValue and exits switch statement.
            switch(value)
            {
                case 'a':
                case 'A':
                    return 10;
                case 'b':
                case 'B':
                    return 11;
                case 'c':
                case 'C':
                    return 12;
                case 'd':
                case 'D':
                    return 13;
                case 'e':
                case 'E':
                    return 14;
                case 'f':
                case 'F':
                    return 15;
                default:
                    //if we get this far, the character must be a valid number, so we convert it
                    string temp = value.ToString();
                    iValue = Int32.Parse(temp);
                    break;
            }
            return iValue;
        }

        /// <summary>
        /// Decimals to hexadecimal.
        /// </summary>
        /// <param name="value">The value to be converted to hex.</param>
        /// <returns></returns>
        public static string DecimalToHex(int value)
        {
            string strValue;             //possible value to be returned

            //compares value with Hex characters and returns the corresponding letter if a match is found
            //else, converts number to a string and returns it
            switch (value)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    strValue = value.ToString();
                    break;
            }
            return strValue;
        }

    }
}

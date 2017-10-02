//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		DecimalConversionForm.cs
//	Description:		Provides a GUI interface for the base converter program.
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Koi Stephanos, stepanos@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:			Friday, April 9, 2015
//	Copyright:		Koi Stephanos, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DecimalConversionForm : Form
    {
        //Properties for use with conversion
        public static int DecimalValue { get; set; }
        public static int BaseValue { get; set; }
        public static string Base { get; set; }
        public static int NumSpaces { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalConversionForm"/> class.
        /// </summary>
        public DecimalConversionForm()
        {
            InitializeComponent();              
        }

        /// <summary>
        /// Handles the Click event of the label3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the textBox2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the Click event of the ConvertFromDecimal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ConvertFromDecimal_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";                                   //clears the error label

            //try the conversion
            try
            {
                IntBaseBox.Text = "";                               //resets text field
                string temp = DecimalBox.Text;                      //obtain the number to convert
                DecimalValue = Int32.Parse(temp);                   //convert string number to int
                BaseValue = (int)BaseUpDown.Value;                  //obtains the base value used for conversion
                NumSpaces = (int)ResultUpDown.Value;                //obtains the amount of spaces used for output
                Base = BaseConverter.FromDecimal();                 //converts to the correct base
                IntBaseBox.Text = Base;                             //sets the text field equal to the converted base
            }
            catch(Exception ex)
            {
                ErrorLabel.Text = ex.Message;  //sets the error text field to the error message
            }
            //if decimal box = 0, base box = 0
            if (DecimalBox.Text.Equals("0"))
                IntBaseBox.Text = "0";
            BaseValueLabel.Text = String.Format("Integer Value in Base {0}", BaseValue); //resets the Base Value label
            
        }

        /// <summary>
        /// Handles the Load event of the DecimalConversionForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DecimalConversionForm_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;            //sets title to application name
        }

        /// <summary>
        /// Handles the Click event of the Exit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();                         //neatly exits the program
        }

        /// <summary>
        /// Handles the Click event of the ConvertToDecimal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ConvertToDecimal_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";                       //clears the error label
            Base = IntBaseBox.Text;                     //obtains base value to be converted
            BaseValue = (int)BaseUpDown.Value;          //obtains base to be used in conversion
            
            //attempt the conversion
            try
            {
                //if the base box is empty, throw exception
                if (IntBaseBox.Text.Equals(""))
                    throw new Exception("Error! Must enter a base value in order to convert!");
                DecimalValue = BaseConverter.ToDecimal();           //converts to the appropriate decimal value
                DecimalBox.Text = DecimalValue.ToString();          //converts value to a string and sets the text field
            }
            catch(Exception ex)
            {
                ErrorLabel.Text = ex.Message;                       //display error if one is thrown
            }

            BaseValueLabel.Text = String.Format("Integer Value in Base {0}", BaseValue);        //reset the base value label
        }

        /// <summary>
        /// Handles the Click event of the label5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the DecimalBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DecimalBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Handles the Enter event of the DecimalBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DecimalBox_Enter(object sender, EventArgs e)
        {
            DecimalBox.Text = "";       //clears decimal box upon entry
        }

        /// <summary>
        /// Handles the FormClosing event of the DecimalConversionForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void DecimalConversionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //displays a goodbye message whenever exiting the program
            MessageBox.Show("Thank you for using my program!!!", "Farwell!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Handles the MouseHover event of the DecimalConversionForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DecimalConversionForm_MouseHover(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the DoubleClick event of the DecimalConversionForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DecimalConversionForm_DoubleClick(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Handles the Enter event of the IntBaseBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void IntBaseBox_Enter(object sender, EventArgs e)
        {
            IntBaseBox.Text = "";               //clears the base text when entered
        }

        /// <summary>
        /// Handles the KeyPress event of the DecimalBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void DecimalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accept digit values or the backspace char
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the IntBaseBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void IntBaseBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accepts digit values, the backspace char, and upper and lower case Hex values
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back && e.KeyChar != 'A' && e.KeyChar != 'a' 
                && e.KeyChar != 'B' && e.KeyChar != 'b' && e.KeyChar != 'C' && e.KeyChar != 'c' && e.KeyChar != 'D' 
                && e.KeyChar != 'd' && e.KeyChar != 'E' && e.KeyChar != 'e' && e.KeyChar != 'F' && e.KeyChar != 'f')
                e.Handled = true;
        }
    }
}

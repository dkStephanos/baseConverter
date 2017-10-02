namespace WindowsFormsApplication2
{
    partial class DecimalConversionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecimalConversionForm));
            this.ConvertFromDecimal = new System.Windows.Forms.Button();
            this.ConvertToDecimal = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DecimalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BaseUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResultUpDown = new System.Windows.Forms.NumericUpDown();
            this.DecimalBox = new System.Windows.Forms.TextBox();
            this.IntBaseBox = new System.Windows.Forms.TextBox();
            this.BaseValueLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertFromDecimal
            // 
            this.ConvertFromDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ConvertFromDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(64)))));
            this.ConvertFromDecimal.Location = new System.Drawing.Point(109, 172);
            this.ConvertFromDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConvertFromDecimal.Name = "ConvertFromDecimal";
            this.ConvertFromDecimal.Size = new System.Drawing.Size(157, 49);
            this.ConvertFromDecimal.TabIndex = 0;
            this.ConvertFromDecimal.Text = "Convert From Decimal";
            this.ConvertFromDecimal.UseVisualStyleBackColor = false;
            this.ConvertFromDecimal.Click += new System.EventHandler(this.ConvertFromDecimal_Click);
            // 
            // ConvertToDecimal
            // 
            this.ConvertToDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ConvertToDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ConvertToDecimal.Location = new System.Drawing.Point(336, 172);
            this.ConvertToDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConvertToDecimal.Name = "ConvertToDecimal";
            this.ConvertToDecimal.Size = new System.Drawing.Size(144, 49);
            this.ConvertToDecimal.TabIndex = 1;
            this.ConvertToDecimal.Text = "Convert To Decimal";
            this.ConvertToDecimal.UseVisualStyleBackColor = false;
            this.ConvertToDecimal.Click += new System.EventHandler(this.ConvertToDecimal_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exit.Location = new System.Drawing.Point(573, 172);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 49);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DecimalLabel
            // 
            this.DecimalLabel.AutoSize = true;
            this.DecimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalLabel.Location = new System.Drawing.Point(132, 46);
            this.DecimalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecimalLabel.Name = "DecimalLabel";
            this.DecimalLabel.Size = new System.Drawing.Size(167, 17);
            this.DecimalLabel.TabIndex = 3;
            this.DecimalLabel.Text = "Decimal Integer Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Places in Result";
            // 
            // BaseUpDown
            // 
            this.BaseUpDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BaseUpDown.Location = new System.Drawing.Point(504, 108);
            this.BaseUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BaseUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.BaseUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.BaseUpDown.Name = "BaseUpDown";
            this.BaseUpDown.Size = new System.Drawing.Size(47, 22);
            this.BaseUpDown.TabIndex = 7;
            this.BaseUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BaseUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ResultUpDown
            // 
            this.ResultUpDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ResultUpDown.Location = new System.Drawing.Point(693, 107);
            this.ResultUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.ResultUpDown.Name = "ResultUpDown";
            this.ResultUpDown.Size = new System.Drawing.Size(47, 22);
            this.ResultUpDown.TabIndex = 8;
            this.ResultUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DecimalBox
            // 
            this.DecimalBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DecimalBox.Location = new System.Drawing.Point(136, 66);
            this.DecimalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DecimalBox.Name = "DecimalBox";
            this.DecimalBox.Size = new System.Drawing.Size(171, 22);
            this.DecimalBox.TabIndex = 9;
            this.DecimalBox.Text = "Enter a Value";
            this.DecimalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecimalBox.TextChanged += new System.EventHandler(this.DecimalBox_TextChanged);
            this.DecimalBox.Enter += new System.EventHandler(this.DecimalBox_Enter);
            this.DecimalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalBox_KeyPress);
            // 
            // IntBaseBox
            // 
            this.IntBaseBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IntBaseBox.Location = new System.Drawing.Point(435, 66);
            this.IntBaseBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntBaseBox.Name = "IntBaseBox";
            this.IntBaseBox.Size = new System.Drawing.Size(297, 22);
            this.IntBaseBox.TabIndex = 10;
            this.IntBaseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IntBaseBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.IntBaseBox.Enter += new System.EventHandler(this.IntBaseBox_Enter);
            this.IntBaseBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntBaseBox_KeyPress);
            // 
            // BaseValueLabel
            // 
            this.BaseValueLabel.AutoSize = true;
            this.BaseValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseValueLabel.Location = new System.Drawing.Point(431, 47);
            this.BaseValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaseValueLabel.Name = "BaseValueLabel";
            this.BaseValueLabel.Size = new System.Drawing.Size(178, 17);
            this.BaseValueLabel.TabIndex = 11;
            this.BaseValueLabel.Text = "Integer Value in Base 2";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ErrorLabel.Location = new System.Drawing.Point(267, 153);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 12;
            this.ErrorLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // DecimalConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(808, 245);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BaseValueLabel);
            this.Controls.Add(this.IntBaseBox);
            this.Controls.Add(this.DecimalBox);
            this.Controls.Add(this.ResultUpDown);
            this.Controls.Add(this.BaseUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DecimalLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConvertToDecimal);
            this.Controls.Add(this.ConvertFromDecimal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DecimalConversionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion To/From Decimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DecimalConversionForm_FormClosing);
            this.Load += new System.EventHandler(this.DecimalConversionForm_Load);
            this.DoubleClick += new System.EventHandler(this.DecimalConversionForm_DoubleClick);
            this.MouseHover += new System.EventHandler(this.DecimalConversionForm_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.BaseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertFromDecimal;
        private System.Windows.Forms.Button ConvertToDecimal;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label DecimalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BaseUpDown;
        private System.Windows.Forms.NumericUpDown ResultUpDown;
        private System.Windows.Forms.TextBox DecimalBox;
        private System.Windows.Forms.TextBox IntBaseBox;
        private System.Windows.Forms.Label BaseValueLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}


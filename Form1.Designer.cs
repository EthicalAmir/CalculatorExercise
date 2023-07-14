﻿namespace Calculator
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnbackSpace = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnMult);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnbackSpace);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnpoint.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btnpoint.ForeColor = System.Drawing.Color.White;
            this.btnpoint.Location = new System.Drawing.Point(0, 419);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(93, 86);
            this.btnpoint.TabIndex = 35;
            this.btnpoint.Text = ".";
            this.btnpoint.UseCompatibleTextRendering = true;
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.Form1_Load);
            this.btnpoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btnpoint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEqual.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(198, 419);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(93, 86);
            this.btnEqual.TabIndex = 34;
            this.btnEqual.Text = "=";
            this.btnEqual.UseCompatibleTextRendering = true;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMult.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(297, 419);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(93, 86);
            this.btnMult.TabIndex = 33;
            this.btnMult.Text = "*";
            this.btnMult.UseCompatibleTextRendering = true;
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btnMult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gray;
            this.btn0.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn0.Location = new System.Drawing.Point(99, 419);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 86);
            this.btn0.TabIndex = 32;
            this.btn0.Text = "0";
            this.btn0.UseCompatibleTextRendering = true;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(198, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 86);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCompatibleTextRendering = true;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            this.btnClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            // 
            // btnbackSpace
            // 
            this.btnbackSpace.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnbackSpace.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackSpace.ForeColor = System.Drawing.Color.White;
            this.btnbackSpace.Location = new System.Drawing.Point(0, 7);
            this.btnbackSpace.Name = "btnbackSpace";
            this.btnbackSpace.Size = new System.Drawing.Size(192, 86);
            this.btnbackSpace.TabIndex = 28;
            this.btnbackSpace.Text = "Backspace";
            this.btnbackSpace.UseCompatibleTextRendering = true;
            this.btnbackSpace.UseVisualStyleBackColor = false;
            this.btnbackSpace.Click += new System.EventHandler(this.btnbackSpace_Click);
            this.btnbackSpace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDiv.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(297, 112);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(93, 86);
            this.btnDiv.TabIndex = 27;
            this.btnDiv.Text = "/";
            this.btnDiv.UseCompatibleTextRendering = true;
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btnDiv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gray;
            this.btn9.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(198, 112);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 86);
            this.btn9.TabIndex = 26;
            this.btn9.Text = "9";
            this.btn9.UseCompatibleTextRendering = true;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gray;
            this.btn8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Location = new System.Drawing.Point(99, 112);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 86);
            this.btn8.TabIndex = 25;
            this.btn8.Text = "8";
            this.btn8.UseCompatibleTextRendering = true;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gray;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(0, 112);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 86);
            this.btn7.TabIndex = 24;
            this.btn7.Text = "7";
            this.btn7.UseCompatibleTextRendering = true;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMin.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(297, 213);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(93, 86);
            this.btnMin.TabIndex = 23;
            this.btnMin.Text = "-";
            this.btnMin.UseCompatibleTextRendering = true;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btnMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gray;
            this.btn6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Location = new System.Drawing.Point(198, 213);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 86);
            this.btn6.TabIndex = 22;
            this.btn6.Text = "6";
            this.btn6.UseCompatibleTextRendering = true;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gray;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Location = new System.Drawing.Point(99, 213);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 86);
            this.btn5.TabIndex = 21;
            this.btn5.Text = "5";
            this.btn5.UseCompatibleTextRendering = true;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gray;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Location = new System.Drawing.Point(0, 213);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 86);
            this.btn4.TabIndex = 20;
            this.btn4.Text = "4";
            this.btn4.UseCompatibleTextRendering = true;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPlus.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(297, 314);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(93, 86);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseCompatibleTextRendering = true;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btnPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gray;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Location = new System.Drawing.Point(198, 314);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 86);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseCompatibleTextRendering = true;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gray;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Location = new System.Drawing.Point(99, 314);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 86);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseCompatibleTextRendering = true;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gray;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(0, 314);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 86);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseCompatibleTextRendering = true;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorKeyPress);
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.LightCyan;
            this.btnOnOff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.ForeColor = System.Drawing.Color.Black;
            this.btnOnOff.Location = new System.Drawing.Point(309, 14);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(93, 27);
            this.btnOnOff.TabIndex = 31;
            this.btnOnOff.TabStop = false;
            this.btnOnOff.Text = "&On";
            this.btnOnOff.UseCompatibleTextRendering = true;
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Gray;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtDisplay.Location = new System.Drawing.Point(12, 47);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(390, 72);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.Color.Gray;
            this.txtHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistory.Enabled = false;
            this.txtHistory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtHistory.ForeColor = System.Drawing.Color.Black;
            this.txtHistory.Location = new System.Drawing.Point(12, 16);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(291, 25);
            this.txtHistory.TabIndex = 1;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(414, 646);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOnOff);
            this.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnbackSpace;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtHistory;
    }
}


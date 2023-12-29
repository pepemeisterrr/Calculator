namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonCE = new Button();
            buttonDivision = new Button();
            buttonMult = new Button();
            buttonC = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonMinus = new Button();
            buttonEqual = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonPlus = new Button();
            buttonDot = new Button();
            button0 = new Button();
            textBoxResult = new TextBox();
            labelCurrentOperation = new Label();
            buttonPlusMinus = new Button();
            buttonPOW = new Button();
            buttonSQRT = new Button();
            buttonPercent = new Button();
            buttonLog = new Button();
            textBoxLog = new TextBox();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(3, 287);
            button7.Name = "button7";
            button7.Size = new Size(115, 60);
            button7.TabIndex = 0;
            button7.TabStop = false;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += ButtonNumClick;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(118, 287);
            button8.Name = "button8";
            button8.Size = new Size(115, 60);
            button8.TabIndex = 1;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += ButtonNumClick;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(233, 287);
            button9.Name = "button9";
            button9.Size = new Size(115, 60);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += ButtonNumClick;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.FromArgb(64, 64, 64);
            buttonCE.FlatAppearance.BorderColor = Color.Black;
            buttonCE.FlatStyle = FlatStyle.Flat;
            buttonCE.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCE.ForeColor = Color.White;
            buttonCE.Location = new Point(233, 167);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(115, 60);
            buttonCE.TabIndex = 3;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += ButtonClearEntryClick;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = Color.FromArgb(64, 64, 64);
            buttonDivision.FlatAppearance.BorderColor = Color.Black;
            buttonDivision.FlatStyle = FlatStyle.Flat;
            buttonDivision.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivision.ForeColor = Color.White;
            buttonDivision.Location = new Point(348, 227);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(115, 60);
            buttonDivision.TabIndex = 4;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += ButtonOperatorClick;
            // 
            // buttonMult
            // 
            buttonMult.BackColor = Color.FromArgb(64, 64, 64);
            buttonMult.FlatAppearance.BorderColor = Color.Black;
            buttonMult.FlatStyle = FlatStyle.Flat;
            buttonMult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMult.ForeColor = Color.White;
            buttonMult.Location = new Point(348, 287);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(115, 60);
            buttonMult.TabIndex = 9;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = false;
            buttonMult.Click += ButtonOperatorClick;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(64, 64, 64);
            buttonC.FlatAppearance.BorderColor = Color.Black;
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonC.ForeColor = Color.White;
            buttonC.Location = new Point(348, 167);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(115, 60);
            buttonC.TabIndex = 8;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += ButtonClearClick;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(233, 347);
            button6.Name = "button6";
            button6.Size = new Size(115, 60);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += ButtonNumClick;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(118, 347);
            button5.Name = "button5";
            button5.Size = new Size(115, 60);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += ButtonNumClick;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 347);
            button4.Name = "button4";
            button4.Size = new Size(115, 60);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += ButtonNumClick;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.FromArgb(64, 64, 64);
            buttonMinus.FlatAppearance.BorderColor = Color.Black;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(348, 347);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(115, 60);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += ButtonOperatorClick;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.DeepSkyBlue;
            buttonEqual.FlatAppearance.BorderColor = Color.Black;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEqual.Location = new Point(348, 467);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(115, 60);
            buttonEqual.TabIndex = 13;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += ButtonEqualClick;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(233, 407);
            button3.Name = "button3";
            button3.Size = new Size(115, 60);
            button3.TabIndex = 12;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ButtonNumClick;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(118, 407);
            button2.Name = "button2";
            button2.Size = new Size(115, 60);
            button2.TabIndex = 11;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ButtonNumClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 407);
            button1.Name = "button1";
            button1.Size = new Size(115, 60);
            button1.TabIndex = 10;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonNumClick;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(64, 64, 64);
            buttonPlus.FlatAppearance.BorderColor = Color.Black;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlus.ForeColor = Color.White;
            buttonPlus.Location = new Point(348, 407);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(115, 60);
            buttonPlus.TabIndex = 19;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += ButtonOperatorClick;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = Color.DimGray;
            buttonDot.FlatAppearance.BorderColor = Color.Black;
            buttonDot.FlatStyle = FlatStyle.Flat;
            buttonDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDot.ForeColor = Color.White;
            buttonDot.Location = new Point(233, 467);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(115, 60);
            buttonDot.TabIndex = 17;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += ButtonDotClick;
            // 
            // button0
            // 
            button0.BackColor = Color.DimGray;
            button0.FlatAppearance.BorderColor = Color.Black;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = Color.White;
            button0.Location = new Point(118, 467);
            button0.Name = "button0";
            button0.Size = new Size(115, 60);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += Button0Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.FromArgb(32, 32, 32);
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.ForeColor = Color.White;
            textBoxResult.Location = new Point(27, 58);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(403, 54);
            textBoxResult.TabIndex = 20;
            textBoxResult.Text = "0";
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentOperation.ForeColor = Color.Silver;
            labelCurrentOperation.Location = new Point(250, 20);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 25);
            labelCurrentOperation.TabIndex = 21;
            // 
            // buttonPlusMinus
            // 
            buttonPlusMinus.BackColor = Color.DimGray;
            buttonPlusMinus.FlatAppearance.BorderColor = Color.Black;
            buttonPlusMinus.FlatStyle = FlatStyle.Flat;
            buttonPlusMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlusMinus.ForeColor = Color.White;
            buttonPlusMinus.Location = new Point(3, 467);
            buttonPlusMinus.Name = "buttonPlusMinus";
            buttonPlusMinus.Size = new Size(115, 60);
            buttonPlusMinus.TabIndex = 22;
            buttonPlusMinus.Text = "+/-";
            buttonPlusMinus.UseVisualStyleBackColor = false;
            buttonPlusMinus.Click += ButtonSignClick;
            // 
            // buttonPOW
            // 
            buttonPOW.BackColor = Color.FromArgb(64, 64, 64);
            buttonPOW.FlatAppearance.BorderColor = Color.Black;
            buttonPOW.FlatStyle = FlatStyle.Flat;
            buttonPOW.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPOW.ForeColor = Color.White;
            buttonPOW.Location = new Point(118, 227);
            buttonPOW.Name = "buttonPOW";
            buttonPOW.Size = new Size(115, 60);
            buttonPOW.TabIndex = 23;
            buttonPOW.Text = "exp";
            buttonPOW.UseVisualStyleBackColor = false;
            buttonPOW.Click += ButtonOperatorClick;
            // 
            // buttonSQRT
            // 
            buttonSQRT.BackColor = Color.FromArgb(64, 64, 64);
            buttonSQRT.FlatAppearance.BorderColor = Color.Black;
            buttonSQRT.FlatStyle = FlatStyle.Flat;
            buttonSQRT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSQRT.ForeColor = Color.White;
            buttonSQRT.Location = new Point(233, 227);
            buttonSQRT.Name = "buttonSQRT";
            buttonSQRT.Size = new Size(115, 60);
            buttonSQRT.TabIndex = 24;
            buttonSQRT.Text = "sqrt";
            buttonSQRT.UseVisualStyleBackColor = false;
            buttonSQRT.Click += ButtonSqrtClick;
            // 
            // buttonPercent
            // 
            buttonPercent.BackColor = Color.FromArgb(64, 64, 64);
            buttonPercent.FlatAppearance.BorderColor = Color.Black;
            buttonPercent.FlatStyle = FlatStyle.Flat;
            buttonPercent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPercent.ForeColor = Color.Transparent;
            buttonPercent.Location = new Point(3, 227);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(115, 60);
            buttonPercent.TabIndex = 25;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = false;
            buttonPercent.Click += ButtonPercentClick;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = Color.OrangeRed;
            buttonLog.FlatAppearance.BorderColor = Color.Black;
            buttonLog.FlatStyle = FlatStyle.Flat;
            buttonLog.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLog.ForeColor = Color.White;
            buttonLog.Location = new Point(3, 167);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(230, 60);
            buttonLog.TabIndex = 26;
            buttonLog.Text = "open logs";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += ButtonLogsClick;
            // 
            // textBoxLog
            // 
            textBoxLog.BackColor = Color.FromArgb(32, 32, 32);
            textBoxLog.BorderStyle = BorderStyle.None;
            textBoxLog.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLog.ForeColor = Color.White;
            textBoxLog.Location = new Point(27, 12);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(206, 22);
            textBoxLog.TabIndex = 27;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(464, 529);
            Controls.Add(textBoxLog);
            Controls.Add(buttonLog);
            Controls.Add(buttonPercent);
            Controls.Add(buttonSQRT);
            Controls.Add(buttonPOW);
            Controls.Add(buttonPlusMinus);
            Controls.Add(labelCurrentOperation);
            Controls.Add(textBoxResult);
            Controls.Add(buttonPlus);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(buttonMinus);
            Controls.Add(buttonEqual);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonMult);
            Controls.Add(buttonC);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonDivision);
            Controls.Add(buttonCE);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TransparencyKey = Color.IndianRed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonCE;
        private Button buttonDivision;
        private Button buttonMult;
        private Button buttonC;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonMinus;
        private Button buttonEqual;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonPlus;
        private Button buttonDot;
        private Button button0;
        private TextBox textBoxResult;
        private Label labelCurrentOperation;
        private Button buttonPlusMinus;
        private Button buttonPOW;
        private Button buttonSQRT;
        private Button buttonPercent;
        private Button buttonLog;
        private TextBox textBoxLog;
    }
}

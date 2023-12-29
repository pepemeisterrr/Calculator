using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic.Logging;
using System.Text;
using System.Diagnostics;

namespace Calculator
{
    public partial class Calculator : Form
    {
        
        string temp1 = "";
        string temp2 = "";
        string operation = "";
        bool isTemp = false;
        bool shouldClear = false;
        bool clickedEqual = false;

        public static void Log(string message, TextBox textBoxLog) // logger
        {
            textBoxLog.Text = message;
            string output = DateTime.Now.ToLongTimeString() + "     " + message;
            File.AppendAllText("log.txt", output); // Location: Calculator/bin/Debug/net8.0-windows/log.txt
        }
        public Calculator()
        {
            InitializeComponent();
            File.WriteAllText("log.txt", String.Empty);
            Log("Program started\n", textBoxLog);
        }

        private void ButtonNumClick(object sender, EventArgs e) // digits
        {
            if (textBoxResult.Text == "0") textBoxResult.Clear();
            if (shouldClear)
            {
                textBoxResult.Text = "";
                shouldClear = false;
            }
            if (clickedEqual)
            {
                labelCurrentOperation.Text = textBoxResult.Text;
                clickedEqual = false;
            }
            Button button = (Button)sender;
            if (!isTemp)
            {
                temp1 += button.Text;
                labelCurrentOperation.Text += button.Text;
                textBoxResult.Text = temp1;
            }
            else
            {
                labelCurrentOperation.Text += button.Text;
                textBoxResult.Text += button.Text;
            }
        }
        private void Button0Click(object sender, EventArgs e) // 0 button
        {
            if (!textBoxResult.Text.Equals("0"))
            {
                if (shouldClear)
                {
                    textBoxResult.Text = "";
                    shouldClear = false;
                }
                if (clickedEqual)
                {
                    labelCurrentOperation.Text = textBoxResult.Text;
                    clickedEqual = false;
                }
                Button button = (Button)sender;
                if (!isTemp)
                {
                    temp1 += button.Text;
                    labelCurrentOperation.Text += button.Text;
                    textBoxResult.Text = temp1;
                }
                else
                {
                    labelCurrentOperation.Text += button.Text;
                    textBoxResult.Text += button.Text;
                }
            }
        }

        private void ButtonOperatorClick(object sender, EventArgs e) // simple operators which require to values
        {
            if (operation == "")
            {
                Button button = (Button)sender;
                operation = button.Text;
                labelCurrentOperation.Text = temp1 + " " + operation + " ";
                isTemp = true;
                shouldClear = true;
            }
            else
            {
                Button button = (Button)sender;
                operation = button.Text;
                temp1 = textBoxResult.Text;
                labelCurrentOperation.Text = temp1 + " " + operation + " ";
                clickedEqual = false;
                shouldClear = true;
            }
        }

        private void ButtonDotClick(object sender, EventArgs e) // . button
        {
            if (!textBoxResult.Text.Contains("."))
            {
                if (shouldClear)
                {
                    textBoxResult.Text = "";
                    shouldClear = false;
                }
                if (clickedEqual)
                {
                    labelCurrentOperation.Text = textBoxResult.Text;
                    clickedEqual = false;
                }
                Button button = (Button)sender;
                if (!isTemp)
                {
                    if (textBoxResult.Text.Equals("0"))
                    {
                        temp1 += "0";
                        labelCurrentOperation.Text += temp1;
                    }
                    temp1 += button.Text;
                    labelCurrentOperation.Text += button.Text;
                    textBoxResult.Text = temp1;
                }
                else
                {
                    labelCurrentOperation.Text += button.Text;
                    textBoxResult.Text += button.Text;
                }
            }
        }

        private void ButtonSignClick(object sender, EventArgs e) // button +/-
        {
            if (!isTemp)
            {
                temp1 = (Convert.ToDouble(temp1) * (-1)).ToString();
                textBoxResult.Text = temp1;
                labelCurrentOperation.Text = temp1;
            }
            else
            {
                labelCurrentOperation.Text = labelCurrentOperation.Text.Replace(textBoxResult.Text, "");
                textBoxResult.Text = (Convert.ToDouble(textBoxResult.Text) * (-1)).ToString();
                labelCurrentOperation.Text += textBoxResult.Text;
            }
        }

        private void ButtonSqrtClick(object sender, EventArgs e) // sqrt button
        {
            if (!isTemp)
            {
                temp1 = (Math.Sqrt(Convert.ToDouble(textBoxResult.Text))).ToString();
                textBoxResult.Text = temp1;
                labelCurrentOperation.Text = temp1;
            }
            else
            {
                labelCurrentOperation.Text = labelCurrentOperation.Text.Replace(textBoxResult.Text, "");
                labelCurrentOperation.Text += "sqrt(" + textBoxResult.Text + ")";
                textBoxResult.Text = (Math.Sqrt(Convert.ToDouble(textBoxResult.Text))).ToString();
            }
        }

        private void ButtonPercentClick(object sender, EventArgs e) // % button
        {
            if (!isTemp)
            {
                temp1 = (Convert.ToDouble(temp1) * 0.01).ToString();
                textBoxResult.Text = temp1;
                labelCurrentOperation.Text = temp1;
            }
            else
            {
                labelCurrentOperation.Text = labelCurrentOperation.Text.Replace(textBoxResult.Text, "");
                textBoxResult.Text = (Convert.ToDouble(textBoxResult.Text) * 0.01).ToString();
                labelCurrentOperation.Text += textBoxResult.Text;
            }
        }

        private void ButtonEqualClick(object sender, EventArgs e) // = Button
        {
            if (!clickedEqual)
            {
                labelCurrentOperation.Text += " =";
                temp2 = textBoxResult.Text;
                switch (operation)
                {
                    case "+":
                        textBoxResult.Text = (Convert.ToDouble(temp1) + Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "-":
                        textBoxResult.Text = (Convert.ToDouble(temp1) - Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "*":
                        textBoxResult.Text = (Convert.ToDouble(temp1) * Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "/":
                        textBoxResult.Text = (Convert.ToDouble(temp1) / Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "exp":
                        textBoxResult.Text = (Math.Pow(Convert.ToDouble(temp1), Convert.ToDouble(textBoxResult.Text))).ToString();
                        break;
                }
                temp1 = temp2;
                clickedEqual = true;
                Log("<Result>   " + labelCurrentOperation.Text + " " + textBoxResult.Text + "\n" ,textBoxLog);
            }
            else
            {
                labelCurrentOperation.Text = textBoxResult.Text + " " + operation + " " + temp2 + " =";
                switch (operation)
                {
                    case "+":
                        textBoxResult.Text = (Convert.ToDouble(temp1) + Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "-":
                        textBoxResult.Text = (Convert.ToDouble(temp1) - Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "*":
                        textBoxResult.Text = (Convert.ToDouble(temp1) * Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "/":
                        textBoxResult.Text = (Convert.ToDouble(temp1) / Convert.ToDouble(textBoxResult.Text)).ToString();
                        break;
                    case "exp":
                        textBoxResult.Text = (Math.Pow(Convert.ToDouble(temp1), Convert.ToDouble(textBoxResult.Text))).ToString();
                        break;
                }
            }
        }

        private void ButtonClearClick(object sender, EventArgs e) // C button
        {
            Log("<Cleared>  " +labelCurrentOperation.Text + " " + textBoxResult.Text + "\n", textBoxLog);
            temp1 = "";
            temp2 = "";
            operation = "";
            textBoxResult.Text = "0";
            labelCurrentOperation.Text = "";
            isTemp = false;
            shouldClear = false;
            clickedEqual = false;
        }

        private void ButtonClearEntryClick(object sender, EventArgs e) //CE button
        {
            labelCurrentOperation.Text = labelCurrentOperation.Text.Replace(textBoxResult.Text, "");
            textBoxResult.Text = "";
        }

        private void ButtonLogsClick(object sender, EventArgs e) // opens log.txt
        {
            Log("<Opened file>", textBoxLog); // logs are cleared after each restart
            Process notePad = new Process();
            notePad.StartInfo.FileName = "Notepad.exe";
            notePad.StartInfo.Arguments = "log.txt";
            notePad.Start();
        }
    }
}

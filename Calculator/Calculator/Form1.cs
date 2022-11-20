using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
//Your name: Husam Alauichi
//Description: Calculator
//Date Created: 9/14/2020


{
    public partial class Calculator : Form
    {
      
        public Calculator()
        {
            InitializeComponent();
        }

        // some string to be used in the calculation process & identify the top & btm rows.

        string operation; 
        string input = string.Empty;
        string firstNumbers = string.Empty;
        string secondNumbers = string.Empty;
        double result = 0.0;


        private void Calculator_Load(object sender, EventArgs e)
        {
            
            //lblResultsbtm.Text = result.ToString();
        }

        public void DoCalculate9()
        {
            string secondNumbers = input;
            double num1, num2;
            double.TryParse(firstNumbers, out num1);
            double.TryParse(secondNumbers, out num2);




            if (this.lblResultsbtm.Text == "0")
            {
                lblResultsbtm.Text = "0";
                MessageBox.Show("No data has been enter to perform a calculation, please " +
                     "try again!", "<Alauichi-calculator>"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (secondNumbers == "")
            {
                lblResultsbtm.Text = "";
                MessageBox.Show("You must enter two numbers to perform a calculation, please " +
                     "try again!", "<Alauichi-calculator>"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            // addition operation
            if (operation == "+")
            {
                lblResultstop.Text += lblResultsbtm.Text;
                result = num1 + num2;
                lblResultsbtm.Text = result.ToString();
                input = string.Empty;

            }

            // subtraction operation
            else if (operation == "-")
            {
                lblResultstop.Text += lblResultsbtm.Text;
                result = num1 - num2;
                lblResultsbtm.Text = result.ToString();
                input = string.Empty;
            }

            // multiplication operation
            else if (operation == "*")
            {
                lblResultstop.Text += lblResultsbtm.Text;
                result = num1 * num2;
                lblResultsbtm.Text = result.ToString();
                input = string.Empty;
            }

            // division operation
            else if (operation == "/")
            {
                lblResultstop.Text += lblResultsbtm.Text;
                result = num1 / num2;
                lblResultsbtm.Text = result.ToString();
                input = string.Empty;
            }

            // sqaure root operation
            else if (lblResultsbtm.Text == input)
            {
                try
                {
                    lblResultsbtm.Text = ($"{Math.Sqrt(Convert.ToDouble(input))}");
                    input = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // raised to the power operation
            else if (lblResultsbtm.Text == input)
            {
                try
                {

                    lblResultsbtm.Text = ($"{Math.Pow(num1, num2).ToString()}");
                    input = string.Empty;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DoCalculate_Click(object sender, EventArgs e)
        {

            this.DoCalculate9();

        }
      



        // addition operation
        private void AddValues_Click(object sender, EventArgs e)
        {
            
                lblResultstop.Text = input + "  +  ";
                firstNumbers = input;
                operation = "+";
                input = string.Empty;
                MultiplyValues.Enabled = false;
                SubtractValues.Enabled = false;
                DivideValues.Enabled = false;


        }

        // subtraction operation
        private void SubtractValues_Click(object sender, EventArgs e)
        {
            lblResultstop.Text = input + "  -  ";
            firstNumbers = input;
            operation = "-";
            input = string.Empty;
            AddValues.Enabled = false;
            MultiplyValues.Enabled = false;
            DivideValues.Enabled = false;
        }

        // multiplication operation
        private void MultiplyValues_Click(object sender, EventArgs e)
        {
            lblResultstop.Text = input + "  *  ";
            firstNumbers = input;
            operation = "*";
            input = string.Empty;
            AddValues.Enabled = false;
            SubtractValues.Enabled = false;
            DivideValues.Enabled = false;
        }

        public void DivideValues9()
        {
            lblResultstop.Text = input + "  /  ";
            firstNumbers = input;
            operation = "/";
            input = string.Empty;
            MultiplyValues.Enabled = false;
            AddValues.Enabled = false;
            SubtractValues.Enabled = false;
        }
        //division operation
        private void DivideValues_Click(object sender, EventArgs e)
        {
            this.DivideValues9();
           
        }

        // clear button
        private void ClearForm_Click(object sender, EventArgs e)
        {
            lblResultstop.Text = "";
            lblResultsbtm.Text = "0";
            input = string.Empty;
            MultiplyValues.Enabled = true;
            AddValues.Enabled = true;
            SubtractValues.Enabled = true;
            DivideValues.Enabled = true;
        }



        // . button
        private void btnpoint_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += ".";
            lblResultsbtm.Text += input;

        }

        // 0 button
        private void btn0_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "0";
            lblResultsbtm.Text += input;
        }

        // 1 button
        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "1";
            lblResultsbtm.Text += input;
        }

        // 2 button
        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "2";
            lblResultsbtm.Text += input;
        }

        // 3 button
        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "3";
            lblResultsbtm.Text += input;
        }

        // 4 button
        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "4";
            lblResultsbtm.Text += input;
        }

        // 5 button
        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "5";
            lblResultsbtm.Text += input;
        }

        // 6 button
        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "6";
            lblResultsbtm.Text += input;
        }

        // 7 button
        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "7";
            lblResultsbtm.Text += input;
        }

        // 8 button
        private void btn8_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "8";
            lblResultsbtm.Text += input;
        }

        // 9 button
        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultsbtm.Text = "";
            input += "9";
            lblResultsbtm.Text += input;
        }

        // futur feature1 method
        private void Future1FeatureNotAvailable()
        {
            MessageBox.Show("Future function 1 operation is not " +
                    "available for this version.", "<Alauichi-calculator>"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void future1Button_Click(object sender, EventArgs e)
        {
            this.Future1FeatureNotAvailable();
        }

        // futur feature2 method
        private void Future2FeatureNotAvailable()
        {
            MessageBox.Show("Future operation function 2 is not " +
                    "available for this version!", "<Alauichi-calculator>"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void futur2Button_Click(object sender, EventArgs e)
        {
            this.Future2FeatureNotAvailable();
        }


        public void SquareRootValues9()
        {
            try
            {
                if (lblResultsbtm.Text == input)
                {
                    lblResultstop.Text = ($"The Square Root of {input}");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception Message: " + ex.Message);
            }
        }
        // sqr root
        private void SquareRootValues_Click(object sender, EventArgs e)
        {
            this.SquareRootValues9();
          
        }

        public void RaisePowerValues9()
        {
            try
            {
                if (lblResultsbtm.Text == input)
                {
                    lblResultstop.Text = ($"{input} Raised to the power of");
                    input = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // raise power
        private void RaisePowerValues_Click(object sender, EventArgs e)
        {
            this.RaisePowerValues9();
        }

        private void lblResultstop_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 viewcontactlist = new Form2();
           // viewcontactlist.MdiParent = this;
            viewcontactlist.Show();
        }
    }
    
}

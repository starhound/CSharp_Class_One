using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD4_CP6_P7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool InputValid(ref double future, ref int years, ref double interest)
        {
            if(double.TryParse(futureTextBox.Text, out future))
            {
                if(Int32.TryParse(yearsTextBox.Text, out years))
                {
                    if(double.TryParse(interestTextBox.Text, out interest))
                    {
                        return true;
                    } 
                    else
                    {
                        MessageBox.Show("Invalid interest input.");
                    }
                } else
                {
                    MessageBox.Show("Invalid years input.");
                }
            } else
            {
                MessageBox.Show("Invalid future amount input.");
            }
            return false;
        }

        private double PresentValue(ref double future, ref int years, ref double interest)
        {
            double present = future / Math.Pow(1 + interest, years);
            return present;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            futureTextBox.Text = "";
            interestTextBox.Text = "";
            yearsTextBox.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int years = 0;
            double future = 0.0, interest = 0.0;

            if(InputValid(ref future, ref years, ref interest))
            {
                double presentValue = PresentValue(ref future, ref years, ref interest);
                outputLabel.Text = presentValue.ToString("c");
            }
        }
    }
}

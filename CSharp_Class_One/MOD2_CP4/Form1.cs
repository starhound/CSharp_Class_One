using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD2_CP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //verify all desired input has been accomplished (amount to convert, convert from, convert to)
            double inputUnit;
            try
            {
                inputUnit = double.Parse(inputTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter in an amount of units to convert.", "Error");
                return;
            }

            string convertFrom = "";

            try
            {
                convertFrom = fromListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a unit to convert from.", "Error");
                return;
            }

            string convertTo = "";
            try
            {
                convertTo = toListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a unit to convert to.", "Error");
                return;
            } 

            //if we're not converting units, print the input
            if(convertFrom.Equals(convertTo))
            {
                outputLabel.Text = inputUnit.ToString("n");
                return;
            }

            double converted_total = 0;

            //should not require redundent checking for each sub-case 
            switch(convertTo)
            {
                case "Inches":
                    switch(convertFrom)
                    {
                        case "Feet":
                            converted_total = inputUnit * 12;
                            break;
                        case "Yards":
                            converted_total = inputUnit * 12 * 3;
                            break;
                    }
                    break;
                case "Feet":
                    switch (convertFrom)
                    {
                        case "Inches":
                            converted_total = inputUnit / 12;
                            break;
                        case "Yards":
                            converted_total = inputUnit * 3;
                            break;
                    }
                    break;
                case "Yards":
                    switch (convertFrom)
                    {
                        case "Inches":
                            converted_total = inputUnit / 12 / 3;
                            break;
                        case "Feet":
                            converted_total = inputUnit / 3;
                            break;

                    }
                    break;
            }

            outputLabel.Text = converted_total.ToString();      
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

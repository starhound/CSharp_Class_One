using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mod3_CP5_P13
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //attempt to convert input into int
                int quantity = Int32.Parse(quantityTextBox.Text);

                //create random class instance
                var rand = new Random();

                //generate new array of requested input size
                int[] numbers = new int[quantity];

                //loop over the array
                for (int i = 0; i != numbers.Length; i++)
                {
                    //generate random number 1-100
                    int num = rand.Next(101);

                    //push number into array
                    numbers[i] = num;

                    //report number in output list box
                    outputListBox.Items.Add(numbers[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter an amount of numbers to generate.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //ensure list box is populated
            if(outputListBox.Items.Count > 0)
            {
                //start a save file dialog
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //define new string array with a size of the list box item count
                    string[] numbers = new string[outputListBox.Items.Count];

                    //loop over new array and grab items from list box and transfer them into the string array
                    for (int i = 0; i < numbers.Length; i++)
                        numbers[i] = outputListBox.GetItemText(outputListBox.Items[i]);

                    //write string array to file
                    System.IO.File.WriteAllLines(saveFile.FileName, numbers);
                }
                //catch invalid save file dialog errors
                else
                {
                    MessageBox.Show("Invalid save file location!");
                }
            }
            //notify of requirement to populate list box
            else
            {
                MessageBox.Show("Please generate numbers first!");
            }
        }
    }
}

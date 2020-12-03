using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD6_CP8_P10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            outputTextBox.Text = "";
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //identifiers
            char dot = '.';
            char dash = '-';

            //construct a mapping or "dictionary" of letters and values to their string form of morse code
            Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {'a', string.Concat(dot, dash)},
                {'b', string.Concat(dash, dot, dot, dot)},
                {'c', string.Concat(dash, dot, dash, dot)},
                {'d', string.Concat(dash, dot, dot)},
                {'e', dot.ToString()},
                {'f', string.Concat(dot, dot, dash, dot)},
                {'g', string.Concat(dash, dash, dot)},
                {'h', string.Concat(dot, dot, dot, dot)},
                {'i', string.Concat(dot, dot)},
                {'j', string.Concat(dot, dash, dash, dash)},
                {'k', string.Concat(dash, dot, dash)},
                {'l', string.Concat(dot, dash, dot, dot)},
                {'m', string.Concat(dash, dash)},
                {'n', string.Concat(dash, dot)},
                {'o', string.Concat(dash, dash, dash)},
                {'p', string.Concat(dot, dash, dash, dot)},
                {'q', string.Concat(dash, dash, dot, dash)},
                {'r', string.Concat(dot, dash, dot)},
                {'s', string.Concat(dot, dot, dot)},
                {'t', string.Concat(dash)},
                {'u', string.Concat(dot, dot, dash)},
                {'v', string.Concat(dot, dot, dot, dash)},
                {'w', string.Concat(dot, dash, dash)},
                {'x', string.Concat(dash, dot, dot, dash)},
                {'y', string.Concat(dash, dot, dash, dash)},
                {'z', string.Concat(dash, dash, dot, dot)},
                {'0', string.Concat(dash, dash, dash, dash, dash)},
                {'1', string.Concat(dot, dash, dash, dash, dash)},
                {'2', string.Concat(dot, dot, dash, dash, dash)},
                {'3', string.Concat(dot, dot, dot, dash, dash)},
                {'4', string.Concat(dot, dot, dot, dot, dash)},
                {'5', string.Concat(dot, dot, dot, dot, dot)},
                {'6', string.Concat(dash, dot, dot, dot, dot)},
                {'7', string.Concat(dash, dash, dot, dot, dot)},
                {'8', string.Concat(dash, dash, dash, dot, dot)},
                {'9', string.Concat(dash, dash, dash, dash, dot)},
                {' ', " "},
                {',', string.Concat(dash, dash, dot, dot, dash, dash)},
                {'.', string.Concat(dot, dash, dot, dash, dot, dash)},
            };

            //grab input
            string input = inputTextBox.Text;

            //split into string array of individual words
            string[] input_array = input.Split(' ');

            //first break up the message into words, then convert each individual word to morse code and recombine message 

            //output string
            string out_message = "";

            foreach(string word in input_array)
            {
                //convert all letters to lowercase as we haven't defined them in our dictionary
                string lower_case_word = word.ToLower();

                //seperate letters into char array
                char[] letters = lower_case_word.ToCharArray();

                //begin loop of letters in word
                foreach(char letter in letters)
                {
                    //search dictionary 
                    string morse_code_translation = morse[letter];
                    
                    //add morse code for letter to output message
                    out_message += morse_code_translation;
                }

                //end of word, add space or slash as desired.
                out_message += " / ";
            }

            outputTextBox.Text = out_message;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //rich text boxes are weird and different than normal ones so some QoL code 
        //i injected for copying output. couldn't figure it out in the form designer!
        private void copyButton_Click(object sender, EventArgs e)
        {
            if(outputTextBox.Text.Length > 0)
            {
                outputTextBox.SelectAll();
                outputTextBox.Copy();
                MessageBox.Show(outputTextBox.Text + " copied to clipboard!");
                return;
            }
            MessageBox.Show("No converted text to copy to clipboard!");
        }
    }
}

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

namespace MOD5_CP7_P6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadBoyNames(List<string> nameList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("BoyNames.txt");
                while (!inputFile.EndOfStream)
                {
                    nameList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadGirlNames(List<string> nameList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("GirlNames.txt");
                while (!inputFile.EndOfStream)
                {
                    nameList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool SearchBoyList(List<string> nameList, string name)
        {
            foreach(string boyListName in nameList)
            {
                if(boyListName.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private bool SearchGirlList(List<string> nameList, string name)
        {
            foreach(string girlListName in nameList)
            {
                if (girlListName.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool boyFound = false;
            bool girlFound = false;
            var boyNameList = new List<string>();
            var girlNameList = new List<string>();
            string boyName = boyTextBox.Text;
            string girlName = girlTextBox.Text;

            if(boyName.Length > 0)
            {
                ReadBoyNames(boyNameList);
                boyFound = SearchBoyList(boyNameList, boyName);

                if(boyFound)
                {
                    boyOutputLabel.Text = "Yes";
                }
                else
                {
                    boyOutputLabel.Text = "No";
                }
            }
            
            if(girlName.Length > 0)
            {
                ReadGirlNames(girlNameList);
                girlFound = SearchGirlList(girlNameList, girlName);

                if(girlFound)
                {
                    girlOutputLabel.Text = "Yes";
                }
                else
                {
                    girlOutputLabel.Text = "No";
                }
            }
        }
    }
}

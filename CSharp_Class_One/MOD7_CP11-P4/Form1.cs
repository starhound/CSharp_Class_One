using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD7_CP11_P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Person
        {
            //constructor
            public Person(string name, string address, string phone)
            {
                Name = name;
                Address = address;
                Phone = phone;
            }
            //override of ToString for displaying information through message box
            public override string ToString()
            {
                string outString = "";
                outString += "type: Person";
                outString += "\n";
                outString += "Name: " + Name;
                outString += "\n";
                outString += "Address: " + Address;
                outString += "\n";
                outString += "Phone: " + Phone;
                return outString;
            }

            //getters, setters
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Name { get; set; }
        }

        //customer subclass of person
        public class Customer : Person
        {
            //constructor, with subclass argument settings
            public Customer(string name, string address, string phone, int number, bool mailing) : base(name, address, phone)
            {
                CustomerNumber = number;
                MailingList = mailing;

            }

            //for displaying information
            public override string ToString()
            {
                string outString = "";
                outString += "type: Customer";
                outString += "\n";
                outString += "Name: " + Name;
                outString += "\n";
                outString += "Address: " + Address;
                outString += "\n";
                outString += "Phone: " + Phone;
                outString += "\n";
                outString += "Customer Number: " + CustomerNumber;
                outString += "\n";
                outString += "Mailing List: " + MailingList;
                return outString;
            }

            //additional getts/setters
            public int CustomerNumber { get; set; }
            public bool MailingList { get; set; }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadPersonButton_Click(object sender, EventArgs e)
        {
            //gather input
            string name, address, phone;

            name = nameTextBox.Text;
            address = addressTextBox.Text;
            phone = phoneTextBox.Text;

            //is customer
            if(customCheckBox.Checked)
            {
                int customer_num = 0;
                bool mailing_list;
                try
                {
                    customer_num = Int32.Parse(customerNumberTextBox.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (mailingListCheckBox.Checked)
                    mailing_list = true;
                else
                    mailing_list = false;

                //new customer object
                Customer newCustomer = new Customer(name, address, phone, customer_num, mailing_list);

                //display info
                MessageBox.Show(newCustomer.ToString());
                //end function
                return;
            }

            //is not customer so create person object and display info
            Person newPerson = new Person(name, address, phone);
            MessageBox.Show(newPerson.ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            phoneTextBox.Text = "";
            customerNumberTextBox.Text = "";
            customCheckBox.Checked = false;
            mailingListCheckBox.Checked = false;

        }
    }
}

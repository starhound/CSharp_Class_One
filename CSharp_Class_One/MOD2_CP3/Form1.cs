using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD2_CP3
{
    public partial class Form1 : Form
    {
        int aRevenue, bRevenue, cRevenue, aTotal, bTotal, cTotal, totalRevenue = 0;
        const int classACost = 15;
        const int classBCost = 12;
        const int classCCost = 9;

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";
            classARevenueLabel.Text = "";
            classBRevenueLabel.Text = "";
            classCRevenueLabel.Text = "";
            totalRevenueLabel.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            aRevenue = Int32.Parse(classATextBox.Text);
            bRevenue = Int32.Parse(classBTextBox.Text);
            cRevenue = Int32.Parse(classCTextBox.Text);

            aTotal = aRevenue * classACost;
            bTotal = bRevenue * classBCost;
            cTotal = cRevenue * classCCost;

            totalRevenue = aTotal + bTotal + cTotal;

            classARevenueLabel.Text = aTotal.ToString("c");
            classBRevenueLabel.Text = bTotal.ToString("c");
            classCRevenueLabel.Text = cTotal.ToString("c");

            totalRevenueLabel.Text = totalRevenue.ToString("c");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

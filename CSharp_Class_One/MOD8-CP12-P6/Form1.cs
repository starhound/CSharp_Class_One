using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD8_CP12_P6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sortAscendingToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cityTableAdapter.FillAscending(this.populationDBDataSet.City);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            //verify one option is selected
            if(!checkBoxByName.Checked && !checkBoxPopulationAscending.Checked && !checkBoxPopulationDecending.Checked)
            {
                MessageBox.Show("Please select a sorting option.");
                return;
            }
            //verify only one checked box
            if(checkBoxByName.Checked && (checkBoxPopulationAscending.Checked || checkBoxPopulationDecending.Checked))
            {
                MessageBox.Show("Only sort by one option please");
                return;
            }
            else if(checkBoxPopulationAscending.Checked && (checkBoxByName.Checked || checkBoxPopulationDecending.Checked))
            {
                MessageBox.Show("Only sort by one option please");
                return;
            }
            else if(checkBoxPopulationDecending.Checked && (checkBoxByName.Checked || checkBoxPopulationAscending.Checked))
            {
                MessageBox.Show("Only sort by one option please");
                return;
            }
            //sort accordingly
            if(checkBoxByName.Checked)
            {
                this.cityTableAdapter.FillByName(this.populationDBDataSet.City);
                return;
            }
            if(checkBoxPopulationAscending.Checked)
            {
                this.cityTableAdapter.FillByAscending(this.populationDBDataSet.City);
                return;
            }
            if(checkBoxPopulationDecending.Checked)
            {
                this.cityTableAdapter.FillByDecending(this.populationDBDataSet.City);
                return;
            }
        }

        private void totalPopulationButton_Click(object sender, EventArgs e)
        {
            double total;
            total = (double)this.cityTableAdapter.TotalQuery();
            MessageBox.Show("Population total: " + total.ToString());
        }

        private void averagePopulationButton_Click(object sender, EventArgs e)
        {
            double avg;
            avg = (double)this.cityTableAdapter.AverageQuery();
            MessageBox.Show("Population Average: " + avg.ToString());
        }

        private void highestPopulationButton_Click(object sender, EventArgs e)
        {
            double max;
            max = (double)this.cityTableAdapter.MaxQuery();
            MessageBox.Show("Max Population: " + max.ToString());
        }

        private void lowestPopulationButton_Click(object sender, EventArgs e)
        {
            double max;
            max = (double)this.cityTableAdapter.MaxQuery();
            double total;
            total = (double)this.cityTableAdapter.TotalQuery();
            double avg;
            avg = (double)this.cityTableAdapter.AverageQuery();
            double min;
            min = (double)this.cityTableAdapter.MinQuery();
            MessageBox.Show("Min population: " + min.ToString() + "\n" + "Total Population: " + total.ToString() + "\n" + "Average Population: " + avg.ToString() + "\n" + "Max Population: " + max.ToString());
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            double population;
            try
            {
                population = Double.Parse(populationTextBox.Text);
                string name = cityNameTextBox.Text;
                this.cityTableAdapter.InsertQuery(name, population);
                MessageBox.Show("City added!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount == 0)
            {
                MessageBox.Show("Please select only one row to delete.");
                return;
            }

            if(selectedRowCount > 1)
            {
                MessageBox.Show("Please select only one row to delete.");
                return;
            }

            foreach (DataGridViewCell oneCell in dataGrid.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGrid.Rows.RemoveAt(oneCell.RowIndex);
            }
            MessageBox.Show("Row Deleted!");
        }
    }
}

namespace MOD8_CP12_P6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.addRowLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.checkBoxPopulationAscending = new System.Windows.Forms.CheckBox();
            this.checkBoxPopulationDecending = new System.Windows.Forms.CheckBox();
            this.checkBoxByName = new System.Windows.Forms.CheckBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.totalPopulationButton = new System.Windows.Forms.Button();
            this.averagePopulationButton = new System.Windows.Forms.Button();
            this.highestPopulationButton = new System.Windows.Forms.Button();
            this.lowestPopulationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationDBDataSet = new MOD8_CP12_P6.PopulationDBDataSet();
            this.cityTableAdapter = new MOD8_CP12_P6.PopulationDBDataSetTableAdapters.CityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.cityBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(287, 375);
            this.dataGrid.TabIndex = 0;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(368, 37);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityNameTextBox.TabIndex = 1;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(368, 72);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 20);
            this.populationTextBox.TabIndex = 2;
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Location = new System.Drawing.Point(305, 37);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(58, 13);
            this.cityNameLabel.TabIndex = 3;
            this.cityNameLabel.Text = "City Name:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(305, 79);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(60, 13);
            this.populationLabel.TabIndex = 4;
            this.populationLabel.Text = "Population:";
            // 
            // addRowLabel
            // 
            this.addRowLabel.AutoSize = true;
            this.addRowLabel.Location = new System.Drawing.Point(305, 12);
            this.addRowLabel.Name = "addRowLabel";
            this.addRowLabel.Size = new System.Drawing.Size(54, 13);
            this.addRowLabel.TabIndex = 5;
            this.addRowLabel.Text = "Add Row:";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(305, 163);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(82, 13);
            this.sortLabel.TabIndex = 6;
            this.sortLabel.Text = "Sorting Options:";
            // 
            // checkBoxPopulationAscending
            // 
            this.checkBoxPopulationAscending.AutoSize = true;
            this.checkBoxPopulationAscending.Location = new System.Drawing.Point(308, 179);
            this.checkBoxPopulationAscending.Name = "checkBoxPopulationAscending";
            this.checkBoxPopulationAscending.Size = new System.Drawing.Size(135, 17);
            this.checkBoxPopulationAscending.TabIndex = 7;
            this.checkBoxPopulationAscending.Text = "Population (Ascending)";
            this.checkBoxPopulationAscending.UseVisualStyleBackColor = true;
            // 
            // checkBoxPopulationDecending
            // 
            this.checkBoxPopulationDecending.AutoSize = true;
            this.checkBoxPopulationDecending.Location = new System.Drawing.Point(308, 202);
            this.checkBoxPopulationDecending.Name = "checkBoxPopulationDecending";
            this.checkBoxPopulationDecending.Size = new System.Drawing.Size(137, 17);
            this.checkBoxPopulationDecending.TabIndex = 8;
            this.checkBoxPopulationDecending.Text = "Population (Decending)";
            this.checkBoxPopulationDecending.UseVisualStyleBackColor = true;
            // 
            // checkBoxByName
            // 
            this.checkBoxByName.AutoSize = true;
            this.checkBoxByName.Location = new System.Drawing.Point(308, 225);
            this.checkBoxByName.Name = "checkBoxByName";
            this.checkBoxByName.Size = new System.Drawing.Size(84, 17);
            this.checkBoxByName.TabIndex = 9;
            this.checkBoxByName.Text = "Alphabetical";
            this.checkBoxByName.UseVisualStyleBackColor = true;
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(393, 111);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(75, 23);
            this.addDataButton.TabIndex = 10;
            this.addDataButton.Text = "Add";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(368, 268);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 11;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // totalPopulationButton
            // 
            this.totalPopulationButton.Location = new System.Drawing.Point(584, 158);
            this.totalPopulationButton.Name = "totalPopulationButton";
            this.totalPopulationButton.Size = new System.Drawing.Size(117, 23);
            this.totalPopulationButton.TabIndex = 12;
            this.totalPopulationButton.Text = "Total Poulation";
            this.totalPopulationButton.UseVisualStyleBackColor = true;
            this.totalPopulationButton.Click += new System.EventHandler(this.totalPopulationButton_Click);
            // 
            // averagePopulationButton
            // 
            this.averagePopulationButton.Location = new System.Drawing.Point(584, 187);
            this.averagePopulationButton.Name = "averagePopulationButton";
            this.averagePopulationButton.Size = new System.Drawing.Size(117, 23);
            this.averagePopulationButton.TabIndex = 13;
            this.averagePopulationButton.Text = "Average Population";
            this.averagePopulationButton.UseVisualStyleBackColor = true;
            this.averagePopulationButton.Click += new System.EventHandler(this.averagePopulationButton_Click);
            // 
            // highestPopulationButton
            // 
            this.highestPopulationButton.Location = new System.Drawing.Point(584, 216);
            this.highestPopulationButton.Name = "highestPopulationButton";
            this.highestPopulationButton.Size = new System.Drawing.Size(117, 23);
            this.highestPopulationButton.TabIndex = 14;
            this.highestPopulationButton.Text = "Highest Population";
            this.highestPopulationButton.UseVisualStyleBackColor = true;
            this.highestPopulationButton.Click += new System.EventHandler(this.highestPopulationButton_Click);
            // 
            // lowestPopulationButton
            // 
            this.lowestPopulationButton.Location = new System.Drawing.Point(584, 245);
            this.lowestPopulationButton.Name = "lowestPopulationButton";
            this.lowestPopulationButton.Size = new System.Drawing.Size(117, 23);
            this.lowestPopulationButton.TabIndex = 15;
            this.lowestPopulationButton.Text = "Lowest Population";
            this.lowestPopulationButton.UseVisualStyleBackColor = true;
            this.lowestPopulationButton.Click += new System.EventHandler(this.lowestPopulationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(522, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Location = new System.Drawing.Point(224, 415);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRowButton.TabIndex = 17;
            this.deleteRowButton.Text = "Delete Row";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.populationDBDataSet;
            // 
            // populationDBDataSet
            // 
            this.populationDBDataSet.DataSetName = "PopulationDBDataSet";
            this.populationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 458);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lowestPopulationButton);
            this.Controls.Add(this.highestPopulationButton);
            this.Controls.Add(this.averagePopulationButton);
            this.Controls.Add(this.totalPopulationButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.checkBoxByName);
            this.Controls.Add(this.checkBoxPopulationDecending);
            this.Controls.Add(this.checkBoxPopulationAscending);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.addRowLabel);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.cityNameLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private PopulationDBDataSet populationDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label addRowLabel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.CheckBox checkBoxPopulationAscending;
        private System.Windows.Forms.CheckBox checkBoxPopulationDecending;
        private System.Windows.Forms.CheckBox checkBoxByName;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button totalPopulationButton;
        private System.Windows.Forms.Button averagePopulationButton;
        private System.Windows.Forms.Button highestPopulationButton;
        private System.Windows.Forms.Button lowestPopulationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteRowButton;
    }
}


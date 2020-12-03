namespace MOD2_CP3
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
            this.soldGroupBox = new System.Windows.Forms.GroupBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.classCLabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classALabel = new System.Windows.Forms.Label();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.classCRevenueLabel = new System.Windows.Forms.Label();
            this.classBRevenueLabel = new System.Windows.Forms.Label();
            this.classARevenueLabel = new System.Windows.Forms.Label();
            this.revenueCLabel = new System.Windows.Forms.Label();
            this.revenueBLabel = new System.Windows.Forms.Label();
            this.revenueALabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.soldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // soldGroupBox
            // 
            this.soldGroupBox.Controls.Add(this.classCTextBox);
            this.soldGroupBox.Controls.Add(this.classBTextBox);
            this.soldGroupBox.Controls.Add(this.classATextBox);
            this.soldGroupBox.Controls.Add(this.classCLabel);
            this.soldGroupBox.Controls.Add(this.classBLabel);
            this.soldGroupBox.Controls.Add(this.classALabel);
            this.soldGroupBox.Location = new System.Drawing.Point(42, 29);
            this.soldGroupBox.Name = "soldGroupBox";
            this.soldGroupBox.Size = new System.Drawing.Size(200, 167);
            this.soldGroupBox.TabIndex = 0;
            this.soldGroupBox.TabStop = false;
            this.soldGroupBox.Text = "Tickets Sold";
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(88, 100);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(100, 20);
            this.classCTextBox.TabIndex = 5;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(88, 59);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(100, 20);
            this.classBTextBox.TabIndex = 4;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(88, 20);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(100, 20);
            this.classATextBox.TabIndex = 3;
            this.classATextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // classCLabel
            // 
            this.classCLabel.AutoSize = true;
            this.classCLabel.Location = new System.Drawing.Point(7, 100);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(45, 13);
            this.classCLabel.TabIndex = 2;
            this.classCLabel.Text = "Class C:";
            // 
            // classBLabel
            // 
            this.classBLabel.AutoSize = true;
            this.classBLabel.Location = new System.Drawing.Point(6, 59);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(45, 13);
            this.classBLabel.TabIndex = 1;
            this.classBLabel.Text = "Class B:";
            // 
            // classALabel
            // 
            this.classALabel.AutoSize = true;
            this.classALabel.Location = new System.Drawing.Point(7, 20);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(45, 13);
            this.classALabel.TabIndex = 0;
            this.classALabel.Text = "Class A:";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.totalLabel);
            this.revenueGroupBox.Controls.Add(this.classCRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.classBRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.classARevenueLabel);
            this.revenueGroupBox.Controls.Add(this.revenueCLabel);
            this.revenueGroupBox.Controls.Add(this.revenueBLabel);
            this.revenueGroupBox.Controls.Add(this.revenueALabel);
            this.revenueGroupBox.Location = new System.Drawing.Point(293, 29);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(200, 167);
            this.revenueGroupBox.TabIndex = 1;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // classCRevenueLabel
            // 
            this.classCRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCRevenueLabel.Location = new System.Drawing.Point(94, 100);
            this.classCRevenueLabel.Name = "classCRevenueLabel";
            this.classCRevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.classCRevenueLabel.TabIndex = 5;
            // 
            // classBRevenueLabel
            // 
            this.classBRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBRevenueLabel.Location = new System.Drawing.Point(94, 58);
            this.classBRevenueLabel.Name = "classBRevenueLabel";
            this.classBRevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.classBRevenueLabel.TabIndex = 4;
            // 
            // classARevenueLabel
            // 
            this.classARevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classARevenueLabel.Location = new System.Drawing.Point(94, 20);
            this.classARevenueLabel.Name = "classARevenueLabel";
            this.classARevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.classARevenueLabel.TabIndex = 3;
            // 
            // revenueCLabel
            // 
            this.revenueCLabel.AutoSize = true;
            this.revenueCLabel.Location = new System.Drawing.Point(7, 100);
            this.revenueCLabel.Name = "revenueCLabel";
            this.revenueCLabel.Size = new System.Drawing.Size(45, 13);
            this.revenueCLabel.TabIndex = 2;
            this.revenueCLabel.Text = "Class C:";
            // 
            // revenueBLabel
            // 
            this.revenueBLabel.AutoSize = true;
            this.revenueBLabel.Location = new System.Drawing.Point(6, 59);
            this.revenueBLabel.Name = "revenueBLabel";
            this.revenueBLabel.Size = new System.Drawing.Size(45, 13);
            this.revenueBLabel.TabIndex = 1;
            this.revenueBLabel.Text = "Class B:";
            // 
            // revenueALabel
            // 
            this.revenueALabel.AutoSize = true;
            this.revenueALabel.Location = new System.Drawing.Point(7, 20);
            this.revenueALabel.Name = "revenueALabel";
            this.revenueALabel.Size = new System.Drawing.Size(45, 13);
            this.revenueALabel.TabIndex = 0;
            this.revenueALabel.Text = "Class A:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(111, 212);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 57);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(215, 212);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 57);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(316, 212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 57);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(6, 136);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevenueLabel.Location = new System.Drawing.Point(94, 136);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.totalRevenueLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 290);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.soldGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.soldGroupBox.ResumeLayout(false);
            this.soldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox soldGroupBox;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Label classCRevenueLabel;
        private System.Windows.Forms.Label classBRevenueLabel;
        private System.Windows.Forms.Label classARevenueLabel;
        private System.Windows.Forms.Label revenueCLabel;
        private System.Windows.Forms.Label revenueBLabel;
        private System.Windows.Forms.Label revenueALabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalRevenueLabel;
    }
}


namespace MOD5_CP7_P6
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
            this.boyNameLabel = new System.Windows.Forms.Label();
            this.girlNameLabel = new System.Windows.Forms.Label();
            this.boyFoundLabel = new System.Windows.Forms.Label();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.girlTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.boyOutputLabel = new System.Windows.Forms.Label();
            this.girlFoundLabel = new System.Windows.Forms.Label();
            this.girlOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boyNameLabel
            // 
            this.boyNameLabel.AutoSize = true;
            this.boyNameLabel.Location = new System.Drawing.Point(24, 55);
            this.boyNameLabel.Name = "boyNameLabel";
            this.boyNameLabel.Size = new System.Drawing.Size(59, 13);
            this.boyNameLabel.TabIndex = 0;
            this.boyNameLabel.Text = "Boy Name:";
            // 
            // girlNameLabel
            // 
            this.girlNameLabel.AutoSize = true;
            this.girlNameLabel.Location = new System.Drawing.Point(24, 87);
            this.girlNameLabel.Name = "girlNameLabel";
            this.girlNameLabel.Size = new System.Drawing.Size(56, 13);
            this.girlNameLabel.TabIndex = 1;
            this.girlNameLabel.Text = "Girl Name:";
            // 
            // boyFoundLabel
            // 
            this.boyFoundLabel.AutoSize = true;
            this.boyFoundLabel.Location = new System.Drawing.Point(24, 142);
            this.boyFoundLabel.Name = "boyFoundLabel";
            this.boyFoundLabel.Size = new System.Drawing.Size(92, 13);
            this.boyFoundLabel.TabIndex = 2;
            this.boyFoundLabel.Text = "Boy Name Found:";
            // 
            // boyTextBox
            // 
            this.boyTextBox.Location = new System.Drawing.Point(127, 52);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(100, 20);
            this.boyTextBox.TabIndex = 3;
            // 
            // girlTextBox
            // 
            this.girlTextBox.Location = new System.Drawing.Point(127, 84);
            this.girlTextBox.Name = "girlTextBox";
            this.girlTextBox.Size = new System.Drawing.Size(100, 20);
            this.girlTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(27, 212);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(152, 212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // boyOutputLabel
            // 
            this.boyOutputLabel.AutoSize = true;
            this.boyOutputLabel.Location = new System.Drawing.Point(127, 142);
            this.boyOutputLabel.Name = "boyOutputLabel";
            this.boyOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.boyOutputLabel.TabIndex = 7;
            // 
            // girlFoundLabel
            // 
            this.girlFoundLabel.AutoSize = true;
            this.girlFoundLabel.Location = new System.Drawing.Point(24, 172);
            this.girlFoundLabel.Name = "girlFoundLabel";
            this.girlFoundLabel.Size = new System.Drawing.Size(89, 13);
            this.girlFoundLabel.TabIndex = 8;
            this.girlFoundLabel.Text = "Girl Name Found:";
            // 
            // girlOutputLabel
            // 
            this.girlOutputLabel.AutoSize = true;
            this.girlOutputLabel.Location = new System.Drawing.Point(127, 172);
            this.girlOutputLabel.Name = "girlOutputLabel";
            this.girlOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.girlOutputLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 254);
            this.Controls.Add(this.girlOutputLabel);
            this.Controls.Add(this.girlFoundLabel);
            this.Controls.Add(this.boyOutputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.girlTextBox);
            this.Controls.Add(this.boyTextBox);
            this.Controls.Add(this.boyFoundLabel);
            this.Controls.Add(this.girlNameLabel);
            this.Controls.Add(this.boyNameLabel);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boyNameLabel;
        private System.Windows.Forms.Label girlNameLabel;
        private System.Windows.Forms.Label boyFoundLabel;
        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.TextBox girlTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label boyOutputLabel;
        private System.Windows.Forms.Label girlFoundLabel;
        private System.Windows.Forms.Label girlOutputLabel;
    }
}


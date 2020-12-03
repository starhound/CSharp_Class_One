namespace MOD2_CP4
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
            this.fromBox = new System.Windows.Forms.GroupBox();
            this.toBox = new System.Windows.Forms.GroupBox();
            this.inputDescriptionLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromBox.SuspendLayout();
            this.toBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromBox
            // 
            this.fromBox.Controls.Add(this.fromListBox);
            this.fromBox.Location = new System.Drawing.Point(52, 72);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(134, 95);
            this.fromBox.TabIndex = 0;
            this.fromBox.TabStop = false;
            this.fromBox.Text = "From";
            // 
            // toBox
            // 
            this.toBox.Controls.Add(this.toListBox);
            this.toBox.Location = new System.Drawing.Point(192, 72);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(135, 95);
            this.toBox.TabIndex = 1;
            this.toBox.TabStop = false;
            this.toBox.Text = "To";
            // 
            // inputDescriptionLabel
            // 
            this.inputDescriptionLabel.AutoSize = true;
            this.inputDescriptionLabel.Location = new System.Drawing.Point(49, 24);
            this.inputDescriptionLabel.Name = "inputDescriptionLabel";
            this.inputDescriptionLabel.Size = new System.Drawing.Size(138, 13);
            this.inputDescriptionLabel.TabIndex = 2;
            this.inputDescriptionLabel.Text = "Enter a distance to convert:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(192, 24);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 3;
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(7, 20);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(120, 56);
            this.fromListBox.TabIndex = 0;
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "Inches ",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(7, 20);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(120, 56);
            this.toListBox.TabIndex = 0;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(49, 183);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(104, 13);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Converted Distance:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outputLabel.Location = new System.Drawing.Point(189, 183);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(52, 227);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Convert";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 270);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputDescriptionLabel);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.fromBox.ResumeLayout(false);
            this.toBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fromBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.GroupBox toBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label inputDescriptionLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}


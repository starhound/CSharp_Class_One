namespace MOD4_CP6_P7
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
            this.futureLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.futureTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.presentValueOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // futureLabel
            // 
            this.futureLabel.AutoSize = true;
            this.futureLabel.Location = new System.Drawing.Point(13, 33);
            this.futureLabel.Name = "futureLabel";
            this.futureLabel.Size = new System.Drawing.Size(118, 13);
            this.futureLabel.TabIndex = 0;
            this.futureLabel.Text = "Future Amount Desired:";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(13, 63);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(107, 13);
            this.interestLabel.TabIndex = 1;
            this.interestLabel.Text = "Annual Interest Rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(13, 96);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(104, 13);
            this.yearsLabel.TabIndex = 2;
            this.yearsLabel.Text = "Years of Investment:";
            // 
            // futureTextBox
            // 
            this.futureTextBox.Location = new System.Drawing.Point(138, 33);
            this.futureTextBox.Name = "futureTextBox";
            this.futureTextBox.Size = new System.Drawing.Size(100, 20);
            this.futureTextBox.TabIndex = 3;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(138, 63);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestTextBox.TabIndex = 4;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(138, 96);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 127);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(97, 127);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(131, 184);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 10;
            // 
            // presentValueOutputLabel
            // 
            this.presentValueOutputLabel.AutoSize = true;
            this.presentValueOutputLabel.Location = new System.Drawing.Point(13, 184);
            this.presentValueOutputLabel.Name = "presentValueOutputLabel";
            this.presentValueOutputLabel.Size = new System.Drawing.Size(76, 13);
            this.presentValueOutputLabel.TabIndex = 11;
            this.presentValueOutputLabel.Text = "Present Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 216);
            this.Controls.Add(this.presentValueOutputLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.futureTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.futureLabel);
            this.Name = "Form1";
            this.Text = "Present Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox futureTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label presentValueOutputLabel;
    }
}


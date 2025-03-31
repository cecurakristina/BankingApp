namespace BankingApp
{
    partial class DisplayAccountForm
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
            this.accountIdLabel = new System.Windows.Forms.Label();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountIdLabel
            // 
            this.accountIdLabel.AutoSize = true;
            this.accountIdLabel.Location = new System.Drawing.Point(16, 68);
            this.accountIdLabel.Name = "accountIdLabel";
            this.accountIdLabel.Size = new System.Drawing.Size(393, 20);
            this.accountIdLabel.TabIndex = 0;
            this.accountIdLabel.Text = "Please enter the ID of the account you want to display:";
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(423, 63);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.accountIdTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(244, 142);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 38);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 212);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.accountIdLabel);
            this.Name = "DisplayAccountForm";
            this.Text = "Display Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}
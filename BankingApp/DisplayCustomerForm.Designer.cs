namespace BankingApp
{
    partial class DisplayCustomerForm
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
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(16, 68);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(402, 20);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "Please enter the ID of the customer you want to display:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(440, 65);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.customerIdTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(256, 141);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 41);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DisplayCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 206);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.customerIdLabel);
            this.Name = "DisplayCustomerForm";
            this.Text = "Display Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}
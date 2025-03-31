namespace BankingApp
{
    partial class DisplayTransactionForm
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
            this.transactionIdLabel = new System.Windows.Forms.Label();
            this.transactionIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionIdLabel
            // 
            this.transactionIdLabel.AutoSize = true;
            this.transactionIdLabel.Location = new System.Drawing.Point(18, 68);
            this.transactionIdLabel.Name = "transactionIdLabel";
            this.transactionIdLabel.Size = new System.Drawing.Size(415, 20);
            this.transactionIdLabel.TabIndex = 0;
            this.transactionIdLabel.Text = "Please enter the ID of the transaction you want to display:";
            // 
            // transactionIdTextBox
            // 
            this.transactionIdTextBox.Location = new System.Drawing.Point(459, 64);
            this.transactionIdTextBox.Name = "transactionIdTextBox";
            this.transactionIdTextBox.Size = new System.Drawing.Size(98, 26);
            this.transactionIdTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(260, 136);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 39);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DisplayTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 205);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.transactionIdTextBox);
            this.Controls.Add(this.transactionIdLabel);
            this.Name = "DisplayTransactionForm";
            this.Text = "Display Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionIdLabel;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}
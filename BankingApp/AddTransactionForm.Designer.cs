namespace BankingApp
{
    partial class AddTransactionForm
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
            this.transactionidLabel = new System.Windows.Forms.Label();
            this.transactionAmountLabel = new System.Windows.Forms.Label();
            this.transactionDateLabel = new System.Windows.Forms.Label();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.transactionIdTextBox = new System.Windows.Forms.TextBox();
            this.transactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.transactionDateTextBox = new System.Windows.Forms.TextBox();
            this.transactiontypeTextBox = new System.Windows.Forms.TextBox();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.accountidLabel = new System.Windows.Forms.Label();
            this.atmIdLabel = new System.Windows.Forms.Label();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.atmIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // transactionidLabel
            // 
            this.transactionidLabel.AutoSize = true;
            this.transactionidLabel.Location = new System.Drawing.Point(44, 58);
            this.transactionidLabel.Name = "transactionidLabel";
            this.transactionidLabel.Size = new System.Drawing.Size(117, 20);
            this.transactionidLabel.TabIndex = 0;
            this.transactionidLabel.Text = "Transaction ID:";
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.AutoSize = true;
            this.transactionAmountLabel.Location = new System.Drawing.Point(44, 158);
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            this.transactionAmountLabel.Size = new System.Drawing.Size(156, 20);
            this.transactionAmountLabel.TabIndex = 1;
            this.transactionAmountLabel.Text = "Transaction Amount:";
            // 
            // transactionDateLabel
            // 
            this.transactionDateLabel.AutoSize = true;
            this.transactionDateLabel.Location = new System.Drawing.Point(45, 255);
            this.transactionDateLabel.Name = "transactionDateLabel";
            this.transactionDateLabel.Size = new System.Drawing.Size(135, 20);
            this.transactionDateLabel.TabIndex = 2;
            this.transactionDateLabel.Text = "Transaction Date:";
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(481, 54);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(134, 20);
            this.transactionTypeLabel.TabIndex = 3;
            this.transactionTypeLabel.Text = "Transaction Type:";
            // 
            // transactionIdTextBox
            // 
            this.transactionIdTextBox.Location = new System.Drawing.Point(261, 52);
            this.transactionIdTextBox.Name = "transactionIdTextBox";
            this.transactionIdTextBox.Size = new System.Drawing.Size(130, 26);
            this.transactionIdTextBox.TabIndex = 4;
            // 
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.Location = new System.Drawing.Point(261, 151);
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.Size = new System.Drawing.Size(130, 26);
            this.transactionAmountTextBox.TabIndex = 5;
            // 
            // transactionDateTextBox
            // 
            this.transactionDateTextBox.Location = new System.Drawing.Point(261, 246);
            this.transactionDateTextBox.Name = "transactionDateTextBox";
            this.transactionDateTextBox.Size = new System.Drawing.Size(130, 26);
            this.transactionDateTextBox.TabIndex = 6;
            // 
            // transactiontypeTextBox
            // 
            this.transactiontypeTextBox.Location = new System.Drawing.Point(643, 50);
            this.transactiontypeTextBox.Name = "transactiontypeTextBox";
            this.transactiontypeTextBox.Size = new System.Drawing.Size(111, 26);
            this.transactiontypeTextBox.TabIndex = 7;
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(48, 375);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(142, 35);
            this.addTransactionButton.TabIndex = 8;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(261, 374);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 35);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // accountidLabel
            // 
            this.accountidLabel.AutoSize = true;
            this.accountidLabel.Location = new System.Drawing.Point(490, 153);
            this.accountidLabel.Name = "accountidLabel";
            this.accountidLabel.Size = new System.Drawing.Size(93, 20);
            this.accountidLabel.TabIndex = 10;
            this.accountidLabel.Text = "Account ID:";
            // 
            // atmIdLabel
            // 
            this.atmIdLabel.AutoSize = true;
            this.atmIdLabel.Location = new System.Drawing.Point(497, 254);
            this.atmIdLabel.Name = "atmIdLabel";
            this.atmIdLabel.Size = new System.Drawing.Size(67, 20);
            this.atmIdLabel.TabIndex = 11;
            this.atmIdLabel.Text = "ATM ID:";
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(643, 148);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(111, 26);
            this.accountIdTextBox.TabIndex = 12;
            // 
            // atmIdTextBox
            // 
            this.atmIdTextBox.Location = new System.Drawing.Point(643, 246);
            this.atmIdTextBox.Name = "atmIdTextBox";
            this.atmIdTextBox.Size = new System.Drawing.Size(111, 26);
            this.atmIdTextBox.TabIndex = 13;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atmIdTextBox);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.atmIdLabel);
            this.Controls.Add(this.accountidLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.transactiontypeTextBox);
            this.Controls.Add(this.transactionDateTextBox);
            this.Controls.Add(this.transactionAmountTextBox);
            this.Controls.Add(this.transactionIdTextBox);
            this.Controls.Add(this.transactionTypeLabel);
            this.Controls.Add(this.transactionDateLabel);
            this.Controls.Add(this.transactionAmountLabel);
            this.Controls.Add(this.transactionidLabel);
            this.Name = "AddTransactionForm";
            this.Text = "Add Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionidLabel;
        private System.Windows.Forms.Label transactionAmountLabel;
        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.TextBox transactionAmountTextBox;
        private System.Windows.Forms.TextBox transactionDateTextBox;
        private System.Windows.Forms.TextBox transactiontypeTextBox;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label accountidLabel;
        private System.Windows.Forms.Label atmIdLabel;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.TextBox atmIdTextBox;
    }
}
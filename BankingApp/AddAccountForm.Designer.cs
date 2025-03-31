namespace BankingApp
{
    partial class AddAccountForm
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
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeTextBox = new System.Windows.Forms.TextBox();
            this.accountbalanceTextBox = new System.Windows.Forms.TextBox();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountIdLabel
            // 
            this.accountIdLabel.AutoSize = true;
            this.accountIdLabel.Location = new System.Drawing.Point(58, 80);
            this.accountIdLabel.Name = "accountIdLabel";
            this.accountIdLabel.Size = new System.Drawing.Size(140, 30);
            this.accountIdLabel.TabIndex = 0;
            this.accountIdLabel.Text = "Account ID:";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(58, 167);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(110, 20);
            this.accountTypeLabel.TabIndex = 1;
            this.accountTypeLabel.Text = "Account Type:";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.Location = new System.Drawing.Point(57, 257);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(189, 30);
            this.accountBalanceLabel.TabIndex = 2;
            this.accountBalanceLabel.Text = "Acount Balance:";
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(223, 75);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(137, 26);
            this.accountIdTextBox.TabIndex = 3;
            // 
            // accountTypeTextBox
            // 
            this.accountTypeTextBox.Location = new System.Drawing.Point(223, 163);
            this.accountTypeTextBox.Name = "accountTypeTextBox";
            this.accountTypeTextBox.Size = new System.Drawing.Size(137, 26);
            this.accountTypeTextBox.TabIndex = 4;
            // 
            // accountbalanceTextBox
            // 
            this.accountbalanceTextBox.Location = new System.Drawing.Point(223, 249);
            this.accountbalanceTextBox.Name = "accountbalanceTextBox";
            this.accountbalanceTextBox.Size = new System.Drawing.Size(137, 26);
            this.accountbalanceTextBox.TabIndex = 5;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(62, 344);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(121, 31);
            this.addAccountButton.TabIndex = 6;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(223, 344);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 31);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.accountbalanceTextBox);
            this.Controls.Add(this.accountTypeTextBox);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.accountBalanceLabel);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.accountIdLabel);
            this.Name = "AddAccountForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.TextBox accountTypeTextBox;
        private System.Windows.Forms.TextBox accountbalanceTextBox;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
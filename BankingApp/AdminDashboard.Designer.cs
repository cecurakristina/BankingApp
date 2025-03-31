namespace BankingApp
{
    partial class AdminDashboard
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.displayCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.displayAccountButton = new System.Windows.Forms.Button();
            this.updateAccountButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.displayTransactionsButton = new System.Windows.Forms.Button();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.updateTransactionButton = new System.Windows.Forms.Button();
            this.deleteTransactionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(36, 43);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(342, 20);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Hello, {name}! What would you like to do today?";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(30, 143);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(165, 60);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // displayCustomerButton
            // 
            this.displayCustomerButton.Location = new System.Drawing.Point(30, 210);
            this.displayCustomerButton.Name = "displayCustomerButton";
            this.displayCustomerButton.Size = new System.Drawing.Size(165, 60);
            this.displayCustomerButton.TabIndex = 2;
            this.displayCustomerButton.Text = "Display Customer";
            this.displayCustomerButton.UseVisualStyleBackColor = true;
            this.displayCustomerButton.Click += new System.EventHandler(this.displayCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(30, 279);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(165, 60);
            this.updateCustomerButton.TabIndex = 3;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(30, 345);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(165, 60);
            this.deleteCustomerButton.TabIndex = 4;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(304, 143);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(165, 60);
            this.addAccountButton.TabIndex = 5;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // displayAccountButton
            // 
            this.displayAccountButton.Location = new System.Drawing.Point(304, 210);
            this.displayAccountButton.Name = "displayAccountButton";
            this.displayAccountButton.Size = new System.Drawing.Size(165, 60);
            this.displayAccountButton.TabIndex = 6;
            this.displayAccountButton.Text = "Display Account";
            this.displayAccountButton.UseVisualStyleBackColor = true;
            this.displayAccountButton.Click += new System.EventHandler(this.displayAccountButton_Click);
            // 
            // updateAccountButton
            // 
            this.updateAccountButton.Location = new System.Drawing.Point(304, 279);
            this.updateAccountButton.Name = "updateAccountButton";
            this.updateAccountButton.Size = new System.Drawing.Size(165, 60);
            this.updateAccountButton.TabIndex = 7;
            this.updateAccountButton.Text = "Update Balance";
            this.updateAccountButton.UseVisualStyleBackColor = true;
            this.updateAccountButton.Click += new System.EventHandler(this.updateAccountButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(304, 345);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(165, 60);
            this.deleteAccountButton.TabIndex = 8;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // displayTransactionsButton
            // 
            this.displayTransactionsButton.Location = new System.Drawing.Point(579, 210);
            this.displayTransactionsButton.Name = "displayTransactionsButton";
            this.displayTransactionsButton.Size = new System.Drawing.Size(165, 60);
            this.displayTransactionsButton.TabIndex = 9;
            this.displayTransactionsButton.Text = "Display Transaction";
            this.displayTransactionsButton.UseVisualStyleBackColor = true;
            this.displayTransactionsButton.Click += new System.EventHandler(this.displayTransactionsButton_Click);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(579, 143);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(165, 60);
            this.addTransactionButton.TabIndex = 10;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // updateTransactionButton
            // 
            this.updateTransactionButton.Location = new System.Drawing.Point(579, 279);
            this.updateTransactionButton.Name = "updateTransactionButton";
            this.updateTransactionButton.Size = new System.Drawing.Size(165, 60);
            this.updateTransactionButton.TabIndex = 11;
            this.updateTransactionButton.Text = "Update Transaction";
            this.updateTransactionButton.UseVisualStyleBackColor = true;
            this.updateTransactionButton.Click += new System.EventHandler(this.updateTransactionButton_Click);
            // 
            // deleteTransactionButton
            // 
            this.deleteTransactionButton.Location = new System.Drawing.Point(579, 345);
            this.deleteTransactionButton.Name = "deleteTransactionButton";
            this.deleteTransactionButton.Size = new System.Drawing.Size(165, 60);
            this.deleteTransactionButton.TabIndex = 12;
            this.deleteTransactionButton.Text = "Delete Transaction";
            this.deleteTransactionButton.UseVisualStyleBackColor = true;
            this.deleteTransactionButton.Click += new System.EventHandler(this.deleteTransactionButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 544);
            this.Controls.Add(this.deleteTransactionButton);
            this.Controls.Add(this.updateTransactionButton);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.displayTransactionsButton);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.updateAccountButton);
            this.Controls.Add(this.displayAccountButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.displayCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.greetingLabel);
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button displayCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button displayAccountButton;
        private System.Windows.Forms.Button updateAccountButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button displayTransactionsButton;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Button updateTransactionButton;
        private System.Windows.Forms.Button deleteTransactionButton;
    }
}
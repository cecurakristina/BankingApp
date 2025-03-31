namespace BankingApp
{
    partial class UpdateTransactionForm
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
            this.valueNameLabel = new System.Windows.Forms.Label();
            this.newValueLabel = new System.Windows.Forms.Label();
            this.transactionidTextBox = new System.Windows.Forms.TextBox();
            this.valueNameTextBox = new System.Windows.Forms.TextBox();
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionIdLabel
            // 
            this.transactionIdLabel.AutoSize = true;
            this.transactionIdLabel.Location = new System.Drawing.Point(64, 82);
            this.transactionIdLabel.Name = "transactionIdLabel";
            this.transactionIdLabel.Size = new System.Drawing.Size(117, 20);
            this.transactionIdLabel.TabIndex = 0;
            this.transactionIdLabel.Text = "Transaction ID:";
            // 
            // valueNameLabel
            // 
            this.valueNameLabel.AutoSize = true;
            this.valueNameLabel.Location = new System.Drawing.Point(65, 176);
            this.valueNameLabel.Name = "valueNameLabel";
            this.valueNameLabel.Size = new System.Drawing.Size(157, 20);
            this.valueNameLabel.TabIndex = 1;
            this.valueNameLabel.Text = "Value to be updated:";
            // 
            // newValueLabel
            // 
            this.newValueLabel.AutoSize = true;
            this.newValueLabel.Location = new System.Drawing.Point(67, 268);
            this.newValueLabel.Name = "newValueLabel";
            this.newValueLabel.Size = new System.Drawing.Size(85, 20);
            this.newValueLabel.TabIndex = 2;
            this.newValueLabel.Text = "New value:";
            // 
            // transactionidTextBox
            // 
            this.transactionidTextBox.Location = new System.Drawing.Point(283, 77);
            this.transactionidTextBox.Name = "transactionidTextBox";
            this.transactionidTextBox.Size = new System.Drawing.Size(131, 26);
            this.transactionidTextBox.TabIndex = 3;
            // 
            // valueNameTextBox
            // 
            this.valueNameTextBox.Location = new System.Drawing.Point(283, 169);
            this.valueNameTextBox.Name = "valueNameTextBox";
            this.valueNameTextBox.Size = new System.Drawing.Size(131, 26);
            this.valueNameTextBox.TabIndex = 4;
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Location = new System.Drawing.Point(283, 261);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(131, 26);
            this.newValueTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(68, 362);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(113, 32);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(283, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 32);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newValueTextBox);
            this.Controls.Add(this.valueNameTextBox);
            this.Controls.Add(this.transactionidTextBox);
            this.Controls.Add(this.newValueLabel);
            this.Controls.Add(this.valueNameLabel);
            this.Controls.Add(this.transactionIdLabel);
            this.Name = "UpdateTransactionForm";
            this.Text = "Update Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionIdLabel;
        private System.Windows.Forms.Label valueNameLabel;
        private System.Windows.Forms.Label newValueLabel;
        private System.Windows.Forms.TextBox transactionidTextBox;
        private System.Windows.Forms.TextBox valueNameTextBox;
        private System.Windows.Forms.TextBox newValueTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
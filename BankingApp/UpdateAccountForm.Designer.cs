namespace BankingApp
{
    partial class UpdateBalanceForm
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
            this.newBalanceLabel = new System.Windows.Forms.Label();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.newBalanceTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountIdLabel
            // 
            this.accountIdLabel.AutoSize = true;
            this.accountIdLabel.Location = new System.Drawing.Point(65, 83);
            this.accountIdLabel.Name = "accountIdLabel";
            this.accountIdLabel.Size = new System.Drawing.Size(93, 20);
            this.accountIdLabel.TabIndex = 0;
            this.accountIdLabel.Text = "Account ID:";
            // 
            // newBalanceLabel
            // 
            this.newBalanceLabel.AutoSize = true;
            this.newBalanceLabel.Location = new System.Drawing.Point(66, 166);
            this.newBalanceLabel.Name = "newBalanceLabel";
            this.newBalanceLabel.Size = new System.Drawing.Size(159, 30);
            this.newBalanceLabel.TabIndex = 1;
            this.newBalanceLabel.Text = "New Balance:";
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(276, 78);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(131, 26);
            this.accountIdTextBox.TabIndex = 3;
            // 
            // newBalanceTextBox
            // 
            this.newBalanceTextBox.Location = new System.Drawing.Point(276, 163);
            this.newBalanceTextBox.Name = "newBalanceTextBox";
            this.newBalanceTextBox.Size = new System.Drawing.Size(131, 26);
            this.newBalanceTextBox.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(69, 252);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 35);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(276, 252);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newBalanceTextBox);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.newBalanceLabel);
            this.Controls.Add(this.accountIdLabel);
            this.Name = "UpdateBalanceForm";
            this.Text = "Update Account Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.Label newBalanceLabel;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.TextBox newBalanceTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
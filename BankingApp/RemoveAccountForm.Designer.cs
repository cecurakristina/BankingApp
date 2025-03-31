namespace BankingApp
{
    partial class RemoveAccountForm
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
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountIdLabel
            // 
            this.accountIdLabel.AutoSize = true;
            this.accountIdLabel.Location = new System.Drawing.Point(76, 111);
            this.accountIdLabel.Name = "accountIdLabel";
            this.accountIdLabel.Size = new System.Drawing.Size(93, 20);
            this.accountIdLabel.TabIndex = 0;
            this.accountIdLabel.Text = "Account ID:";
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(218, 103);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(144, 26);
            this.accountIdTextBox.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(80, 203);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(101, 33);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(233, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 33);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RemoveAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.accountIdLabel);
            this.Name = "RemoveAccountForm";
            this.Text = "Remove Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
namespace BankingApp
{
    partial class RemoveTransactionForm
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
            this.transactionidTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionidLabel
            // 
            this.transactionidLabel.AutoSize = true;
            this.transactionidLabel.Location = new System.Drawing.Point(74, 116);
            this.transactionidLabel.Name = "transactionidLabel";
            this.transactionidLabel.Size = new System.Drawing.Size(117, 20);
            this.transactionidLabel.TabIndex = 0;
            this.transactionidLabel.Text = "Transaction ID:";
            // 
            // transactionidTextBox
            // 
            this.transactionidTextBox.Location = new System.Drawing.Point(253, 110);
            this.transactionidTextBox.Name = "transactionidTextBox";
            this.transactionidTextBox.Size = new System.Drawing.Size(136, 26);
            this.transactionidTextBox.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(71, 206);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 34);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(253, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RemoveTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.transactionidTextBox);
            this.Controls.Add(this.transactionidLabel);
            this.Name = "RemoveTransactionForm";
            this.Text = "Remove Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionidLabel;
        private System.Windows.Forms.TextBox transactionidTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
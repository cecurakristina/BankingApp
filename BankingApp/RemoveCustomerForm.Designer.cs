namespace BankingApp
{
    partial class RemoveCustomerForm
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
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(69, 110);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(155, 30);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "Customer ID:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(216, 106);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(143, 26);
            this.customerIdTextBox.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(73, 204);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(117, 36);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(257, 204);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 36);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RemoveCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.customerIdLabel);
            this.Name = "RemoveCustomerForm";
            this.Text = "Remove Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
namespace BankingApp
{
    partial class UpdateCustomerForm
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
            this.valueNameLabel = new System.Windows.Forms.Label();
            this.newValueLabel = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.valueNameTextBox = new System.Windows.Forms.TextBox();
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(56, 80);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(103, 20);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "Customer ID:";
            // 
            // valueNameLabel
            // 
            this.valueNameLabel.AutoSize = true;
            this.valueNameLabel.Location = new System.Drawing.Point(57, 152);
            this.valueNameLabel.Name = "valueNameLabel";
            this.valueNameLabel.Size = new System.Drawing.Size(161, 20);
            this.valueNameLabel.TabIndex = 1;
            this.valueNameLabel.Text = "Value to be updated: ";
            // 
            // newValueLabel
            // 
            this.newValueLabel.AutoSize = true;
            this.newValueLabel.Location = new System.Drawing.Point(58, 224);
            this.newValueLabel.Name = "newValueLabel";
            this.newValueLabel.Size = new System.Drawing.Size(85, 20);
            this.newValueLabel.TabIndex = 2;
            this.newValueLabel.Text = "New value:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(282, 77);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(124, 26);
            this.customerIdTextBox.TabIndex = 3;
            // 
            // valueNameTextBox
            // 
            this.valueNameTextBox.Location = new System.Drawing.Point(282, 149);
            this.valueNameTextBox.Name = "valueNameTextBox";
            this.valueNameTextBox.Size = new System.Drawing.Size(124, 26);
            this.valueNameTextBox.TabIndex = 4;
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Location = new System.Drawing.Point(282, 223);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(124, 26);
            this.newValueTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(60, 308);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(118, 34);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(282, 308);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 34);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newValueTextBox);
            this.Controls.Add(this.valueNameTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.newValueLabel);
            this.Controls.Add(this.valueNameLabel);
            this.Controls.Add(this.customerIdLabel);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label valueNameLabel;
        private System.Windows.Forms.Label newValueLabel;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox valueNameTextBox;
        private System.Windows.Forms.TextBox newValueTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
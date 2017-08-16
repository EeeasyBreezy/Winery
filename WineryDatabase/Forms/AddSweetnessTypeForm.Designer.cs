namespace WineryDatabase.Forms
{
    partial class AddSweetnessTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SweetnessTextBox = new System.Windows.Forms.TextBox();
            this.AddSweetnessTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип сладости";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(116, 13);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(83, 20);
            this.IdTextBox.TabIndex = 2;
            // 
            // SweetnessTextBox
            // 
            this.SweetnessTextBox.Location = new System.Drawing.Point(116, 39);
            this.SweetnessTextBox.Name = "SweetnessTextBox";
            this.SweetnessTextBox.Size = new System.Drawing.Size(83, 20);
            this.SweetnessTextBox.TabIndex = 3;
            // 
            // AddSweetnessTypeButton
            // 
            this.AddSweetnessTypeButton.Location = new System.Drawing.Point(54, 65);
            this.AddSweetnessTypeButton.Name = "AddSweetnessTypeButton";
            this.AddSweetnessTypeButton.Size = new System.Drawing.Size(108, 32);
            this.AddSweetnessTypeButton.TabIndex = 4;
            this.AddSweetnessTypeButton.Text = "Добавить";
            this.AddSweetnessTypeButton.UseVisualStyleBackColor = true;
            this.AddSweetnessTypeButton.Click += new System.EventHandler(this.AddSweetnessTypeButton_Click);
            // 
            // AddSweetnessTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 102);
            this.Controls.Add(this.AddSweetnessTypeButton);
            this.Controls.Add(this.SweetnessTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddSweetnessTypeForm";
            this.Text = "AddSweetnessTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox SweetnessTextBox;
        private System.Windows.Forms.Button AddSweetnessTypeButton;
    }
}
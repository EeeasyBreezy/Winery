namespace WineryDatabase.Forms
{
    partial class AddWineSortForm
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
            this.WineSortTextBox = new System.Windows.Forms.TextBox();
            this.AddWineSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортовость вина";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(112, 6);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 2;
            // 
            // WineSortTextBox
            // 
            this.WineSortTextBox.Location = new System.Drawing.Point(112, 32);
            this.WineSortTextBox.Name = "WineSortTextBox";
            this.WineSortTextBox.Size = new System.Drawing.Size(100, 20);
            this.WineSortTextBox.TabIndex = 3;
            // 
            // AddWineSortButton
            // 
            this.AddWineSortButton.Location = new System.Drawing.Point(67, 58);
            this.AddWineSortButton.Name = "AddWineSortButton";
            this.AddWineSortButton.Size = new System.Drawing.Size(100, 32);
            this.AddWineSortButton.TabIndex = 4;
            this.AddWineSortButton.Text = "Добавить";
            this.AddWineSortButton.UseVisualStyleBackColor = true;
            this.AddWineSortButton.Click += new System.EventHandler(this.AddWineSortButton_Click);
            // 
            // AddWineSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 102);
            this.Controls.Add(this.AddWineSortButton);
            this.Controls.Add(this.WineSortTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "AddWineSortForm";
            this.Text = "AddWineSortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox WineSortTextBox;
        private System.Windows.Forms.Button AddWineSortButton;
    }
}
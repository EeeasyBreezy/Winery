namespace WineryDatabase.Forms
{
    partial class AddSeedlessnessTypeForm
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
            this.SeedlessnessTextBox = new System.Windows.Forms.TextBox();
            this.AddSeedlessnessTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип бессемянности";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(128, 12);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(88, 20);
            this.IdTextBox.TabIndex = 2;
            // 
            // SeedlessnessTextBox
            // 
            this.SeedlessnessTextBox.Location = new System.Drawing.Point(128, 38);
            this.SeedlessnessTextBox.Name = "SeedlessnessTextBox";
            this.SeedlessnessTextBox.Size = new System.Drawing.Size(88, 20);
            this.SeedlessnessTextBox.TabIndex = 3;
            // 
            // AddSeedlessnessTypeButton
            // 
            this.AddSeedlessnessTypeButton.Location = new System.Drawing.Point(84, 64);
            this.AddSeedlessnessTypeButton.Name = "AddSeedlessnessTypeButton";
            this.AddSeedlessnessTypeButton.Size = new System.Drawing.Size(93, 33);
            this.AddSeedlessnessTypeButton.TabIndex = 4;
            this.AddSeedlessnessTypeButton.Text = "Добавить";
            this.AddSeedlessnessTypeButton.UseVisualStyleBackColor = true;
            this.AddSeedlessnessTypeButton.Click += new System.EventHandler(this.AddSeedlessnessTypeButton_Click);
            // 
            // AddSeedlessnessTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 102);
            this.Controls.Add(this.AddSeedlessnessTypeButton);
            this.Controls.Add(this.SeedlessnessTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddSeedlessnessTypeForm";
            this.Text = "AddSeedlessnessTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox SeedlessnessTextBox;
        private System.Windows.Forms.Button AddSeedlessnessTypeButton;
    }
}
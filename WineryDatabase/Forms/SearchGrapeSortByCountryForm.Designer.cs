namespace WineryDatabase.Forms
{
    partial class SearchGrapeSortByCountryForm
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
            this.CountriesComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByCountryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по стране";
            // 
            // CountriesComboBox
            // 
            this.CountriesComboBox.FormattingEnabled = true;
            this.CountriesComboBox.Location = new System.Drawing.Point(123, 6);
            this.CountriesComboBox.Name = "CountriesComboBox";
            this.CountriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.CountriesComboBox.TabIndex = 1;
            // 
            // SearchByCountryButton
            // 
            this.SearchByCountryButton.Location = new System.Drawing.Point(71, 33);
            this.SearchByCountryButton.Name = "SearchByCountryButton";
            this.SearchByCountryButton.Size = new System.Drawing.Size(111, 33);
            this.SearchByCountryButton.TabIndex = 2;
            this.SearchByCountryButton.Text = "Искать";
            this.SearchByCountryButton.UseVisualStyleBackColor = true;
            this.SearchByCountryButton.Click += new System.EventHandler(this.SearchByCountryButton_Click);
            // 
            // SearchGrapeSortByCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 72);
            this.Controls.Add(this.SearchByCountryButton);
            this.Controls.Add(this.CountriesComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchGrapeSortByCountryForm";
            this.Text = "SearchGrapeSortByCountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CountriesComboBox;
        private System.Windows.Forms.Button SearchByCountryButton;
    }
}
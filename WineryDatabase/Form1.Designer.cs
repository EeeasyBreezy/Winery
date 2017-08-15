namespace WineryDatabase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WineTabs = new System.Windows.Forms.TabControl();
            this.WineTab = new System.Windows.Forms.TabPage();
            this.SearchWineButton = new System.Windows.Forms.Button();
            this.DeleteWineButton = new System.Windows.Forms.Button();
            this.EditWineButton = new System.Windows.Forms.Button();
            this.AddWineButton = new System.Windows.Forms.Button();
            this.WineTable = new System.Windows.Forms.DataGridView();
            this.GrapeSorts = new System.Windows.Forms.TabPage();
            this.SearchSortButton = new System.Windows.Forms.Button();
            this.RemoveSortButton = new System.Windows.Forms.Button();
            this.EditSortButton = new System.Windows.Forms.Button();
            this.AddSortButton = new System.Windows.Forms.Button();
            this.SortTable = new System.Windows.Forms.DataGridView();
            this.SweetnessTypes = new System.Windows.Forms.TabPage();
            this.AddSweetnessTypeButton = new System.Windows.Forms.Button();
            this.DeletSweetnessTypeButton = new System.Windows.Forms.Button();
            this.SweetnessTable = new System.Windows.Forms.DataGridView();
            this.SeedlessnessTypes = new System.Windows.Forms.TabPage();
            this.OriginCountry = new System.Windows.Forms.TabPage();
            this.WineSortTypes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SeedlessnessTable = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CountryTable = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.WineSortTable = new System.Windows.Forms.DataGridView();
            this.WineTabs.SuspendLayout();
            this.WineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WineTable)).BeginInit();
            this.GrapeSorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SortTable)).BeginInit();
            this.SweetnessTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SweetnessTable)).BeginInit();
            this.SeedlessnessTypes.SuspendLayout();
            this.OriginCountry.SuspendLayout();
            this.WineSortTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeedlessnessTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WineSortTable)).BeginInit();
            this.SuspendLayout();
            // 
            // WineTabs
            // 
            this.WineTabs.Controls.Add(this.WineTab);
            this.WineTabs.Controls.Add(this.GrapeSorts);
            this.WineTabs.Controls.Add(this.SweetnessTypes);
            this.WineTabs.Controls.Add(this.SeedlessnessTypes);
            this.WineTabs.Controls.Add(this.OriginCountry);
            this.WineTabs.Controls.Add(this.WineSortTypes);
            this.WineTabs.Location = new System.Drawing.Point(6, 20);
            this.WineTabs.Name = "WineTabs";
            this.WineTabs.SelectedIndex = 0;
            this.WineTabs.Size = new System.Drawing.Size(777, 387);
            this.WineTabs.TabIndex = 0;
            // 
            // WineTab
            // 
            this.WineTab.Controls.Add(this.SearchWineButton);
            this.WineTab.Controls.Add(this.DeleteWineButton);
            this.WineTab.Controls.Add(this.EditWineButton);
            this.WineTab.Controls.Add(this.AddWineButton);
            this.WineTab.Controls.Add(this.WineTable);
            this.WineTab.Location = new System.Drawing.Point(4, 22);
            this.WineTab.Name = "WineTab";
            this.WineTab.Padding = new System.Windows.Forms.Padding(3);
            this.WineTab.Size = new System.Drawing.Size(769, 361);
            this.WineTab.TabIndex = 0;
            this.WineTab.Text = "Вино";
            this.WineTab.UseVisualStyleBackColor = true;
            // 
            // SearchWineButton
            // 
            this.SearchWineButton.Location = new System.Drawing.Point(309, 3);
            this.SearchWineButton.Name = "SearchWineButton";
            this.SearchWineButton.Size = new System.Drawing.Size(97, 36);
            this.SearchWineButton.TabIndex = 4;
            this.SearchWineButton.Text = "Поиск вина";
            this.SearchWineButton.UseVisualStyleBackColor = true;
            // 
            // DeleteWineButton
            // 
            this.DeleteWineButton.Location = new System.Drawing.Point(206, 3);
            this.DeleteWineButton.Name = "DeleteWineButton";
            this.DeleteWineButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteWineButton.TabIndex = 3;
            this.DeleteWineButton.Text = "Удалить";
            this.DeleteWineButton.UseVisualStyleBackColor = true;
            // 
            // EditWineButton
            // 
            this.EditWineButton.Location = new System.Drawing.Point(103, 3);
            this.EditWineButton.Name = "EditWineButton";
            this.EditWineButton.Size = new System.Drawing.Size(97, 36);
            this.EditWineButton.TabIndex = 2;
            this.EditWineButton.Text = "Редактировать";
            this.EditWineButton.UseVisualStyleBackColor = true;
            // 
            // AddWineButton
            // 
            this.AddWineButton.Location = new System.Drawing.Point(0, 3);
            this.AddWineButton.Name = "AddWineButton";
            this.AddWineButton.Size = new System.Drawing.Size(97, 36);
            this.AddWineButton.TabIndex = 1;
            this.AddWineButton.Text = "Добавить";
            this.AddWineButton.UseVisualStyleBackColor = true;
            // 
            // WineTable
            // 
            this.WineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WineTable.Location = new System.Drawing.Point(0, 94);
            this.WineTable.Name = "WineTable";
            this.WineTable.Size = new System.Drawing.Size(772, 270);
            this.WineTable.TabIndex = 0;
            // 
            // GrapeSorts
            // 
            this.GrapeSorts.Controls.Add(this.SearchSortButton);
            this.GrapeSorts.Controls.Add(this.RemoveSortButton);
            this.GrapeSorts.Controls.Add(this.EditSortButton);
            this.GrapeSorts.Controls.Add(this.AddSortButton);
            this.GrapeSorts.Controls.Add(this.SortTable);
            this.GrapeSorts.Location = new System.Drawing.Point(4, 22);
            this.GrapeSorts.Name = "GrapeSorts";
            this.GrapeSorts.Padding = new System.Windows.Forms.Padding(3);
            this.GrapeSorts.Size = new System.Drawing.Size(769, 361);
            this.GrapeSorts.TabIndex = 1;
            this.GrapeSorts.Text = "Сорта винограда";
            this.GrapeSorts.UseVisualStyleBackColor = true;
            // 
            // SearchSortButton
            // 
            this.SearchSortButton.Location = new System.Drawing.Point(309, 3);
            this.SearchSortButton.Name = "SearchSortButton";
            this.SearchSortButton.Size = new System.Drawing.Size(97, 36);
            this.SearchSortButton.TabIndex = 5;
            this.SearchSortButton.Text = "Поиск сорта";
            this.SearchSortButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSortButton
            // 
            this.RemoveSortButton.Location = new System.Drawing.Point(206, 3);
            this.RemoveSortButton.Name = "RemoveSortButton";
            this.RemoveSortButton.Size = new System.Drawing.Size(97, 36);
            this.RemoveSortButton.TabIndex = 4;
            this.RemoveSortButton.Text = "Удалить";
            this.RemoveSortButton.UseVisualStyleBackColor = true;
            // 
            // EditSortButton
            // 
            this.EditSortButton.Location = new System.Drawing.Point(103, 3);
            this.EditSortButton.Name = "EditSortButton";
            this.EditSortButton.Size = new System.Drawing.Size(97, 36);
            this.EditSortButton.TabIndex = 3;
            this.EditSortButton.Text = "Редактировать";
            this.EditSortButton.UseVisualStyleBackColor = true;
            // 
            // AddSortButton
            // 
            this.AddSortButton.Location = new System.Drawing.Point(0, 3);
            this.AddSortButton.Name = "AddSortButton";
            this.AddSortButton.Size = new System.Drawing.Size(97, 36);
            this.AddSortButton.TabIndex = 2;
            this.AddSortButton.Text = "Добавить";
            this.AddSortButton.UseVisualStyleBackColor = true;
            // 
            // SortTable
            // 
            this.SortTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortTable.Location = new System.Drawing.Point(0, 95);
            this.SortTable.Name = "SortTable";
            this.SortTable.Size = new System.Drawing.Size(772, 270);
            this.SortTable.TabIndex = 1;
            // 
            // SweetnessTypes
            // 
            this.SweetnessTypes.Controls.Add(this.AddSweetnessTypeButton);
            this.SweetnessTypes.Controls.Add(this.DeletSweetnessTypeButton);
            this.SweetnessTypes.Controls.Add(this.SweetnessTable);
            this.SweetnessTypes.Location = new System.Drawing.Point(4, 22);
            this.SweetnessTypes.Name = "SweetnessTypes";
            this.SweetnessTypes.Size = new System.Drawing.Size(769, 361);
            this.SweetnessTypes.TabIndex = 2;
            this.SweetnessTypes.Text = "Типы сладости";
            this.SweetnessTypes.UseVisualStyleBackColor = true;
            // 
            // AddSweetnessTypeButton
            // 
            this.AddSweetnessTypeButton.Location = new System.Drawing.Point(0, 3);
            this.AddSweetnessTypeButton.Name = "AddSweetnessTypeButton";
            this.AddSweetnessTypeButton.Size = new System.Drawing.Size(97, 36);
            this.AddSweetnessTypeButton.TabIndex = 4;
            this.AddSweetnessTypeButton.Text = "Добавить";
            this.AddSweetnessTypeButton.UseVisualStyleBackColor = true;
            // 
            // DeletSweetnessTypeButton
            // 
            this.DeletSweetnessTypeButton.Location = new System.Drawing.Point(103, 3);
            this.DeletSweetnessTypeButton.Name = "DeletSweetnessTypeButton";
            this.DeletSweetnessTypeButton.Size = new System.Drawing.Size(97, 36);
            this.DeletSweetnessTypeButton.TabIndex = 3;
            this.DeletSweetnessTypeButton.Text = "Удалить";
            this.DeletSweetnessTypeButton.UseVisualStyleBackColor = true;
            // 
            // SweetnessTable
            // 
            this.SweetnessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SweetnessTable.Location = new System.Drawing.Point(1, 91);
            this.SweetnessTable.Name = "SweetnessTable";
            this.SweetnessTable.Size = new System.Drawing.Size(772, 270);
            this.SweetnessTable.TabIndex = 2;
            // 
            // SeedlessnessTypes
            // 
            this.SeedlessnessTypes.Controls.Add(this.button1);
            this.SeedlessnessTypes.Controls.Add(this.button2);
            this.SeedlessnessTypes.Controls.Add(this.SeedlessnessTable);
            this.SeedlessnessTypes.Location = new System.Drawing.Point(4, 22);
            this.SeedlessnessTypes.Name = "SeedlessnessTypes";
            this.SeedlessnessTypes.Size = new System.Drawing.Size(769, 361);
            this.SeedlessnessTypes.TabIndex = 3;
            this.SeedlessnessTypes.Text = "Типы семянистости";
            this.SeedlessnessTypes.UseVisualStyleBackColor = true;
            // 
            // OriginCountry
            // 
            this.OriginCountry.Controls.Add(this.button3);
            this.OriginCountry.Controls.Add(this.button4);
            this.OriginCountry.Controls.Add(this.CountryTable);
            this.OriginCountry.Location = new System.Drawing.Point(4, 22);
            this.OriginCountry.Name = "OriginCountry";
            this.OriginCountry.Size = new System.Drawing.Size(769, 361);
            this.OriginCountry.TabIndex = 4;
            this.OriginCountry.Text = "Страна происхождения сорта";
            this.OriginCountry.UseVisualStyleBackColor = true;
            // 
            // WineSortTypes
            // 
            this.WineSortTypes.Controls.Add(this.button5);
            this.WineSortTypes.Controls.Add(this.button6);
            this.WineSortTypes.Controls.Add(this.WineSortTable);
            this.WineSortTypes.Location = new System.Drawing.Point(4, 22);
            this.WineSortTypes.Name = "WineSortTypes";
            this.WineSortTypes.Size = new System.Drawing.Size(769, 361);
            this.WineSortTypes.TabIndex = 5;
            this.WineSortTypes.Text = "Сортовость вина";
            this.WineSortTypes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SeedlessnessTable
            // 
            this.SeedlessnessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeedlessnessTable.Location = new System.Drawing.Point(0, 91);
            this.SeedlessnessTable.Name = "SeedlessnessTable";
            this.SeedlessnessTable.Size = new System.Drawing.Size(772, 270);
            this.SeedlessnessTable.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 36);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CountryTable
            // 
            this.CountryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryTable.Location = new System.Drawing.Point(-3, 91);
            this.CountryTable.Name = "CountryTable";
            this.CountryTable.Size = new System.Drawing.Size(772, 270);
            this.CountryTable.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // WineSortTable
            // 
            this.WineSortTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WineSortTable.Location = new System.Drawing.Point(0, 91);
            this.WineSortTable.Name = "WineSortTable";
            this.WineSortTable.Size = new System.Drawing.Size(772, 270);
            this.WineSortTable.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.WineTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Винодельня";
            this.WineTabs.ResumeLayout(false);
            this.WineTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WineTable)).EndInit();
            this.GrapeSorts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SortTable)).EndInit();
            this.SweetnessTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SweetnessTable)).EndInit();
            this.SeedlessnessTypes.ResumeLayout(false);
            this.OriginCountry.ResumeLayout(false);
            this.WineSortTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeedlessnessTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WineSortTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl WineTabs;
        private System.Windows.Forms.TabPage WineTab;
        private System.Windows.Forms.TabPage GrapeSorts;
        private System.Windows.Forms.Button SearchWineButton;
        private System.Windows.Forms.Button DeleteWineButton;
        private System.Windows.Forms.Button EditWineButton;
        private System.Windows.Forms.Button AddWineButton;
        private System.Windows.Forms.DataGridView WineTable;
        private System.Windows.Forms.TabPage SweetnessTypes;
        private System.Windows.Forms.TabPage SeedlessnessTypes;
        private System.Windows.Forms.TabPage OriginCountry;
        private System.Windows.Forms.TabPage WineSortTypes;
        private System.Windows.Forms.DataGridView SortTable;
        private System.Windows.Forms.Button AddSortButton;
        private System.Windows.Forms.Button SearchSortButton;
        private System.Windows.Forms.Button RemoveSortButton;
        private System.Windows.Forms.Button EditSortButton;
        private System.Windows.Forms.DataGridView SweetnessTable;
        private System.Windows.Forms.Button AddSweetnessTypeButton;
        private System.Windows.Forms.Button DeletSweetnessTypeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView SeedlessnessTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView CountryTable;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView WineSortTable;
    }
}


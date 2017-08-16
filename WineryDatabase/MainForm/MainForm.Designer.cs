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
            this.FilterWineButton = new System.Windows.Forms.Button();
            this.DeleteWineButton = new System.Windows.Forms.Button();
            this.EditWineButton = new System.Windows.Forms.Button();
            this.AddWineButton = new System.Windows.Forms.Button();
            this.WineTable = new System.Windows.Forms.DataGridView();
            this.GrapeSorts = new System.Windows.Forms.TabPage();
            this.SearchSortButton = new System.Windows.Forms.Button();
            this.RemoveSortButton = new System.Windows.Forms.Button();
            this.EditSortButton = new System.Windows.Forms.Button();
            this.AddSortButton = new System.Windows.Forms.Button();
            this.GrapeSortTable = new System.Windows.Forms.DataGridView();
            this.SweetnessTypes = new System.Windows.Forms.TabPage();
            this.AddSweetnessTypeButton = new System.Windows.Forms.Button();
            this.DeletSweetnessTypeButton = new System.Windows.Forms.Button();
            this.SweetnessTable = new System.Windows.Forms.DataGridView();
            this.SeedlessnessTypes = new System.Windows.Forms.TabPage();
            this.AddSeedlessnessTypeButton = new System.Windows.Forms.Button();
            this.DleteSeedlessnessButton = new System.Windows.Forms.Button();
            this.SeedlessnessTable = new System.Windows.Forms.DataGridView();
            this.OriginCountry = new System.Windows.Forms.TabPage();
            this.AddCountryButton = new System.Windows.Forms.Button();
            this.DeleteCountryButton = new System.Windows.Forms.Button();
            this.CountryTable = new System.Windows.Forms.DataGridView();
            this.WineSortTypes = new System.Windows.Forms.TabPage();
            this.AddWineSortButton = new System.Windows.Forms.Button();
            this.DeleteWineSortButton = new System.Windows.Forms.Button();
            this.WineSortTable = new System.Windows.Forms.DataGridView();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.SearchGrapeSortsSugarAvgAverage = new System.Windows.Forms.Button();
            this.SearchWinesOverAvgPrice = new System.Windows.Forms.Button();
            this.SearchTable = new System.Windows.Forms.DataGridView();
            this.SearchGrapeSortsByCountryButton = new System.Windows.Forms.Button();
            this.WineTabs.SuspendLayout();
            this.WineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WineTable)).BeginInit();
            this.GrapeSorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrapeSortTable)).BeginInit();
            this.SweetnessTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SweetnessTable)).BeginInit();
            this.SeedlessnessTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeedlessnessTable)).BeginInit();
            this.OriginCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTable)).BeginInit();
            this.WineSortTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WineSortTable)).BeginInit();
            this.SearchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTable)).BeginInit();
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
            this.WineTabs.Controls.Add(this.SearchPage);
            this.WineTabs.Location = new System.Drawing.Point(6, 20);
            this.WineTabs.Name = "WineTabs";
            this.WineTabs.SelectedIndex = 0;
            this.WineTabs.Size = new System.Drawing.Size(777, 387);
            this.WineTabs.TabIndex = 0;
            // 
            // WineTab
            // 
            this.WineTab.Controls.Add(this.FilterWineButton);
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
            // FilterWineButton
            // 
            this.FilterWineButton.Location = new System.Drawing.Point(103, 45);
            this.FilterWineButton.Name = "FilterWineButton";
            this.FilterWineButton.Size = new System.Drawing.Size(97, 36);
            this.FilterWineButton.TabIndex = 4;
            this.FilterWineButton.Text = "Отфильтровать содержимое";
            this.FilterWineButton.UseVisualStyleBackColor = true;
            this.FilterWineButton.Click += new System.EventHandler(this.FilterWineButton_Click);
            // 
            // DeleteWineButton
            // 
            this.DeleteWineButton.Location = new System.Drawing.Point(0, 45);
            this.DeleteWineButton.Name = "DeleteWineButton";
            this.DeleteWineButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteWineButton.TabIndex = 3;
            this.DeleteWineButton.Text = "Удалить";
            this.DeleteWineButton.UseVisualStyleBackColor = true;
            this.DeleteWineButton.Click += new System.EventHandler(this.DeleteWineButton_Click);
            // 
            // EditWineButton
            // 
            this.EditWineButton.Location = new System.Drawing.Point(103, 3);
            this.EditWineButton.Name = "EditWineButton";
            this.EditWineButton.Size = new System.Drawing.Size(97, 36);
            this.EditWineButton.TabIndex = 2;
            this.EditWineButton.Text = "Редактировать";
            this.EditWineButton.UseVisualStyleBackColor = true;
            this.EditWineButton.Click += new System.EventHandler(this.EditWineButton_Click);
            // 
            // AddWineButton
            // 
            this.AddWineButton.Location = new System.Drawing.Point(0, 3);
            this.AddWineButton.Name = "AddWineButton";
            this.AddWineButton.Size = new System.Drawing.Size(97, 36);
            this.AddWineButton.TabIndex = 1;
            this.AddWineButton.Text = "Добавить";
            this.AddWineButton.UseVisualStyleBackColor = true;
            this.AddWineButton.Click += new System.EventHandler(this.AddWineButton_Click);
            // 
            // WineTable
            // 
            this.WineTable.AllowUserToAddRows = false;
            this.WineTable.AllowUserToDeleteRows = false;
            this.WineTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.WineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WineTable.Location = new System.Drawing.Point(0, 94);
            this.WineTable.Name = "WineTable";
            this.WineTable.ReadOnly = true;
            this.WineTable.Size = new System.Drawing.Size(772, 270);
            this.WineTable.TabIndex = 0;
            // 
            // GrapeSorts
            // 
            this.GrapeSorts.Controls.Add(this.SearchSortButton);
            this.GrapeSorts.Controls.Add(this.RemoveSortButton);
            this.GrapeSorts.Controls.Add(this.EditSortButton);
            this.GrapeSorts.Controls.Add(this.AddSortButton);
            this.GrapeSorts.Controls.Add(this.GrapeSortTable);
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
            this.SearchSortButton.Location = new System.Drawing.Point(103, 45);
            this.SearchSortButton.Name = "SearchSortButton";
            this.SearchSortButton.Size = new System.Drawing.Size(97, 36);
            this.SearchSortButton.TabIndex = 5;
            this.SearchSortButton.Text = "Поиск сорта";
            this.SearchSortButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSortButton
            // 
            this.RemoveSortButton.Location = new System.Drawing.Point(0, 45);
            this.RemoveSortButton.Name = "RemoveSortButton";
            this.RemoveSortButton.Size = new System.Drawing.Size(97, 36);
            this.RemoveSortButton.TabIndex = 4;
            this.RemoveSortButton.Text = "Удалить";
            this.RemoveSortButton.UseVisualStyleBackColor = true;
            this.RemoveSortButton.Click += new System.EventHandler(this.RemoveSortButton_Click);
            // 
            // EditSortButton
            // 
            this.EditSortButton.Location = new System.Drawing.Point(103, 3);
            this.EditSortButton.Name = "EditSortButton";
            this.EditSortButton.Size = new System.Drawing.Size(97, 36);
            this.EditSortButton.TabIndex = 3;
            this.EditSortButton.Text = "Редактировать";
            this.EditSortButton.UseVisualStyleBackColor = true;
            this.EditSortButton.Click += new System.EventHandler(this.EditSortButton_Click);
            // 
            // AddSortButton
            // 
            this.AddSortButton.Location = new System.Drawing.Point(0, 3);
            this.AddSortButton.Name = "AddSortButton";
            this.AddSortButton.Size = new System.Drawing.Size(97, 36);
            this.AddSortButton.TabIndex = 2;
            this.AddSortButton.Text = "Добавить";
            this.AddSortButton.UseVisualStyleBackColor = true;
            this.AddSortButton.Click += new System.EventHandler(this.AddSortButton_Click);
            // 
            // GrapeSortTable
            // 
            this.GrapeSortTable.AllowUserToAddRows = false;
            this.GrapeSortTable.AllowUserToDeleteRows = false;
            this.GrapeSortTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrapeSortTable.Location = new System.Drawing.Point(0, 95);
            this.GrapeSortTable.Name = "GrapeSortTable";
            this.GrapeSortTable.ReadOnly = true;
            this.GrapeSortTable.Size = new System.Drawing.Size(772, 270);
            this.GrapeSortTable.TabIndex = 1;
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
            this.AddSweetnessTypeButton.Click += new System.EventHandler(this.AddSweetnessTypeButton_Click);
            // 
            // DeletSweetnessTypeButton
            // 
            this.DeletSweetnessTypeButton.Location = new System.Drawing.Point(103, 3);
            this.DeletSweetnessTypeButton.Name = "DeletSweetnessTypeButton";
            this.DeletSweetnessTypeButton.Size = new System.Drawing.Size(97, 36);
            this.DeletSweetnessTypeButton.TabIndex = 3;
            this.DeletSweetnessTypeButton.Text = "Удалить";
            this.DeletSweetnessTypeButton.UseVisualStyleBackColor = true;
            this.DeletSweetnessTypeButton.Click += new System.EventHandler(this.DeletSweetnessTypeButton_Click);
            // 
            // SweetnessTable
            // 
            this.SweetnessTable.AllowUserToAddRows = false;
            this.SweetnessTable.AllowUserToDeleteRows = false;
            this.SweetnessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SweetnessTable.Location = new System.Drawing.Point(1, 91);
            this.SweetnessTable.Name = "SweetnessTable";
            this.SweetnessTable.ReadOnly = true;
            this.SweetnessTable.Size = new System.Drawing.Size(772, 270);
            this.SweetnessTable.TabIndex = 2;
            // 
            // SeedlessnessTypes
            // 
            this.SeedlessnessTypes.Controls.Add(this.AddSeedlessnessTypeButton);
            this.SeedlessnessTypes.Controls.Add(this.DleteSeedlessnessButton);
            this.SeedlessnessTypes.Controls.Add(this.SeedlessnessTable);
            this.SeedlessnessTypes.Location = new System.Drawing.Point(4, 22);
            this.SeedlessnessTypes.Name = "SeedlessnessTypes";
            this.SeedlessnessTypes.Size = new System.Drawing.Size(769, 361);
            this.SeedlessnessTypes.TabIndex = 3;
            this.SeedlessnessTypes.Text = "Типы семянистости";
            this.SeedlessnessTypes.UseVisualStyleBackColor = true;
            // 
            // AddSeedlessnessTypeButton
            // 
            this.AddSeedlessnessTypeButton.Location = new System.Drawing.Point(0, 3);
            this.AddSeedlessnessTypeButton.Name = "AddSeedlessnessTypeButton";
            this.AddSeedlessnessTypeButton.Size = new System.Drawing.Size(97, 36);
            this.AddSeedlessnessTypeButton.TabIndex = 7;
            this.AddSeedlessnessTypeButton.Text = "Добавить";
            this.AddSeedlessnessTypeButton.UseVisualStyleBackColor = true;
            this.AddSeedlessnessTypeButton.Click += new System.EventHandler(this.AddSeedlessnessTypeButton_Click);
            // 
            // DleteSeedlessnessButton
            // 
            this.DleteSeedlessnessButton.Location = new System.Drawing.Point(103, 3);
            this.DleteSeedlessnessButton.Name = "DleteSeedlessnessButton";
            this.DleteSeedlessnessButton.Size = new System.Drawing.Size(97, 36);
            this.DleteSeedlessnessButton.TabIndex = 6;
            this.DleteSeedlessnessButton.Text = "Удалить";
            this.DleteSeedlessnessButton.UseVisualStyleBackColor = true;
            this.DleteSeedlessnessButton.Click += new System.EventHandler(this.DleteSeedlessnessButton_Click);
            // 
            // SeedlessnessTable
            // 
            this.SeedlessnessTable.AllowUserToAddRows = false;
            this.SeedlessnessTable.AllowUserToDeleteRows = false;
            this.SeedlessnessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeedlessnessTable.Location = new System.Drawing.Point(0, 91);
            this.SeedlessnessTable.Name = "SeedlessnessTable";
            this.SeedlessnessTable.ReadOnly = true;
            this.SeedlessnessTable.Size = new System.Drawing.Size(772, 270);
            this.SeedlessnessTable.TabIndex = 5;
            // 
            // OriginCountry
            // 
            this.OriginCountry.Controls.Add(this.AddCountryButton);
            this.OriginCountry.Controls.Add(this.DeleteCountryButton);
            this.OriginCountry.Controls.Add(this.CountryTable);
            this.OriginCountry.Location = new System.Drawing.Point(4, 22);
            this.OriginCountry.Name = "OriginCountry";
            this.OriginCountry.Size = new System.Drawing.Size(769, 361);
            this.OriginCountry.TabIndex = 4;
            this.OriginCountry.Text = "Страна происхождения сорта";
            this.OriginCountry.UseVisualStyleBackColor = true;
            // 
            // AddCountryButton
            // 
            this.AddCountryButton.Location = new System.Drawing.Point(0, 3);
            this.AddCountryButton.Name = "AddCountryButton";
            this.AddCountryButton.Size = new System.Drawing.Size(97, 36);
            this.AddCountryButton.TabIndex = 7;
            this.AddCountryButton.Text = "Добавить";
            this.AddCountryButton.UseVisualStyleBackColor = true;
            this.AddCountryButton.Click += new System.EventHandler(this.AddCountryButton_Click);
            // 
            // DeleteCountryButton
            // 
            this.DeleteCountryButton.Location = new System.Drawing.Point(103, 3);
            this.DeleteCountryButton.Name = "DeleteCountryButton";
            this.DeleteCountryButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteCountryButton.TabIndex = 6;
            this.DeleteCountryButton.Text = "Удалить";
            this.DeleteCountryButton.UseVisualStyleBackColor = true;
            this.DeleteCountryButton.Click += new System.EventHandler(this.DeleteCountryButton_Click);
            // 
            // CountryTable
            // 
            this.CountryTable.AllowUserToAddRows = false;
            this.CountryTable.AllowUserToDeleteRows = false;
            this.CountryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryTable.Location = new System.Drawing.Point(-3, 91);
            this.CountryTable.Name = "CountryTable";
            this.CountryTable.ReadOnly = true;
            this.CountryTable.Size = new System.Drawing.Size(772, 270);
            this.CountryTable.TabIndex = 5;
            // 
            // WineSortTypes
            // 
            this.WineSortTypes.Controls.Add(this.AddWineSortButton);
            this.WineSortTypes.Controls.Add(this.DeleteWineSortButton);
            this.WineSortTypes.Controls.Add(this.WineSortTable);
            this.WineSortTypes.Location = new System.Drawing.Point(4, 22);
            this.WineSortTypes.Name = "WineSortTypes";
            this.WineSortTypes.Size = new System.Drawing.Size(769, 361);
            this.WineSortTypes.TabIndex = 5;
            this.WineSortTypes.Text = "Сортовость вина";
            this.WineSortTypes.UseVisualStyleBackColor = true;
            // 
            // AddWineSortButton
            // 
            this.AddWineSortButton.Location = new System.Drawing.Point(0, 3);
            this.AddWineSortButton.Name = "AddWineSortButton";
            this.AddWineSortButton.Size = new System.Drawing.Size(97, 36);
            this.AddWineSortButton.TabIndex = 7;
            this.AddWineSortButton.Text = "Добавить";
            this.AddWineSortButton.UseVisualStyleBackColor = true;
            this.AddWineSortButton.Click += new System.EventHandler(this.AddWineSortButton_Click);
            // 
            // DeleteWineSortButton
            // 
            this.DeleteWineSortButton.Location = new System.Drawing.Point(103, 3);
            this.DeleteWineSortButton.Name = "DeleteWineSortButton";
            this.DeleteWineSortButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteWineSortButton.TabIndex = 6;
            this.DeleteWineSortButton.Text = "Удалить";
            this.DeleteWineSortButton.UseVisualStyleBackColor = true;
            this.DeleteWineSortButton.Click += new System.EventHandler(this.DeleteWineSortButton_Click);
            // 
            // WineSortTable
            // 
            this.WineSortTable.AllowUserToAddRows = false;
            this.WineSortTable.AllowUserToDeleteRows = false;
            this.WineSortTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WineSortTable.Location = new System.Drawing.Point(0, 91);
            this.WineSortTable.Name = "WineSortTable";
            this.WineSortTable.ReadOnly = true;
            this.WineSortTable.Size = new System.Drawing.Size(772, 270);
            this.WineSortTable.TabIndex = 5;
            // 
            // SearchPage
            // 
            this.SearchPage.Controls.Add(this.SearchGrapeSortsByCountryButton);
            this.SearchPage.Controls.Add(this.SearchGrapeSortsSugarAvgAverage);
            this.SearchPage.Controls.Add(this.SearchWinesOverAvgPrice);
            this.SearchPage.Controls.Add(this.SearchTable);
            this.SearchPage.Location = new System.Drawing.Point(4, 22);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Size = new System.Drawing.Size(769, 361);
            this.SearchPage.TabIndex = 6;
            this.SearchPage.Text = "Поиск по БД";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // SearchGrapeSortsSugarAvgAverage
            // 
            this.SearchGrapeSortsSugarAvgAverage.Location = new System.Drawing.Point(3, 45);
            this.SearchGrapeSortsSugarAvgAverage.Name = "SearchGrapeSortsSugarAvgAverage";
            this.SearchGrapeSortsSugarAvgAverage.Size = new System.Drawing.Size(280, 40);
            this.SearchGrapeSortsSugarAvgAverage.TabIndex = 3;
            this.SearchGrapeSortsSugarAvgAverage.Text = "Сорта винограда с сахаристостью выше среднего";
            this.SearchGrapeSortsSugarAvgAverage.UseVisualStyleBackColor = true;
            this.SearchGrapeSortsSugarAvgAverage.Click += new System.EventHandler(this.SearchGrapeSortsSugarAvgAverage_Click);
            // 
            // SearchWinesOverAvgPrice
            // 
            this.SearchWinesOverAvgPrice.Location = new System.Drawing.Point(3, 3);
            this.SearchWinesOverAvgPrice.Name = "SearchWinesOverAvgPrice";
            this.SearchWinesOverAvgPrice.Size = new System.Drawing.Size(137, 40);
            this.SearchWinesOverAvgPrice.TabIndex = 2;
            this.SearchWinesOverAvgPrice.Text = "Вина с ценой выше среднего";
            this.SearchWinesOverAvgPrice.UseVisualStyleBackColor = true;
            this.SearchWinesOverAvgPrice.Click += new System.EventHandler(this.SearchWinesOverAvgPrice_Click);
            // 
            // SearchTable
            // 
            this.SearchTable.AllowUserToAddRows = false;
            this.SearchTable.AllowUserToDeleteRows = false;
            this.SearchTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SearchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchTable.Location = new System.Drawing.Point(-3, 91);
            this.SearchTable.Name = "SearchTable";
            this.SearchTable.ReadOnly = true;
            this.SearchTable.Size = new System.Drawing.Size(772, 270);
            this.SearchTable.TabIndex = 1;
            // 
            // SearchGrapeSortsByCountryButton
            // 
            this.SearchGrapeSortsByCountryButton.Location = new System.Drawing.Point(146, 3);
            this.SearchGrapeSortsByCountryButton.Name = "SearchGrapeSortsByCountryButton";
            this.SearchGrapeSortsByCountryButton.Size = new System.Drawing.Size(137, 40);
            this.SearchGrapeSortsByCountryButton.TabIndex = 4;
            this.SearchGrapeSortsByCountryButton.Text = "Поиск сортов по странам";
            this.SearchGrapeSortsByCountryButton.UseVisualStyleBackColor = true;
            this.SearchGrapeSortsByCountryButton.Click += new System.EventHandler(this.SearchGrapeSortsByCountryButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.GrapeSortTable)).EndInit();
            this.SweetnessTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SweetnessTable)).EndInit();
            this.SeedlessnessTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeedlessnessTable)).EndInit();
            this.OriginCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountryTable)).EndInit();
            this.WineSortTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WineSortTable)).EndInit();
            this.SearchPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl WineTabs;
        private System.Windows.Forms.TabPage WineTab;
        private System.Windows.Forms.TabPage GrapeSorts;
        private System.Windows.Forms.Button FilterWineButton;
        private System.Windows.Forms.Button DeleteWineButton;
        private System.Windows.Forms.Button EditWineButton;
        private System.Windows.Forms.Button AddWineButton;
        public System.Windows.Forms.DataGridView WineTable;
        private System.Windows.Forms.TabPage SweetnessTypes;
        private System.Windows.Forms.TabPage SeedlessnessTypes;
        private System.Windows.Forms.TabPage OriginCountry;
        private System.Windows.Forms.TabPage WineSortTypes;
        private System.Windows.Forms.DataGridView GrapeSortTable;
        private System.Windows.Forms.Button AddSortButton;
        private System.Windows.Forms.Button SearchSortButton;
        private System.Windows.Forms.Button RemoveSortButton;
        private System.Windows.Forms.Button EditSortButton;
        private System.Windows.Forms.DataGridView SweetnessTable;
        private System.Windows.Forms.Button AddSweetnessTypeButton;
        private System.Windows.Forms.Button DeletSweetnessTypeButton;
        private System.Windows.Forms.Button AddSeedlessnessTypeButton;
        private System.Windows.Forms.Button DleteSeedlessnessButton;
        private System.Windows.Forms.DataGridView SeedlessnessTable;
        private System.Windows.Forms.Button AddCountryButton;
        private System.Windows.Forms.Button DeleteCountryButton;
        private System.Windows.Forms.DataGridView CountryTable;
        private System.Windows.Forms.Button AddWineSortButton;
        private System.Windows.Forms.Button DeleteWineSortButton;
        private System.Windows.Forms.DataGridView WineSortTable;
        private System.Windows.Forms.TabPage SearchPage;
        public System.Windows.Forms.DataGridView SearchTable;
        private System.Windows.Forms.Button SearchGrapeSortsSugarAvgAverage;
        private System.Windows.Forms.Button SearchWinesOverAvgPrice;
        private System.Windows.Forms.Button SearchGrapeSortsByCountryButton;
    }
}


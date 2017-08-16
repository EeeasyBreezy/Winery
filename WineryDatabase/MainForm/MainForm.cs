using System.Windows.Forms;
using WineryDatabase.Forms;
using Winery.Instanses;
using System;
using System.Linq;

namespace WineryDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitSqlManagers();
            LoadAllData();
        }

        private void AddWineButton_Click(object sender, System.EventArgs e)
        {
            AddWineForm form = new AddWineForm();
            form.ShowDialog();
        }

        private void AddSortButton_Click(object sender, System.EventArgs e)
        {
            AddGrapeSortForm form = new AddGrapeSortForm();
            form.ShowDialog();
        }

        private void AddSweetnessTypeButton_Click(object sender, System.EventArgs e)
        {
            AddSweetnessTypeForm form = new AddSweetnessTypeForm();
            form.ShowDialog();
        }

        private void AddSeedlessnessTypeButton_Click(object sender, System.EventArgs e)
        {
            AddSeedlessnessTypeForm form = new AddSeedlessnessTypeForm();
            form.ShowDialog();
        }

        private void AddCountryButton_Click(object sender, System.EventArgs e)
        {
            AddCountryForm form = new AddCountryForm();
            form.ShowDialog();
        }

        private void AddWineSortButton_Click(object sender, System.EventArgs e)
        {
            AddWineSortForm form = new AddWineSortForm();
            form.ShowDialog();
        }

        private void DeleteWineButton_Click(object sender, System.EventArgs e)
        {
            var selectedRows = WineTable.SelectedRows;
            foreach(DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                WineManager.DeleteData(id);
                //WineTable.Rows.Remove(row);
                Wine local = WineList.Find(x => x.Id == id);
                WineList.Remove(local);
            }
            UpdateWineTable();
        }

        private void RemoveSortButton_Click(object sender, EventArgs e)
        {
            var selectedRows = GrapeSortTable.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                SortManager.DeleteData(id);
                GrapeSort local = GrapeSortList.Find(x => x.Id == id);
                GrapeSortList.Remove(local);
            }
            UpdateGrapeSortTable();
        }

        private void DeletSweetnessTypeButton_Click(object sender, EventArgs e)
        {
            var selectedRows = SweetnessTable.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                SweetnessManager.DeleteData(id);
                SweetnessDegree local = SweetnessList.Find(x => x.Id == id);
                SweetnessList.Remove(local);
            }
            UpdateSweetnessTypeTable();
        }

        private void DleteSeedlessnessButton_Click(object sender, EventArgs e)
        {
            var selectedRows = SeedlessnessTable.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                SeedlessnessManager.DeleteData(id);
                SeedlessnessType local = SeedlessnessList.Find(x => x.Id == id);
                SeedlessnessList.Remove(local);
            }
            UpdateSeednesslessTable();
        }

        private void DeleteCountryButton_Click(object sender, EventArgs e)
        {
            var selectedRows = CountryTable.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                CountryManager.DeleteData(id);
                OriginCountry local = CountryList.Find(x => x.Id == id);
                CountryList.Remove(local);
            }
            UpdateOriginCountryTable();
        }

        private void DeleteWineSortButton_Click(object sender, EventArgs e)
        {
            var selectedRows = WineSortTable.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                WineSortManager.DeleteData(id);
                WineSortCategory local = SortCategoryList.Find(x => x.Id == id);
                SortCategoryList.Remove(local);
            }
            UpdateWineSortTable();
        }

        private void EditWineButton_Click(object sender, EventArgs e)
        {
            if (WineTable.SelectedRows.Count > 0)
            {
                EditWineForm form = new EditWineForm();
                form.WineForEditing = (from w in WineList
                                       where w.Id == Convert.ToInt32(WineTable.SelectedRows[0].Cells[0].Value)
                                       select w).ToList()[0];
                form.IdTextBox.Text = form.WineForEditing.Id.ToString();
                form.NameTextBox.Text = form.WineForEditing.Name;
                form.NameEngTextBox.Text = form.WineForEditing.NameEng;
                form.AlcoholTextBox.Text = form.WineForEditing.Alcohol.ToString();
                form.YearTextBox.Text = form.WineForEditing.Year.ToString();
                form.PriceTextBox.Text = form.WineForEditing.Price.ToString();
                form.GrapeSortTextBox.Text = form.WineForEditing.GrapeSort.ToString();
                form.SweetnessTextBox.Text = form.WineForEditing.Sweetness.ToString();
                form.SulfurDioxideTextBox.Text = form.WineForEditing.SulfurDioxide.ToString();
                form.WineSortTextBox.Text = form.WineForEditing.SortCategory.ToString();
                form.ShowDialog();
            }
            else
                MessageBox.Show("Ни одной строки не выбрано", "Ошибка!", MessageBoxButtons.OK);
        }
    }
}

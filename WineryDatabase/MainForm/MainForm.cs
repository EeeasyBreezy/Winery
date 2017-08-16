using System.Windows.Forms;
using WineryDatabase.Forms;
using Winery.Instanses;
using System;

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
    }
}

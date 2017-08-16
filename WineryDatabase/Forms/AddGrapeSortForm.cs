using System;
using System.Windows.Forms;
using Winery.Instanses;

namespace WineryDatabase
{
    public partial class AddGrapeSortForm : Form
    {
        public AddGrapeSortForm()
        {
            InitializeComponent();
        }

        private void AddGrapeSortButton_Click(object sender, EventArgs e)
        {
            try
            {
                GrapeSort local = new GrapeSort();
                local.Id = Convert.ToInt32(IdTextBox.Text);
                local.Acidity = Convert.ToDouble(AcidityTextBox.Text);
                local.AverageBerrySize = Convert.ToDouble(AvgWeightTextBox.Text);
                local.Name = SortNameTextBox.Text;
                local.OriginCountry = Convert.ToInt32(CountryTextBox.Text);
                local.Seedlessness = Convert.ToInt32(SeedlessnessTextBox.Text);
                local.Sugar = Convert.ToDouble(SugarTextBox.Text);
                local.Taste = TasteTexBox.Text;
                MainForm form = Application.OpenForms["MainForm"] as MainForm;
                form.GrapeSortList.Add(local);
                form.SortManager.LoadData(local);
                form.UpdateGrapeSortTable();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

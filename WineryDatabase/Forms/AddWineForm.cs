using System;
using System.Windows.Forms;
using Winery.Instanses;

namespace WineryDatabase
{
    public partial class AddWineForm : Form
    {
        public AddWineForm()
        {
            InitializeComponent();
        }

        private void AddWineButton_Click(object sender, EventArgs e)
        {
            Wine local = new Wine();
            try
            {
                local.Id = Convert.ToInt32(IdTextBox.Text);
                local.Name = NameTextBox.Text;
                local.NameEng = NameEngTextBox.Text;
                local.Alcohol = Convert.ToDouble(AlcoholTextBox.Text);
                local.GrapeSort = Convert.ToInt32(GrapeSortTextBox.Text);
                local.Price = Convert.ToDouble(PriceTextBox.Text);
                local.SortCategory = Convert.ToInt32(WineSortTextBox.Text);
                local.SulfurDioxide = Convert.ToDouble(SulfurDioxideTextBox.Text);
                local.Sweetness = Convert.ToInt32(SweetnessTextBox.Text);
                local.Year = Convert.ToInt32(YearTextBox.Text);
                MainForm main = Application.OpenForms["MainForm"] as MainForm;
                main.WineManager.LoadData(local);
                main.WineList.Add(local);
                main.UpdateWineTable();
                this.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

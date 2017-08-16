using System.Windows.Forms;
using Winery.Instanses;
using Winery.DataBaseManagers;
using System;

namespace WineryDatabase.Forms
{
    public partial class EditWineForm : Form
    {
        public EditWineForm()
        {
            InitializeComponent();
        }

        public Wine WineForEditing
        {
            get; set;
        }

        private void EditWineButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                WineForEditing.Id = Convert.ToInt32(IdTextBox.Text);
                WineForEditing.Name = NameTextBox.Text;
                WineForEditing.NameEng = NameEngTextBox.Text;
                WineForEditing.Alcohol = Convert.ToDouble(AlcoholTextBox.Text);
                WineForEditing.GrapeSort = Convert.ToInt32(GrapeSortTextBox.Text);
                WineForEditing.Price = Convert.ToDouble(PriceTextBox.Text);
                WineForEditing.SortCategory = Convert.ToInt32(WineSortTextBox.Text);
                WineForEditing.SulfurDioxide = Convert.ToDouble(SulfurDioxideTextBox.Text);
                WineForEditing.Sweetness = Convert.ToInt32(SweetnessTextBox.Text);
                WineForEditing.Year = Convert.ToInt32(YearTextBox.Text);
                MainForm main = Application.OpenForms["MainForm"] as MainForm;
                main.WineManager.EditData(WineForEditing);
                main.UpdateWineTable();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

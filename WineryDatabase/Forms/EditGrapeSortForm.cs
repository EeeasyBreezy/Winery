using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winery.DataBaseManagers;
using Winery.Instanses;

namespace WineryDatabase.Forms
{
    public partial class EditGrapeSortForm : Form
    {
        public EditGrapeSortForm()
        {
            InitializeComponent();
        }
        public GrapeSort SortToEdit
        { get; set; }

        private void EditGrapeSortButton_Click(object sender, EventArgs e)
        {
            try
            {
                SortToEdit.Id = Convert.ToInt32(IdTextBox.Text);
                SortToEdit.Acidity = Convert.ToDouble(AcidityTextBox.Text);
                SortToEdit.AverageBerrySize = Convert.ToDouble(AvgWeightTextBox.Text);
                SortToEdit.Name = SortNameTextBox.Text;
                SortToEdit.OriginCountry = Convert.ToInt32(CountryTextBox.Text);
                SortToEdit.Seedlessness = Convert.ToInt32(SeedlessnessTextBox.Text);
                SortToEdit.Sugar = Convert.ToDouble(SugarTextBox.Text);
                SortToEdit.Taste = TasteTexBox.Text;
                MainForm form = Application.OpenForms["MainForm"] as MainForm;;
                form.SortManager.EditData(SortToEdit);
                form.UpdateGrapeSortTable();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

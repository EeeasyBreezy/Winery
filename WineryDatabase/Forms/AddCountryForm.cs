using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winery.Instanses;

namespace WineryDatabase.Forms
{
    public partial class AddCountryForm : Form
    {
        public AddCountryForm()
        {
            InitializeComponent();
        }

        private void AddCountryButton_Click(object sender, EventArgs e)
        {
            try
            {
                OriginCountry local = new OriginCountry(Convert.ToInt32(IdTextBox.Text),
                                                        CountryTextBox.Text);
                MainForm main = Application.OpenForms["MainForm"] as MainForm;
                main.CountryList.Add(local);
                main.CountryManager.LoadData(local);
                main.UpdateOriginCountryTable();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

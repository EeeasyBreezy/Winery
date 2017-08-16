using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineryDatabase.Forms
{
    public partial class SearchGrapeSortByCountryForm : Form
    {
        public SearchGrapeSortByCountryForm()
        {
            InitializeComponent();

            MainForm main = Application.OpenForms["MainForm"] as MainForm;
            foreach (var c in main.CountryList)
                CountriesComboBox.Items.Add(c.Name);
        }

        private void SearchByCountryButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

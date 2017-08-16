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
    public partial class AddWineSortForm : Form
    {
        public AddWineSortForm()
        {
            InitializeComponent();
        }

        private void AddWineSortButton_Click(object sender, EventArgs e)
        {
            try
            {
                WineSortCategory local = new WineSortCategory(Convert.ToInt32(IdTextBox.Text),
                                                                WineSortTextBox.Text);
                MainForm main = Application.OpenForms["MainForm"] as MainForm;
                main.WineSortManager.LoadData(local);
                main.SortCategoryList.Add(local);
                main.UpdateWineSortTable();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

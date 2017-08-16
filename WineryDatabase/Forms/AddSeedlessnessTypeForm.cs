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
    public partial class AddSeedlessnessTypeForm : Form
    {
        public AddSeedlessnessTypeForm()
        {
            InitializeComponent();
        }

        private void AddSeedlessnessTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SeedlessnessType local = new SeedlessnessType(Convert.ToInt32(IdTextBox.Text),
                                                                SeedlessnessTextBox.Text);
                MainForm main = Application.OpenForms["MainForm"] as MainForm;
                main.SeedlessnessList.Add(local);
                main.SeedlessnessManager.LoadData(local);
                main.UpdateSeednesslessTable();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

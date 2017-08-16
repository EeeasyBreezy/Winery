using System;
using System.Windows.Forms;
using Winery.Instanses;

namespace WineryDatabase.Forms
{
    public partial class AddSweetnessTypeForm : Form
    {
        public AddSweetnessTypeForm()
        {
            InitializeComponent();
        }

        private void AddSweetnessTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SweetnessDegree local = new SweetnessDegree(Convert.ToInt32(IdTextBox.Text),
                                                            SweetnessTextBox.Text);
                MainForm main = Application.OpenForms["MainForm"] as MainForm;
                main.SweetnessList.Add(local);
                main.SweetnessManager.LoadData(local);
                main.UpdateSweetnessTypeTable();
                this.Close();
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

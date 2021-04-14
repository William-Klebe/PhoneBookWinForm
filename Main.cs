using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Might not need this
using System.Data.Sql;//or this.
using PhoneBookWinForm.DataModifiers;

namespace PhoneBookWinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //on load do this.
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //using SelectRows method to grab data safely.
                DataSet personDataSet = new DataSet();
                personDataSet = Handlers.RetrieveSQLData(personDataSet, DataStrings.SqlConnectionString(), DataStrings.DGVMainFormDataQuery());
                dgvPersonInfo.DataSource = personDataSet.Tables["Person"];

                //forces columns in dgvPersonInfo to fill
                for (int i = 0; i < 6; i++)
                {
                    dgvPersonInfo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                MessageBox.Show("Connection successful.");
            }
            catch
            {
                //duh
                MessageBox.Show("Connection failed.");
            }

        }
        //click cell to generate form with row attributes.
        private void dgvPersonInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //If a row OTHER than the header is selected.
            if (e.RowIndex != -1)
            {
                int selectedID = Int32.Parse(dgvPersonInfo.CurrentRow.Cells[0].Value.ToString());
                Handlers.OpenPersonInformationForm(selectedID);
            }
        }

        //use this to prevent accidental closing of Main form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Handlers.CloseCancel();
        }

        //click new to generate personInformation.cs form with blank fields
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Handlers.OpenPersonInformationForm();
        }

    }
}

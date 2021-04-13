using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using PhoneBookWinForm.DataModifiers;

namespace PhoneBookWinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
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
        //click new to generate personInformation.cs form with blank fields
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Handlers.OpenPersonInformationForm();
        }

        //click cell to generate form with row attributes.
        private void dgvPersonInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int selectedID = Int32.Parse(dgvPersonInfo.CurrentRow.Cells[0].Value.ToString());
                Handlers.OpenPersonInformationForm(selectedID);
            }
        }
    }
}

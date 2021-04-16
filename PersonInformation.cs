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
using PhoneBookWinForm.DataModifiers;
using System.Data.Sql;

namespace PhoneBookWinForm
{
    public partial class PersonInformation : Form
    {
        //default form data with no arguements
        public PersonInformation()
        {
            InitializeComponent();
        }

        //Grab data if dgvPersonInfo row was clicked
        public PersonInformation(int selectedID)
        {
            InitializeComponent();

            //declare connection and command objects for method arguments on load.
            SqlConnection connection = new SqlConnection(DataStrings.SqlConnectionString());
            SqlCommand command = new SqlCommand(DataStrings.PersonInformationDataQuery(selectedID), connection);

            try //try reading the selected data from selectedID query.
            {
                connection.Open();
                //Use the person reader to execute the query command.
                using (SqlDataReader personReader = command.ExecuteReader())
                {
                    while (personReader.Read())
                    {
                        //input data from selected query into textboxes on PersonInformation.cs form.
                        txtPersonalInfo0.Text = selectedID.ToString();
                        txtPersonalInfo1.Text = (personReader["personFirstName"].ToString());
                        txtPersonalInfo2.Text = (personReader["personMiddleName"].ToString());
                        txtPersonalInfo3.Text = (personReader["personLastName"].ToString());
                        txtPersonalInfo4.Text = (personReader["personEmail"].ToString());
                        txtPersonalInfo5.Text = (personReader["personPhoneNumber"].ToString());
                        txtPersonalInfo6.Text = (personReader["personComments"].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an erorr grabbing selectedID data");
            }

            //close the connection after operation has completed.
            finally
            {
                connection.Close();
            }
        }

        //Use this list for inputData from textboxes.
        List<string> inputData = new List<string>();


        //add each textbox to a list, 
        //loop each textbox to a regex 
        //(phone number should only be ints)
        //(email should be email)
        //all other fields should be plain text.
        //push list to a SQL command to update/add/delete to DB

        //Save the current form's entry data.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //update "                         "
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //delete "                         "
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Secrets.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/william-klebe-681344157/");
        }

    }
}

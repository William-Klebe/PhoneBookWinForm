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
        //Scope of form used for input validation.
        List<string> inputData = new List<string>();
        
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
        
        //THIS MIGHT NOT BE NEEDED
        //Grab the data from textboxes.
        private void grabData(string toolType)
        {
            SqlConnection connection = new SqlConnection(DataStrings.SqlConnectionString());
            SqlCommand command = new SqlCommand(DataStrings.PersonInformationTools(toolType), connection);
            try
            {
                connection.Open();
                switch (toolType)
                {
                    case "insertTool":
                        
                        break;
                    case "updateTool":
                        MessageBox.Show("Tested here");
                        command.CommandType = CommandType.StoredProcedure;
                        //"UPDATE dbo.dbPersonInformation SET personFirstName = @personFirstName, " +
                        //"personMiddleName = @personMiddleName, " +
                        //"personLastName = @personLastName, " +
                        //"personEmail = @personEmail, " +
                        //"personPhoneNumber = @personPhoneNumber, " +
                        //"personComments = @personComments WHERE personID = @personID";
                        MessageBox.Show("here");
                        command.Parameters.Add(new SqlParameter("@personID",         txtPersonalInfo0.Text));
                        MessageBox.Show("eeeeehere");
                        command.Parameters.Add(new SqlParameter("@personFirstName",  txtPersonalInfo1.Text));
                        command.Parameters.Add(new SqlParameter("@personMiddleName", txtPersonalInfo2.Text));
                        command.Parameters.Add(new SqlParameter("@personLastName", txtPersonalInfo3.Text));
                        command.Parameters.Add(new SqlParameter("@personEmail", txtPersonalInfo4.Text));
                        command.Parameters.Add(new SqlParameter("@personPhoneNumber", txtPersonalInfo5.Text));
                        command.Parameters.Add(new SqlParameter("@personComments", txtPersonalInfo6.Rtf));

                        MessageBox.Show("eeeeeeeeeeeeeeeeeeeeeeeeeehere");
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("ID: " + txtPersonalInfo0.Text + " has been updated.");
                            }
                        }

                        break;
                    case "deleteTool":
                        
                        break;

                    default:
                        MessageBox.Show("No tool was selected");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("There was an erorr grabbing selectedID data");
            }
            finally
            {
                connection.Close();
            }
        }

        //Save the current form's entry data.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string saveTool = "insertTool";
            grabData(saveTool);
        }

        //update "                         "
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string updateTool = "updateTool";
            grabData(updateTool);
        }

        //delete "                         "
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string deleteTool = "deleteTool";
            grabData(deleteTool);
        }

        //Secrets.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/william-klebe-681344157/");
        }

    }
}

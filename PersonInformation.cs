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
                using SqlDataReader personReader = command.ExecuteReader();
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
       

#pragma warning disable IDE1006 // Naming Styles
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (String.IsNullOrEmpty(txtPersonalInfo0.Text))
            {
                using (SqlConnection connection = new SqlConnection(DataStrings.SqlConnectionString()))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO tblPersonInfo (personFirstName, personMiddleName, personLastName, personEmail, personPhoneNumber, personComments)" +
                        "VALUES (@fn, @mn, @ln, @em, @pn, @comments)";

                    //command.Parameters.AddWithValue("@id", txtPersonalInfo0.Text);
                    command.Parameters.AddWithValue("@fn", txtPersonalInfo1.Text);
                    command.Parameters.AddWithValue("@mn", txtPersonalInfo2.Text);
                    command.Parameters.AddWithValue("@ln", txtPersonalInfo3.Text);
                    command.Parameters.AddWithValue("@em", txtPersonalInfo4.Text);
                    command.Parameters.AddWithValue("@pn", txtPersonalInfo5.Text);
                    command.Parameters.AddWithValue("@comments", txtPersonalInfo6.Text);



                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                MessageBox.Show("Added", "Person Information", MessageBoxButtons.OK);
            }
            else
            {
                //MessageBox.Show("If this is a new entry, you need to use the \"File > Save\" button.", "Incorrect file feature", MessageBoxButtons.OK);
            }
        }

        //update "                         "
#pragma warning disable IDE1006 // Naming Styles
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (!String.IsNullOrEmpty(txtPersonalInfo0.Text))
            {
                using (SqlConnection connection = new SqlConnection(DataStrings.SqlConnectionString()))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE tblPersonInfo SET " +
                                    "personFirstName = @fn, " +
                                    "personMiddleName = @mn, " +
                                    "personLastName = @ln, " +
                                    "personEmail = @em, " +
                                    "personPhoneNumber = @pn, " +
                                    "personComments = @comments WHERE personID = @id";

                    command.Parameters.AddWithValue("@id", txtPersonalInfo0.Text);
                    command.Parameters.AddWithValue("@fn", txtPersonalInfo1.Text);
                    command.Parameters.AddWithValue("@mn", txtPersonalInfo2.Text);
                    command.Parameters.AddWithValue("@ln", txtPersonalInfo3.Text);
                    command.Parameters.AddWithValue("@em", txtPersonalInfo4.Text);
                    command.Parameters.AddWithValue("@pn", txtPersonalInfo5.Text);
                    command.Parameters.AddWithValue("@comments", txtPersonalInfo6.Text);



                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                MessageBox.Show("Updated", "Person Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("If this is a new entry, you need to use the \"File > Save\" button.", "Incorrect file feature", MessageBoxButtons.OK);
            }
        }

        //delete "                         "
#pragma warning disable IDE1006 // Naming Styles
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (!String.IsNullOrEmpty(txtPersonalInfo0.Text))
            {
                using (SqlConnection connection = new SqlConnection(DataStrings.SqlConnectionString()))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM tblPersonInfo WHERE personID = @id";

                    command.Parameters.AddWithValue("@id", txtPersonalInfo0.Text);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                MessageBox.Show("Deleted", "Person Information", MessageBoxButtons.OK);
            }
            else
            {
                //MessageBox.Show("If this is a new entry, you need to use the \"File > Save\" button.", "Incorrect file feature", MessageBoxButtons.OK);
            }
        }

        //Secrets.
#pragma warning disable IDE1006 // Naming Styles
        private void pictureBox1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/william-klebe-681344157/");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using PhoneBookWinForm.DataModifiers;
using System.Windows.Forms;

namespace PhoneBookWinForm
{
    class Handlers
    {
        //retrieves all sql data from DB
        internal static DataSet RetrieveSQLData(DataSet dataset, string connectionString, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                adapter.Fill(dataset, "Person");
                connection.Close();
                return dataset;
            }
        }

        //Dictates what type of Persona Information form should be open
        //If there's a selected ID it should open with selected data.
        internal static void OpenPersonInformationForm(int selectedID = 0)
        {
            if (selectedID < 1)
            {
                //open blank form
                PersonInformation personinformation = new PersonInformation();
                personinformation.ShowDialog();
            }
            else
            {
                //pass selected index (row ID) to edit Form.
                //SQL query grabs selected index in PersonInformation.cs Form.
                PersonInformation personinformation = new PersonInformation(selectedID);
                //personinformation.UpdateInfo(this);
                personinformation.ShowDialog();
            }
        }
        internal static bool ValidateInputData(List<String> inputData)
        {
            bool isAllValidated = false;
            //run this if all valid
            foreach(var String in inputData)
            {

            }




            if (isAllValidated)
            {
                isAllValidated = true;
            }
            else isAllValidated = false;

            return isAllValidated;
        }

        //prevents accidental closing of main form.
        internal static void CloseCancel()
        {
            const string message = "Are you sure you want to exit?";
            const string caption = "Exit form";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) Environment.Exit(0);
        }
    }
}

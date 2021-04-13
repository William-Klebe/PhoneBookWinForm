using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using PhoneBookWinForm.DataModifiers;

namespace PhoneBookWinForm
{
    class Handlers
    {
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
        internal static void OpenPersonInformationForm(int selectedID = 0)
        {
            if (selectedID < 1)
            {
                //open blank form
                PersonInformation personinformation = new PersonInformation();
                personinformation.Show();
            }
            else
            {
                //pass selected index (row ID) to edit Form.
                //SQL query grabs selected index in PersonInformation.cs Form.
                //MessageBox.Show("Passed: " + selectedID);
                PersonInformation personinformation = new PersonInformation(selectedID);
                personinformation.Show();
            }
        }

    }
}

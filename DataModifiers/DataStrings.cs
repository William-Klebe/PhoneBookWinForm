using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookWinForm.DataModifiers
{
    class DataStrings
    {
        //connection info if needed for copy/paste

        ////connection string and population query
        //internal string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Visual Studio Repo\PhoneBookWinForm\dbPersonInformation.mdf;Integrated Security=True";

        ////grab SQL data and format fields for proper output
        //internal readonly string dgvQuery = "SELECT personID as 'ID', " +
        //"personFirstName as 'First Name'," +
        //"personMiddleName as 'Middle Name'," +
        //"personLastName as 'Last Name'," +
        //"personEmail as 'Email', " +
        //"personPhoneNumber as 'Phone Number', " +
        //"personComments as 'Comments' " +
        //"FROM tblPersonInfo";
        internal static string SqlConnectionString()
        {
            //connection string and population query
            const string CONNECTIONSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Visual Studio Repo\PhoneBookWinForm\dbPersonInformation.mdf;Integrated Security=True";
            return CONNECTIONSTRING;    
        }         
        
        internal static string DGVMainFormDataQuery()
        {
            //string populateDGV = "SELECT * FROM tblPersonInfo";
            const string MAIN_DGV_FORMDATA = "SELECT personID as 'ID', " +
            "personFirstName as 'First Name'," +
            "personMiddleName as 'Middle Name'," +
            "personLastName as 'Last Name'," +
            "personEmail as 'Email', " +
            "personPhoneNumber as 'Phone Number', " +
            "personComments as 'Comments' " +
            "FROM tblPersonInfo";
            return MAIN_DGV_FORMDATA;
        }
        internal static string PersonInformationDataQuery(int selectedID = 0)
        {
            if (selectedID == 0)
            {
                const string message = ("There was an issue with the selected ID");
                MessageBox.Show(message);
                return "";
            }
            else
            {
                string PERSON_INFORMATION_QUERY = @"SELECT * FROM tblPersonInfo WHERE personID = " + selectedID;
                return PERSON_INFORMATION_QUERY;
            }
        }

    }
}

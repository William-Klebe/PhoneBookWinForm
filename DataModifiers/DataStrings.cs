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
        
        //connection string for SQL. 
        //Needs updating to be used on any PC
        internal static string SqlConnectionString()
        {
            //connection string
            const string CONNECTIONSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Visual Studio Repo\PhoneBookWinForm\dbPersonInformation.mdf;Integrated Security=True";
            return CONNECTIONSTRING;    
        }      
        //Self explainatory, used on the main form to populate data.
        internal static string DGVMainFormDataQuery()
        {
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
        //These need working, will be tied into handlers and personinformation form
        internal static string UpdateString()
        {
            const string PERSON_UPDATESTRING = "UPDATE dbo.dbPersonInformation SET personFirstName = @personFirstName, " +
                "personMiddleName = @personMiddleName, " +
                "personLastName = @personLastName, " +
                "personEmail = @personEmail, " +
                "personPhoneNumber = @personPhoneNumber, " +
                "personComments = @personComments WHERE personID = @personID";
                  return PERSON_UPDATESTRING;
        }
        internal static string InsertString()
        {
            const string PERSON_INSERTSTRING = "";
                  return PERSON_INSERTSTRING;
        }
        internal static string DeleteString()
        {
            const string PERSON_DELETESTRING = "";
                  return PERSON_DELETESTRING;
        }
        //selectedID handler when row is selected on the main form.
        internal static string PersonInformationDataQuery(int selectedID = 0)
        {
            if (selectedID == 0)
            {
                //throw error if selectedID was null
                const string message = ("There was an issue with the selected ID");
                MessageBox.Show(message);
                return "";
            }
            else
            {
                //return the string if not null.
                string PERSON_INFORMATION_QUERY = @"SELECT * FROM tblPersonInfo WHERE personID = " + selectedID;
                return PERSON_INFORMATION_QUERY;
            }
        }
        internal static string PersonInformationTools(string toolType)
        {
            string queryString = "";
            switch (toolType)
            {
                case "updateTool":
                    queryString = "UPDATE tblPersonInfo SET personFirstName = @fn, personMiddleName = @mn, personLastName = @ln, personEmail = @em, personPhoneNumber = @pn, personComments = @comments WHERE personID = @id";
                    break;
                case "":
                    break;
                case "uwu":
                    break;
                default: MessageBox.Show("There was an error with the SQL query string selector");
                    break;
            }

            return queryString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team3
{
    class ProgOps
    {
        public static string message = "An error has occurred in the program.";
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= inew2330fa21;User Id=group3fa212330;password=3954755";
        //build a connection to database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        private static SqlCommand _sqlLogOnCommand;
        private static SqlCommand _sqlUpdateCommand;

        public static void ConnectDatabase()
        {
            try
            {
                //SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
                //open the connection to db
                _cntDatabase.Open();
                MessageBox.Show("Database Open");
                _cntDatabase.Close();
                _cntDatabase.Dispose();
                MessageBox.Show("Database Closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string DatabaseCommandLogon(string query)
        {
            string result = "";
            try
            {
                SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
                //open the connection to db
                _cntDatabase.Open();
                //establish command object
                _sqlLogOnCommand = new SqlCommand(query, _cntDatabase);
                result = Convert.ToString(_sqlLogOnCommand.ExecuteScalar());
                _cntDatabase.Close();
                //dispose
                _cntDatabase.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }
        public static void UpdateDatabase(string strQuery)
        {
            try
            {
                SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
                //OPEN DB
                _cntDatabase.Open();
                //string to build query
                //establish command object
                _sqlUpdateCommand = new SqlCommand(strQuery, _cntDatabase);
                _sqlUpdateCommand.ExecuteNonQuery();
                //dispose of pub objects
                _sqlUpdateCommand.Dispose();
                //close connection
                _cntDatabase.Close();
                //dispose
                _cntDatabase.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

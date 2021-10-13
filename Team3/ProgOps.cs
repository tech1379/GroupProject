using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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
        private static string strTableName = "group3fa212330.Menu";

        ////add command object managers form
        private static SqlCommand _sqlResultsCommand;
        ////Add the data adapter managers form
        private static SqlDataAdapter _daResults = new SqlDataAdapter();
        ////Add the data table managers form
        private static DataTable _dtResultsTable = new DataTable();


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
        ////database command manager form
        public static void DatabaseCommandManager(string stringQuery, DataGridView dgvTester)
        {
            SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
            //set cmd obj to null
            _sqlResultsCommand = null;
            //reset data adapter and datatable to new
            _daResults = new SqlDataAdapter();
            _dtResultsTable = new DataTable();

            try
            {
                _cntDatabase.Open();
                MessageBox.Show("Database Open");
                //establish a command object
                _sqlResultsCommand = new SqlCommand(stringQuery, _cntDatabase);
                //establish data adapter
                _daResults.SelectCommand = _sqlResultsCommand;
                //fill the data table
                _daResults.Fill(_dtResultsTable);
                dgvTester.DataSource = _dtResultsTable;
                _cntDatabase.Close();
                _cntDatabase.Dispose();
                MessageBox.Show("Database Closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose of cmd, adapter, and table obj
            _sqlResultsCommand.Dispose();
            _daResults.Dispose();
            _dtResultsTable.Dispose();
  
 
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



        //added OPEN and CLOSE database methods for other forms (SUBJECT TO CHANGE) 9/23/21
        public static void OpenDatabase(SqlConnection _cntDatabase)
        {
            //method to open db and to allow use of data
            // open the connection to books db
            _cntDatabase.Open();

        }

        public static void CloseDatabase(SqlConnection _cntDatabase)
        {
            //method to close data and dispose of all objects
            //close connection
            _cntDatabase.Close();

            //dispose of connection obj cmd obj
            _cntDatabase.Dispose();

            MessageBox.Show("Connection to db was closed successfully",
                "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        ////close managers database - form close event
        public static void CloseDatabaseManager()
        {
            //close connections 
            _cntDatabase.Close();
            //dispose db
            _cntDatabase.Dispose();
            //message stating connection was closed successfully
            MessageBox.Show("Connection to db was closed successfully", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static List<Menu> ReloadImageList()
        {
            //TODO: Change the SELECT statement to the column names you are trying to use.
            string strCommand = $"SELECT MenuID, CategoryID, Name, Description, Price, Image FROM {strTableName};"; // Query to pull two columns of data from Images table            
            SqlCommand SelectCommand = new SqlCommand(strCommand, _cntDatabase);
            SqlDataReader sqlReader;

            List<Menu> lstMenu = new List<Menu>();
            lstMenu.Clear(); // Empty the list before loading new images to prevent duplications
            try
            {
                _cntDatabase.Open();
                sqlReader = SelectCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    Menu menu = new Menu();
                    menu.menuID = sqlReader.GetInt32(0); // MS SQL Datatype int
                    menu.categoryID = sqlReader.GetInt32(1); // MS SQL Datatype int
                    menu.name = sqlReader.GetString(2); // MS SQL Datatype int
                    menu.description = sqlReader.GetString(3); // MS SQL Datatype int
                    menu.price = sqlReader.GetDecimal(4); // MS SQL Datatype int
                    menu.Image = (byte[])sqlReader[5]; // MS SQL Datatype varbinary(MAX)
                    lstMenu.Add(menu); // Add image object to list

                    // You can use a constructor for this class to accept two parameters
                    // and add it all at the same time. Just for demo purposes

                    // lstImages.Add(new Images(sqlReader.GetInt32(0), (byte[])sqlReader[1]));
                }
                _cntDatabase.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error reloading images.", "Error with Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lstMenu;
        }

    }
}

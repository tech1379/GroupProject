using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
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
        private static SqlCommand _sqlMenuCommand;
        private static SqlCommand _sqlUpdateCommand;
        private static SqlDataAdapter _daMenu = new SqlDataAdapter();
        private static DataTable _dtMenuTable = new DataTable();
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
                //MessageBox.Show("Database Open");
                _cntDatabase.Close();
                _cntDatabase.Dispose();
                //MessageBox.Show("Database Closed");
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
                //MessageBox.Show("Database Open");
                //establish a command object
                _sqlResultsCommand = new SqlCommand(stringQuery, _cntDatabase);
                //establish data adapter
                _daResults.SelectCommand = _sqlResultsCommand;
                //fill the data table
                _daResults.Fill(_dtResultsTable);
                dgvTester.DataSource = _dtResultsTable;
                _cntDatabase.Close();
                _cntDatabase.Dispose();
                //MessageBox.Show("Database Closed");
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
        public static List<Menu> ReloadImageList(string strCommand)
        {
            //TODO: Change the SELECT statement to the column names you are trying to use.
            //string strCommand = $"SELECT MenuID, CategoryID, Name, Description, Price, Image FROM {strTableName};"; // Query to pull two columns of data from Images table            
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
        public static void DatabaseCommandAddItem(int CategoryID, string strName, string strDesc, decimal Price)
        {

            MessageBox.Show("You must add an image to save to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //OpenFileDialog Properties------------------------------------------
            OpenFileDialog openFile = new OpenFileDialog(); //New instance
            openFile.ValidateNames = true; //Prevent illegal characters
            openFile.AddExtension = false; //Auto fixes file extension problems
            openFile.Filter = "Image File|*.png|Image File|*.jpg"; //Allow types
            openFile.Title = "File to Upload"; //Title of dialog box
                                               //-------------------------------------------------------------------

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //TODO: Add some validation to make sure the file is an image.

                byte[] image = File.ReadAllBytes(openFile.FileName); //Convert image into a byte array
                try
                {
                    _cntDatabase.Open();
                    //TODO: Change (Image) to the name of your image column [e.g (ProductImages)]
                    string insertQuery = $"INSERT INTO {strTableName} VALUES('" + CategoryID + "', '" + strName + "', '" + strDesc + "', " + Price + ", @Image)"; // @Image is a parameter we will fill in later                        
                    SqlCommand insertCmd = new SqlCommand(insertQuery, _cntDatabase);
                    SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                    sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
                    insertCmd.ExecuteNonQuery();
                    _cntDatabase.Close();

                    MessageBox.Show("File was successfully added to the database.", "File Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error During Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public static void DatabaseCommandMenu(TextBox tbxName, TextBox tbxDescription, TextBox tbxPrice, int MenuID)
        {
            try
            {
                tbxName.DataBindings.Clear();
                tbxDescription.DataBindings.Clear();
                tbxPrice.DataBindings.Clear();
                //string to build query
                string query = "SELECT * FROM group3fa212330.Menu WHERE MenuID = " + MenuID + ";";
                //establish command object
                _sqlMenuCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daMenu = new SqlDataAdapter();
                _daMenu.SelectCommand = _sqlMenuCommand;
                //fill datatable
                _dtMenuTable = new DataTable();
                _daMenu.Fill(_dtMenuTable);
                //bind controls to textboxes
                tbxName.DataBindings.Add("Text", _dtMenuTable, "Name");
                tbxDescription.DataBindings.Add("Text", _dtMenuTable, "Description");
                tbxPrice.DataBindings.Add("Text", _dtMenuTable, "Price");

            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DatabaseCommandEditItem(int CategoryID, string strName, string strDesc, decimal Price, int MenuID)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to edit the image?", "Edit Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                //MessageBox.Show("Would you like to edit the image?.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //OpenFileDialog Properties------------------------------------------
            OpenFileDialog openFile = new OpenFileDialog(); //New instance
            openFile.ValidateNames = true; //Prevent illegal characters
            openFile.AddExtension = false; //Auto fixes file extension problems
            openFile.Filter = "Image File|*.png|Image File|*.jpg"; //Allow types
            openFile.Title = "File to Upload"; //Title of dialog box
                                               //-------------------------------------------------------------------

              
                    //TODO: Add some validation to make sure the file is an image.

                    byte[] image = File.ReadAllBytes(openFile.FileName); //Convert image into a byte array
                    try
                    {
                        _cntDatabase.Open();
                        //TODO: Change (Image) to the name of your image column [e.g (ProductImages)]
                        string insertQuery = $"UPDATE {strTableName} SET CategoryID = " + CategoryID + ", Name= '" + strName + "', Description = '" + strDesc + "', Price = " + Price + ", Image = @Image WHERE MenuID = " + MenuID + ";"; // @Image is a parameter we will fill in later                        
                        SqlCommand insertCmd = new SqlCommand(insertQuery, _cntDatabase);
                        SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                        sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
                        insertCmd.ExecuteNonQuery();
                        _cntDatabase.Close();

                        MessageBox.Show("File was successfully edited.", "File Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error During Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            else
            {
                try
                {
                    _cntDatabase.Open();
                    //TODO: Change (Image) to the name of your image column [e.g (ProductImages)]
                    string insertQuery = $"UPDATE {strTableName} SET CategoryID = " + CategoryID + ", Name= '" + strName + "', Description = '" + strDesc + "', Price = " + Price + " WHERE MenuID = " + MenuID + ";"; // @Image is a parameter we will fill in later                        
                    SqlCommand insertCmd = new SqlCommand(insertQuery, _cntDatabase);
                   // SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                    //sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
                    insertCmd.ExecuteNonQuery();
                    _cntDatabase.Close();

                    MessageBox.Show("File was successfully edited.", "File Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void DatabaseCommandDGV(string query, DataGridView dgvResults)
        {
            try
            {
                SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
                //OPEN DB
                _cntDatabase.Open();
                //set cmd obj to null
                _sqlResultsCommand = null;
                //reset data adapter and data table to new
                _daResults = new SqlDataAdapter();
                _dtResultsTable = new DataTable();


                //est command obj
                _sqlResultsCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daResults.SelectCommand = _sqlResultsCommand;
                //fill data table
                _daResults.Fill(_dtResultsTable);
                //bind to dgv to data table
                dgvResults.DataSource = _dtResultsTable;
                //dispose of cmd, adapter, and table obj
                _sqlResultsCommand.Dispose();
                _daResults.Dispose();
                _dtResultsTable.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualConnectionString
{
    public static class StaticClass
    {
        #region"LoadData"
        public static DataSet LoadData(string query, List<SqlParameter> sqlParam)
        {
            DataSet dt = new DataSet();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            foreach (var param in sqlParam)
            {
                command.Parameters.Add(param);
            }

            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
            objSqlDataAdapter.Fill(dt);
            connection.Close();


            return dt;
        }
        public static DataSet LoadData(string query, bool WithoutParameter)
        {
            DataSet dt = new DataSet();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;


            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
            objSqlDataAdapter.Fill(dt);
            connection.Close();


            return dt;
        }
        public static DataSet LoadData(string query)
        {

            DataSet dt = new DataSet();
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;


                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
                objSqlDataAdapter.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
        #region"Add Update Query"
        public static void ExceuteQuery(string query, List<SqlParameter> sqlParam)
        {

            var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            foreach (var param in sqlParam)
            {
                command.Parameters.Add(param);
            }
            command.ExecuteNonQuery();

        }
        public static void ExceuteQuery(string query, bool WithoutParameter)
        {

            var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;

            command.ExecuteNonQuery();

        }
        public static void ExceuteQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        #endregion
        //public static string connectionString = "Data Source=69.162.125.10;Initial Catalog=broadsol_Main;Integrated Security=false;Connect Timeout=30;User ID=broadsol_MainUser;Password=broad786SolUtions";
        public static string connectionStr = "";// ConfigurationManager.ConnectionStrings["ConnString"].ToString();

        public static string connectionString = connectionStr;

        public static string ServerName, initialCatelog, integratedSecurity, timeout, userId, password;
        public static void updateConnectionString(string ServerName, string initialCatelog, string integratedSecurity, string timeout, string userId, string password)
        {
            StaticClass.ServerName = ServerName;
            StaticClass.initialCatelog = initialCatelog;
            StaticClass.integratedSecurity = integratedSecurity;
            StaticClass.timeout = timeout;
            StaticClass.userId = userId;
            StaticClass.password = password;

            connectionStr = "Data Source=" + ServerName + ";Initial Catalog=" + initialCatelog + ";Integrated Security=" + integratedSecurity + ";Connect Timeout=" + timeout + ";User ID=" + userId + ";Password=" + password;
            connectionString = connectionStr;
        }

        public static void saveConnectionStringToFile()
        {
            string fileName = "connection.omr";
            ConnectionSerial objConnectionSerial = new ConnectionSerial();
            objConnectionSerial.serverName = ServerName;
            objConnectionSerial.databaseName = initialCatelog;
            objConnectionSerial.Timeout = timeout;
            objConnectionSerial.integratedSecurity = integratedSecurity;
            objConnectionSerial.userName = userId;
            objConnectionSerial.password = password;

            // Open a file and serialize the object into it in binary format.
            // EmployeeInfo.osl is the file that we are creating. 
            // Note:- you can give any extension you want for your file
            // If you use custom extensions, then the user will now 
            //   that the file is associated with your program.
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();


            bformatter.Serialize(stream, objConnectionSerial);
            stream.Close();

            //Clear mp for further usage.
            objConnectionSerial = null;
        }

        public static void loadConnectionStringFromFile()
        {
            string fileName = "connection.omr";
            if(!File.Exists(fileName))
            {
                saveConnectionStringToFile();
                MessageBox.Show("Please update Connection String before using Application");
            }
            //Open the file written above and read values from it.
            Stream stream = File.Open(fileName, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();

            ConnectionSerial objConnectionSerial = new ConnectionSerial();

            objConnectionSerial = (ConnectionSerial)bformatter.Deserialize(stream);
            stream.Close();

            updateConnectionString(objConnectionSerial.serverName, objConnectionSerial.databaseName, objConnectionSerial.integratedSecurity, objConnectionSerial.Timeout, objConnectionSerial.userName, objConnectionSerial.password);

        }
    }
}

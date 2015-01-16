using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Inter
{
    public static class Filter1
    {
        public static SqlConnection GetConnection()
        {
            string conn = @"DataSourse = (LocalDB);*";
            conn += @"AttachObFilename = ""G:\lil.mdf";
            conn += @"Integrated Security = True";
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(conn);
            return connection;
        }

        public static int Insert(int napravlenie, int kurs, int groop)
        {
            int retcod = 0;
            string trdata = DateTime.Now.ToShortDateString() + ' ' + DateTime.Now.ToShortTimeString();
            string ins = "Insert into Student" + "Values (@napravlenie, @kurs, @groop)";
            SqlConnection connection = Filter1.GetConnection();
            SqlCommand insertCommand = new SqlCommand(ins, connection);
            insertCommand.Parameters.AddWithValue("@napravlenie", napravlenie);
            insertCommand.Parameters.AddWithValue("@kurs", kurs);
            insertCommand.Parameters.AddWithValue("@groop", groop);
            try
            {
                connection.Open();
                
                retcod = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return retcod;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Multi_DB_Handler_Solution.Codes.DB_Handler
{
    class MySQL_DB_Handler
    {
        public MySqlConnection MySQL_Connection;
        public MySqlCommand MySQL_Command;
        public MySqlTransaction MySQL_Transaction;
       
        public static string Database_URL = ConfigurationSettings.AppSettings["Database_URL"];
        

        public void open_SQL_Connection()
        {

            
                    try
                    {
                        MySQL_Connection = new MySqlConnection(Database_URL);
                        if (MySQL_Connection.State == ConnectionState.Closed)
                        {
                            MySQL_Connection.Open();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error " + exception.ToString());
                    }
                  
        }

        public DataTable General_ReturnDataTable()
        {
            try
            {
                DataTable Data_Table = new DataTable();
                MySqlDataAdapter MySQL_Data_Adapter = new MySqlDataAdapter(MySQL_Command);
                MySQL_Data_Adapter.Fill(Data_Table);
                return Data_Table;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception" + exception.ToString());

                return null;
            }

        }


        
        DataTable dt;
        MySqlDataAdapter da;
        

        public MySQL_DB_Handler()
        {
            MySQL_Connection = new MySqlConnection(Database_URL);
        }

        public  DataTable GetTable(String str)
        {
            dt = new DataTable();
            try
            {
                da = new MySqlDataAdapter(str, MySQL_Connection);
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show("Database Error, Reason : " + e.Message);

            }
            return dt;
          
        }

        public DataSet ret(string s)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = MySQL_Connection;
            cmd.CommandText = s;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
	
		
        public int max_plus(string s)
        {
            int id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = MySQL_Connection;
            cmd.CommandText = s;
            try
            {
                MySQL_Connection.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            }
            catch
            {
                id = 1;
            }
            finally
            {
                MySQL_Connection.Close();
            }
            return id;
        }

      
        public decimal sum(string s)
        {
            decimal id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = MySQL_Connection;
            cmd.CommandText = s;
            try
            {
                MySQL_Connection.Open();
                id = Convert.ToDecimal(cmd.ExecuteScalar());

            }
            catch
            {
                id = 0;
            }
            finally
            {
                MySQL_Connection.Close();
            }
            return id;
        }

        public long get_single_field_row_count_with_condition(string field, string table,string condition_field,string condition)
        {
            return Convert.ToInt64(GetValue(query_builder("SELECT COUNT", field, table, condition_field, condition)));
        }

        public string query_builder(string type, string field, string table,string condition_field,string condition)
        {
            string result = "";
            switch (type)
            {
                case "SELECT COUNT" : result= "SELECT COUNT(" + field + ") FROM " + table + " WHERE (" + condition_field + " =" + condition + ");";
                    break;
                case "Another": break;
            }
            //MessageBox.Show(result);
            return result;
        }
        
        public string GetValue(String query)
        {
           
            MySqlCommand cmd = new MySqlCommand();
            MySQL_Connection.Open();

            string str;
            try
            {
                cmd = new MySqlCommand(query, MySQL_Connection);
                str = cmd.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                str = "0";
            }
            MySQL_Connection.Close();

            return str;
        }
		
        public bool Ins_Up_Del(String query)
        {
            bool result = false;
            try
            {
                MySQL_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, MySQL_Connection);

                cmd.ExecuteNonQuery();
                MySQL_Connection.Close();
                result = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Database Error, Reason : " + e.Message);

            }
            return result;
            
        }

        public void close()
        {
            MySQL_Connection.Close();
        }
       
    }
}

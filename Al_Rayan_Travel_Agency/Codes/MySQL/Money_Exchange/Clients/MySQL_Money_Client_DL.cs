using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Travel_Agency_Soution.Codes.MySQL.Client.Money_Client
{
    class MySQL_Money_Client_DL:MySQL_DB_Handler
    {
        
        public DataTable Return_Money_Client_Table(int flag, String search_id)
        {
            open_SQL_Connection();

            MySQL_Command = new MySqlCommand();
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            MySQL_Command.CommandText = "get_client";
            MySQL_Command.Parameters.AddWithValue("@flag", flag);
            MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
            MySQL_Command.Parameters.AddWithValue("@search_id", search_id);
            MySQL_Command.Parameters["@search_id"].Direction = ParameterDirection.Input;

            return General_ReturnDataTable();

        }

        public bool insert_Monay_Client(MySQL_Money_Client_GL MySQL_MCGL)
        {
            open_SQL_Connection();


            MySQL_Transaction = MySQL_Connection.BeginTransaction();
            MySQL_Command = new MySqlCommand();
            MySQL_Command.Transaction = MySQL_Transaction;
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            try
            {
                
                MySQL_Command.CommandText = "client";
                //MySQL_Command.Parameters.AddWithValue("@flag", 2);
                //MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@id_client", MySQL_MCGL.id_client);
                MySQL_Command.Parameters["@id_client"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@client_name", MySQL_MCGL.client_name);
                MySQL_Command.Parameters["@client_name"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@client_address", MySQL_MCGL.client_address);
                MySQL_Command.Parameters["@client_address"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@client_mobile", MySQL_MCGL.client_mobile);
                MySQL_Command.Parameters["@client_mobile"].Direction = ParameterDirection.Input;




                MySQL_Command.ExecuteNonQuery();

                MySQL_Transaction.Commit();
                return true;
            }
            catch (Exception exception)
            {
                ((DbTransaction)MySQL_Transaction).Rollback();
                MessageBox.Show("Error while saving .. Please try again, Reason : " + exception.Message);

                return false;
            }




        }
    }
}

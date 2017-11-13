using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Travel_Agency_Soution.Codes.MySQL.Travels
{
    class MySQL_Ticket_One_DL : MySQL_DB_Handler
    {
      
public bool insert_ticket_one(MySQL_Ticket_One_GL MySQL_TOGL)
{
open_SQL_Connection();
MySQL_Transaction = MySQL_Connection.BeginTransaction();
MySQL_Command = new MySqlCommand();
MySQL_Command.Transaction = MySQL_Transaction;
MySQL_Command.Connection = MySQL_Connection;
MySQL_Command.CommandType = CommandType.StoredProcedure;
try
{
    MySQL_Command.CommandText = "ticket_one";
//MySQL_Command.Parameters.AddWithValue("@flag", 2);
//MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
MySQL_Command.Parameters.AddWithValue("@airline", MySQL_TOGL.airline);
MySQL_Command.Parameters["@airline"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@new_date", MySQL_TOGL.new_date);
MySQL_Command.Parameters["@new_date"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@new_connection", MySQL_TOGL.new_connection);
MySQL_Command.Parameters["@new_connection"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@date_time", MySQL_TOGL.date_time);
MySQL_Command.Parameters["@date_time"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@new_from", MySQL_TOGL.new_from);
MySQL_Command.Parameters["@new_from"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@new_to", MySQL_TOGL.new_to);
MySQL_Command.Parameters["@new_to"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@class", MySQL_TOGL.new_class);
MySQL_Command.Parameters["@class"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@pnr", MySQL_TOGL.pnr);
MySQL_Command.Parameters["@pnr"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@issue", MySQL_TOGL.issue);
MySQL_Command.Parameters["@issue"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@amount", MySQL_TOGL.amount);
MySQL_Command.Parameters["@amount"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@commision", MySQL_TOGL.commision);
MySQL_Command.Parameters["@commision"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@total", MySQL_TOGL.total);
MySQL_Command.Parameters["@total"].Direction = ParameterDirection.Input;

MySQL_Command.Parameters.AddWithValue("@id_client", MySQL_TOGL.id_client);
MySQL_Command.Parameters["@id_client"].Direction = ParameterDirection.Input;

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

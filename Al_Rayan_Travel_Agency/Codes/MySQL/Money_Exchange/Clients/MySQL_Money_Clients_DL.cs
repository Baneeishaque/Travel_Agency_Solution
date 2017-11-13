using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Al_Rayan_Travel_Agency.Codes.MySQL
{
    class MySQL_Money_Clients_DL
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();
        DataTable dt = new DataTable();

        public DataTable return_clients()
        {
            dt = new DataTable();
            dt = db.GetTable("SELECT `money_client`.`id`, `money_client`.`name`, `money_client`.`address`,`money_client`.`mobile`FROM `alrayan`.`money_client` WHERE status='K';");
            
            return dt;
        }

       

        public DataTable return_client(string id)
        {
            dt = new DataTable();
            dt = db.GetTable("SELECT  `money_client`.`name`, `money_client`.`address`,`money_client`.`mobile`FROM `alrayan`.`money_client` where id=" + id + ";");

            return dt;
        }

        public bool delete_client(string id)
        {
            return db.Ins_Up_Del("UPDATE `alrayan`.`money_client` SET `status` = 'R' WHERE `id` = " + id + ";");

        }

        public bool insert_client(string id, string name, string address, string mobile)
        {
            return db.Ins_Up_Del("INSERT INTO `alrayan`.`money_client`(id,`name`, `address`,`mobile`) VALUES ('" + id + "','" + name + "', '" + address + "', '" + mobile + "');");

        }

        public bool update_client(string id, string name, string address, string mobile)
        {
            return db.Ins_Up_Del("UPDATE `alrayan`.`money_client` SET `name` = '" + name + "', `address` = '" + address + "', `mobile` ='" + mobile + "' WHERE `id` = " + id + ";");

        }

        public DataTable return_last_client_id()
        {
            dt = new DataTable();
            dt = db.GetTable("SELECT MAX(id) FROM `alrayan`.`money_client`;");
            return dt;
        }
    }
}

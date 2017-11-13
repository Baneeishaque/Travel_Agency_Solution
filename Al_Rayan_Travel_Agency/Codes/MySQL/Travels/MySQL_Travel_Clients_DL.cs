using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;

namespace Al_Rayan_Travel_Agency.Codes.MySQL.Travels
{
    class MySQL_Travel_Clients_DL
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();
        DataTable dt = new DataTable();

        public DataTable return_clients()
        {
            dt = new DataTable();
            dt = db.GetTable("SELECT `travel_client`.`id`, `travel_client`.`name`, `travel_client`.`address`,`travel_client`.`mobile`FROM `alrayan`.`travel_client` WHERE status='K';");

            return dt;
        }

        public DataTable return_client(string id)
        {
            dt = new DataTable();
            dt = db.GetTable("SELECT  `travel_client`.`name`, `travel_client`.`address`,`travel_client`.`mobile`FROM `alrayan`.`travel_client` where id=" + id + ";");

            return dt;
        }

        public bool delete_client(string id)
        {
            return db.Ins_Up_Del("UPDATE `alrayan`.`travel_client` SET `status` = 'R' WHERE `id` = " + id + ";");

        }

        public bool insert_client(string id, string name, string address, string mobile)
        {
            return db.Ins_Up_Del("INSERT INTO `alrayan`.`travel_client`(id,`name`, `address`,`mobile`) VALUES ('" + id + "','" + name + "', '" + address + "', '" + mobile + "');");

        }

        public bool update_client(string id, string name, string address, string mobile)
        {
            return db.Ins_Up_Del("UPDATE `alrayan`.`travel_client` SET `name` = '" + name + "', `address` = '" + address + "', `mobile` ='" + mobile + "' WHERE `id` = " + id + ";");

        }

        public DataTable return_last_client_id()
        {
            dt = new DataTable();
            dt = db.GetTable("SELECT MAX(id) FROM `alrayan`.`travel_client`;");
            return dt;
        }
    }
}

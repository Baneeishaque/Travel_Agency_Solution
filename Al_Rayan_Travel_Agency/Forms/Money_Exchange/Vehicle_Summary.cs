using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multi_DB_Handler_Solution.Codes.DB_Handler;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Vehicle_Summary : Form
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public Vehicle_Summary()
        {
            InitializeComponent();
            dt=db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`, `receive_money`.`id_client`,`collection`.benefit FROM `alrayan`.`collection`,`alrayan`.`receive_money` where operation='Receive' AND  `receive_money`.`id`=`collection`.`id_operation` AND `receive_money`.`id_client`=1000;");
            
            //dt2=db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`, `send_money`.`id_client`,`collection`.benefit FROM `alrayan`.`collection`,`alrayan`.`send_money` where operation='Send' AND  `send_money`.`id_send_money`=`collection`.`id_operation` AND `send_money`.`id_client`=1000;");

            //for(int i=0;i<dt2.Rows.Count;i++)
            //{
            //    dt.Rows.Add(dt2.Rows[i]);
            //}


            //dt2=db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`, `vissa`.`id_client`,`collection`.benefit FROM `alrayan`.`collection`,`alrayan`.`vissa` where operation='Visa' AND  `vissa`.`id`=`collection`.`id_operation` AND `vissa`.`id_client`=1000;");

            //for(int i=0;i<dt2.Rows.Count;i++)
            //{
            //    dt.Rows.Add(dt2.Rows[i]);
            //}

            //dt2=db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`, `ticket_one`.`id_client`,`collection`.benefit FROM `alrayan`.`collection`,`alrayan`.`ticket_one` where operation='Ticket' AND  `ticket_one`.`id`=`collection`.`id_operation` AND `ticket_one`.`id_client`=1000;");

            //for(int i=0;i<dt2.Rows.Count;i++)
            //{
            //    dt.Rows.Add(dt2.Rows[i]);
            //}

            dataGridView6.DataSource = dt;
              
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL;
using Multi_DB_Handler_Solution.Codes.DB_Handler;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Collection : Form
    {
        MySQL_Collection_DL MySQL_CDL = new MySQL_Collection_DL();
        MySQL_DB_Handler db = new MySQL_DB_Handler();
  
        public Collection()
        {
            InitializeComponent();
            
            
           

                
                    dataGridView6.DataSource = MySQL_CDL.Return_Collection_Table(1);
               



              
            
        }

        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_filter.SelectedItem.ToString())
            {
                case "All": dataGridView6.DataSource = MySQL_CDL.Return_Collection_Table(1);
                    break;

                case "Money Exchange": dataGridView6.DataSource = db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`FROM `alrayan`.`collection` where operation='Send' OR operation='Receive';");
                    break;

                case "Money Exchange : Send Money": dataGridView6.DataSource = db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`FROM `alrayan`.`collection` where operation='Send';");
                    break;

                case "Money Exchange : Receive Money": dataGridView6.DataSource = db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`FROM `alrayan`.`collection` where operation='Receive';");
                    break;
                case "Travels": dataGridView6.DataSource = db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`FROM `alrayan`.`collection` where operation='Visa' OR operation='Ticket';");
                    break;
                case "Travels : Visa": dataGridView6.DataSource = db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`FROM `alrayan`.`collection` where operation='Visa' ;");
                    break;
                case "Travels : Ticket": dataGridView6.DataSource = db.GetTable("SELECT `collection`.`id`, `collection`.`date`, `collection`.`id_operation`, `collection`.`operation`, `collection`.`amount`FROM `alrayan`.`collection` where operation='Ticket';");
                    break;
            }
        }
    }
}

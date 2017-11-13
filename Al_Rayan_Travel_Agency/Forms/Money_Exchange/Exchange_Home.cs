using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL.Exchange_Rate;
using Common_Programming_Tasks;
using ProBunk;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Exchange_Home : Form
    {
        DataTable Data_Table = new DataTable();
        MySQL_Exchange_Rate_DL MySQL_GExRDL = new MySQL_Exchange_Rate_DL();
        MySQL_Exchange_Rate_GL MySQL_ExRGL = new MySQL_Exchange_Rate_GL();
        public Exchange_Home()
        {
            InitializeComponent();
            

            label_exchange_rate.Text = MySQL_GExRDL.Return_Current_Rate_Table().Rows[0][1].ToString() + " " + label_exchange_rate.Text; 
            
          
           


        }

        private bool Validation()
        {

            err.Dispose();
            //return isemptyg(new Control[2] { txt_username,txt_password }) ;
            return true;
            
        }

        

        ErrorProvider err = new ErrorProvider();

        bool isemptyg(System.Windows.Forms.Control[] c)
        {
            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Text.Equals(""))
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }
            return ret;
        }


        

        private void button_notifications_Click(object sender, EventArgs e)
        {
            //new Notifications().ShowDialog();
        }

        

        private void button_trips_Click(object sender, EventArgs e)
        {
            new Money_Clients().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //new Batha_Assign().ShowDialog();
        }

        

        
       

        private void button_vehicle_Click(object sender, EventArgs e)
        {
            new Profit().ShowDialog();
        }

        private void button_batha_Click(object sender, EventArgs e)
        {
            new About_Us().ShowDialog();
        }

       
        private void button_employee_Click(object sender, EventArgs e)
        {
            
            new Collection().ShowDialog();

        }

        private void button_trip_Click(object sender, EventArgs e)
        {
            new Send_Money().ShowDialog();
        }

        private void button_petrol_Click(object sender, EventArgs e)
        {
            new Receive_Money().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySQL_ExRGL.new_current_rate = textBox_new_exchange_rate.Text;
            MySQL_ExRGL.insert_date = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            MySQL_ExRGL.new_alterator = Login.person;

            if (MySQL_ExRGL.update_Exchange_Rate())
            {
                MessageBox.Show("Success");
                Common_Tasks.nullify(new Control[] { textBox_new_exchange_rate });

                label_exchange_rate.Text = MySQL_GExRDL.Return_Current_Rate_Table().Rows[0][1].ToString() + " INR"; 
            }

            
        }

        

       

        

        

        

        
    }
}

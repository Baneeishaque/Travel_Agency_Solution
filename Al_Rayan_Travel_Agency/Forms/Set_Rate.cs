using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL.Exchange_Rate;

namespace Travel_Agency_Soution.Forms
{
    public partial class Set_Rate : Form
    {
        MySQL_Exchange_Rate_DL MySQL_GExRDL = new MySQL_Exchange_Rate_DL();
        MySQL_Exchange_Rate_GL MySQL_ExRGL = new MySQL_Exchange_Rate_GL();
       
        
        public Set_Rate()
        {
            InitializeComponent();
            
            label_exchange_rate.Text = MySQL_GExRDL.Return_Current_Rate_Table().Rows[0][1].ToString() + " " + label_exchange_rate.Text; 

            //MessageBox.Show(DateTime.Now.ToLongDateString()+" "+DateTime.Now.ToLongTimeString());
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MySQL_ExRGL.new_current_rate = textBox_new_exchange_rate.Text;
            MySQL_ExRGL.insert_date = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            MySQL_ExRGL.new_alterator="logined person";
            
            if (MySQL_ExRGL.update_Exchange_Rate())
            {
                MessageBox.Show("Success");
            }
           
            new Home().Show();
            this.Hide();
        }

        private void button_ignore_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}

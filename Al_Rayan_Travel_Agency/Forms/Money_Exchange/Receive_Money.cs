using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL.Money.Receive_Money;
using Travel_Agency_Soution.Codes.MySQL.Exchange_Rate;
using Travel_Agency_Soution.Codes.MySQL.Client.Money_Client;
using Common_Programming_Tasks;
using Multi_DB_Handler_Solution.Codes.DB_Handler;

namespace Aryavidyashala_Vehicle_Management_System
{
    
    public partial class Receive_Money : Form
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();
        private int update_flag=0;
        MySQL_Money_Client_DL MySQL_MCDL = new MySQL_Money_Client_DL();
        MySQL_Exchange_Rate_DL MySQL_GExRDL = new MySQL_Exchange_Rate_DL();

        MySQL_Money_Client_GL MySQL_MCGL = new MySQL_Money_Client_GL();
        MySQL_Receive_Money_GL MySQL_RMGL = new MySQL_Receive_Money_GL();

        DataTable Data_Table = new DataTable();
       
        public Receive_Money()
        {
            InitializeComponent();
            panel_client_details.Hide();
            panel_send_money_details.Hide();
            label_current_date.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            textBox_rate.Text = MySQL_GExRDL.Return_Current_Rate_Table().Rows[0][1].ToString();
            Data_Table = MySQL_MCDL.Return_Money_Client_Table(1, "0");

            for (int i = 0; i < Data_Table.Rows.Count; i++)
            {
                comboBox_client_id.Items.Add("AR " + Data_Table.Rows[i][0].ToString() + " : " + Data_Table.Rows[i][1].ToString());
            }

            Data_Table = MySQL_MCDL.Return_Money_Client_Table(3, "0");
            if (Common_Tasks.return_and_assign_next_id_with_prefix("AR", Data_Table, label_client_id, 1000))
            {
                panel_client_details.Show();
                panel_send_money_details.Show();
                Common_Tasks.disable(new Control[] { comboBox_client_id, button_add_client });
            }
        }






        private void comboBox_client_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox_client_id.SelectedItem.ToString().Equals(""))
            {
                panel_client_details.Show();
                panel_send_money_details.Show();
                button_add_client.Hide();

                //MessageBox.Show(comboBox_client_id.SelectedItem.ToString().Substring(2,(comboBox_client_id.SelectedItem.ToString().IndexOf(" : "))-2));

                Data_Table = MySQL_MCDL.Return_Money_Client_Table(2, comboBox_client_id.SelectedItem.ToString().Substring(2, (comboBox_client_id.SelectedItem.ToString().IndexOf(" : ")) - 2));

                label_client_id.Text = "AR " + Data_Table.Rows[0][0].ToString();
                textBox_client_name.Text = Data_Table.Rows[0][1].ToString();
                richTextBox_client_address.Text = Data_Table.Rows[0][2].ToString();
                textBox_client_mobile_number.Text = Data_Table.Rows[0][3].ToString();

                Common_Tasks.disable(new Control[] { textBox_client_name, richTextBox_client_address, textBox_client_mobile_number });


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_client_details.Show();
            panel_send_money_details.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button_add_client.Visible)
            {
                MySQL_MCGL.client_name = textBox_client_name.Text;
                MySQL_MCGL.client_address = richTextBox_client_address.Text;
                MySQL_MCGL.client_mobile = textBox_client_mobile_number.Text;
                MySQL_MCGL.id_client = label_client_id.Text.Substring(3);

                if (MySQL_MCGL.insert_Monay_Client())
                {
                    MessageBox.Show("Client Success");
                }
            }

            MySQL_RMGL.new_date = label_current_date.Text;
            MySQL_RMGL.rate = textBox_rate.Text;
            MySQL_RMGL.inr = textBox_amount.Text;
            MySQL_RMGL.actual_aed = textBox_actual_AED.Text;
            MySQL_RMGL.deliver_aed = textBox_deliver_AED.Text;
            MySQL_RMGL.benefit = textBox_benefit.Text;
            MySQL_RMGL.agency_rate = textBox_agency_rate.Text;

            MySQL_RMGL.id_client = label_client_id.Text.Substring(3);

            if (MySQL_RMGL.insert_Receive_Money())
            {
                MessageBox.Show("Receive Money Success");
            }

            this.Close();
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            textBox_actual_AED.Text = Math.Round(Double.Parse(textBox_amount.Text) / Double.Parse(textBox_rate.Text),2).ToString();
            textBox_deliver_AED.Text = Math.Round(Double.Parse(textBox_amount.Text) / Double.Parse(textBox_agency_rate.Text),2).ToString();
            textBox_benefit.Text = Math.Round(Double.Parse(textBox_actual_AED.Text) - Double.Parse(textBox_deliver_AED.Text),2).ToString();
        }

        bool isselectedg(System.Windows.Forms.ComboBox[] c)
        {

            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].SelectedIndex == 0)
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }
            
            return ret;
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



        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL.Exchange_Rate;
using Travel_Agency_Soution.Codes.MySQL.Client.Money_Client;
using Travel_Agency_Soution.Codes.MySQL;
using Common_Programming_Tasks;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using Al_Rayan_Travel_Agency.Codes.MySQL;
using Al_Rayan_Travel_Agency.Forms.Money_Exchange;
using Al_Rayan_Travel_Agency.Codes.MySQL.Money_Exchange.Send_Money;

namespace Aryavidyashala_Vehicle_Management_System
{
    
    public partial class Send_Money : Form
    {
        MySQL_Money_Client_GL MySQL_MCGL = new MySQL_Money_Client_GL();
        MySQL_Money_Client_DL MySQL_MCDL = new MySQL_Money_Client_DL();
        MySQL_Exchange_Rate_DL MySQL_GExRDL = new MySQL_Exchange_Rate_DL();
        MySQL_Send_Money_GL MySQL_SMGL = new MySQL_Send_Money_GL();

        Send_Money_DL SMDL = new Send_Money_DL();

        MySQL_Money_Clients_DL MCDL = new MySQL_Money_Clients_DL();

        public int balance_flag;

        DataTable Data_Table = new DataTable();

        MySQL_DB_Handler db = new MySQL_DB_Handler();

        public Send_Money()
        {
            InitializeComponent();

            Common_Tasks.hide(new Control[] { panel_client_details, panel_send_money_details, panel_tasks, label_task_information });
            label_current_date.Text = Common_Tasks .return_current_date_time();

            textBox_rate.Text = MySQL_GExRDL.Return_Current_Rate_Table().Rows[0][1].ToString();

            Data_Table = MCDL.return_last_client_id();

            if (Common_Tasks.return_and_assign_next_id_with_prefix(Money_Exchange_Common.prefix, Data_Table, label_client_id, 1000))
            {
                Common_Tasks.show(new Control[] { panel_client_details, panel_send_money_details });
                Common_Tasks.disable(new Control[] { comboBox_client_id, button_add_client });
            }
            else
            {
                Common_Tasks.bind_combo_with_id_with_prefix_and_field_after_clear(MCDL.return_clients(), comboBox_client_id, 0, 1, Money_Exchange_Common.prefix);
            }
            
        }


        private void comboBox_client_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox_client_id.SelectedItem.ToString().Equals(""))
            {
                Common_Tasks.disable(new Control[] { textBox_client_name, richTextBox_client_address, textBox_client_mobile_number, textBox_adv1 });
                Common_Tasks.hide(button_add_client);

                //MessageBox.Show(comboBox_client_id.SelectedItem.ToString().Substring(2,(comboBox_client_id.SelectedItem.ToString().IndexOf(" : "))-2));

                Data_Table = MySQL_MCDL.Return_Money_Client_Table(2, comboBox_client_id.SelectedItem.ToString().Substring(2, (comboBox_client_id.SelectedItem.ToString().IndexOf(" : ")) - 2));

                label_client_id.Text = "MC " + Data_Table.Rows[0][0].ToString();
                textBox_client_name.Text = Data_Table.Rows[0][1].ToString();
                richTextBox_client_address.Text = Data_Table.Rows[0][2].ToString();
                textBox_client_mobile_number.Text = Data_Table.Rows[0][3].ToString();

                double bal=Convert.ToDouble(SMDL.check_balance(comboBox_client_id.SelectedItem.ToString().Substring(2, (comboBox_client_id.SelectedItem.ToString().IndexOf(" : ")) - 2)));

                //MessageBox.Show(bal.ToString());

                if (bal == 0)
                {
                    Common_Tasks.show(new Control[] { panel_client_details});
                   

                    MessageBox.Show("Already OK");
                }

                else if (bal == -1)
                {
                    Common_Tasks.show(new Control[] { panel_client_details, panel_send_money_details });
                }

                else
                {
                    Data_Table = db.GetTable("SELECT        *  FROM            send_money WHERE        (id_client = " + comboBox_client_id.SelectedItem.ToString().Substring(2, (comboBox_client_id.SelectedItem.ToString().IndexOf(" : ")) - 2) + ")");

                    Common_Tasks.readOnly(new TextBox[] { textBox_INR, textBox_benefit });

                    textBox_rate.Text = Data_Table.Rows[0]["rate"].ToString();
                    textBox_INR.Text = Data_Table.Rows[0]["inr"].ToString();
                    textBox_AED.Text = Data_Table.Rows[0]["aed"].ToString();
                    textBox_total_AED.Text = Data_Table.Rows[0]["total_aed"].ToString();
                    textBox_benefit.Text = Data_Table.Rows[0]["benefit"].ToString();
                    textBox_adv1.Text = Data_Table.Rows[0]["advance1"].ToString();
                    textBox_adv2.Text = Data_Table.Rows[0]["advance2"].ToString();
                    textBox_adv3.Text = Data_Table.Rows[0]["advance3"].ToString();
                    label_advance_1_date.Text = Data_Table.Rows[0]["advance1_date"].ToString();
                    label_advance_2_date.Text = Data_Table.Rows[0]["advance2_date"].ToString();
                    label_advance_3_date.Text = Data_Table.Rows[0]["advance3_date"].ToString();
                    textBox_balance.Text = Data_Table.Rows[0]["balance"].ToString();

                    Common_Tasks.disable(new Control[] { textBox_adv1 });

                    if (!textBox_adv2.Text.Equals("0"))
                    {
                        Common_Tasks.readOnly(new TextBox[] { textBox_adv2 });
                    }

                    update_flag = 1;
                }

            }
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

        private void button_add_client_Click(object sender, EventArgs e)
        {
            panel_client_details.Show();
            panel_send_money_details.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (update_flag == 1)
            {
                //textBox_client_mobile_number.Text = "UPDATE       send_money SET                `date` =" + label_current_date.Text + ", advance2 =" + textBox_adv2.Text + ", advance3 =" + textBox_adv3.Text + ", balance =" + textBox_balance.Text + " WHERE        (id_client = " + comboBox_client_id.SelectedItem.ToString().Substring(2, (comboBox_client_id.SelectedItem.ToString().IndexOf(" : ")) - 2) + ")";

                db.Ins_Up_Del("UPDATE       send_money SET                `date` ='"+label_current_date.Text+"', advance2 ="+textBox_adv2.Text+", advance3 ="+textBox_adv3.Text+", balance ="+textBox_balance.Text+" WHERE        (id_client = " + comboBox_client_id.SelectedItem.ToString().Substring(2, (comboBox_client_id.SelectedItem.ToString().IndexOf(" : ")) - 2) + ")");

                
                MessageBox.Show("Updation Success");
            }
            else
            {
                if (button_add_client.Visible)
                {
                    //MySQL_MCGL.client_name = textBox_client_name.Text;
                    //MySQL_MCGL.client_address = richTextBox_client_address.Text;
                    //MySQL_MCGL.client_mobile = textBox_client_mobile_number.Text;
                    //MySQL_MCGL.id_client=label_client_id.Text.Substring(3);

                    //if (MySQL_MCGL.insert_Monay_Client())
                    //{
                    //    MessageBox.Show("Client Success");
                    //}

                    if (MCDL.insert_client(label_client_id.Text.Substring(3), textBox_client_name.Text, richTextBox_client_address.Text, textBox_client_mobile_number.Text))
                    {

                        MessageBox.Show("Inserted Successfully");
                        this.Close();
                    }
                    else
                    {
                        Common_Tasks.display_support();
                    }
                }

                MySQL_SMGL.new_date = label_current_date.Text;
                MySQL_SMGL.rate = textBox_rate.Text;
                MySQL_SMGL.inr = textBox_INR.Text;
                MySQL_SMGL.aed = textBox_AED.Text;
                MySQL_SMGL.total_aed = textBox_total_AED.Text;
                MySQL_SMGL.benefit = textBox_benefit.Text;
                MySQL_SMGL.advance1 = textBox_adv1.Text;
                MySQL_SMGL.advance2 = textBox_adv2.Text;
                MySQL_SMGL.advance3 = textBox_adv3.Text;
                MySQL_SMGL.advance1_date = label_advance_1_date.Text;
                MySQL_SMGL.advance2_date = label_advance_2_date.Text;
                MySQL_SMGL.advance3_date = label_advance_3_date.Text;
                MySQL_SMGL.balance = textBox_balance.Text;
                //MessageBox.Show(label_client_id.Text);
                MySQL_SMGL.id_client = label_client_id.Text.Substring(label_client_id.Text.IndexOf(" ")+1);

                if (MySQL_SMGL.insert_Send_Money())
                {
                    MessageBox.Show("Send Money Success");
                }
            }
            
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_INR.Text.Equals("") && !textBox_rate.Text.Equals(""))
            {
                balance_flag = 0;

                textBox_AED.Text = Math.Round(Convert.ToDouble(textBox_INR.Text) / Convert.ToDouble(textBox_rate.Text),2).ToString();
                textBox_benefit.Text = Math.Round((Convert.ToDouble(textBox_AED.Text) * 0.2),2).ToString();
                textBox_total_AED.Text = Math.Round(Convert.ToDouble(textBox_AED.Text) + Convert.ToDouble(textBox_benefit.Text),2).ToString();

                textBox_adv1.Text = Math.Round(Convert.ToDouble(textBox_total_AED.Text) / 3,2).ToString();
                textBox_adv2.Text = textBox_adv1.Text;
                textBox_adv3.Text = textBox_adv1.Text;

                label_advance_1_date.Text = DateTime.Now.ToLongDateString();
                label_advance_2_date.Text = DateTime.Now.AddMonths(1).ToLongDateString();
                label_advance_3_date.Text = DateTime.Now.AddMonths(2).ToLongDateString();

                textBox_balance.Text = Math.Round(Convert.ToDouble(textBox_total_AED.Text) - (Convert.ToDouble(textBox_adv1.Text) + Convert.ToDouble(textBox_adv2.Text) + Convert.ToDouble(textBox_adv3.Text)),2).ToString();

                balance_flag = 1;
            }
        }

        private void textBox_adv1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_adv1.Text.Equals(""))
            {
                textBox_adv1.Text = "0";
            }
            if (textBox_adv2.Text.Equals(""))
            {
                textBox_adv2.Text = "0";
            }
            if (textBox_adv3.Text.Equals(""))
            {
                textBox_adv3.Text = "0";
            }

            if (balance_flag == 1)
            {
                textBox_balance.Text = Math.Round(Convert.ToDouble(textBox_total_AED.Text) - (Convert.ToDouble(textBox_adv1.Text) + Convert.ToDouble(textBox_adv2.Text) + Convert.ToDouble(textBox_adv3.Text)),2).ToString();
            }
        }

        private void textBox_benefit_TextChanged(object sender, EventArgs e)
        {
            if (balance_flag == 1)
            {
                textBox_total_AED.Text = Math.Round(Convert.ToDouble(textBox_AED.Text) + Convert.ToDouble(textBox_benefit.Text),2).ToString();
                textBox_adv1.Text = Math.Round(Convert.ToDouble(textBox_total_AED.Text) / 3,2).ToString();
                textBox_adv2.Text = textBox_adv1.Text;
                textBox_adv3.Text = textBox_adv1.Text;
            }
        }





        public int update_flag = 0;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL.Client.Money_Client;
using Travel_Agency_Soution.Codes.MySQL.Travels;
using Common_Programming_Tasks;

namespace Travel_Agency_Soution.Forms
{
    public partial class Ticket_Isuue_One_Way : Form
    {
        MySQL_Money_Client_GL MySQL_MCGL = new MySQL_Money_Client_GL();
        MySQL_Money_Client_DL MySQL_MCDL = new MySQL_Money_Client_DL();

        DataTable Data_Table = new DataTable();

        MySQL_Ticket_One_GL MySQL_TOGL = new MySQL_Ticket_One_GL();

        public Ticket_Isuue_One_Way()
        {

           

            InitializeComponent();
            panel_client_details.Hide();
            panel_send_money_details.Hide();

            label_current_date.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
      

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

            //panel_one_way_ticket_direct_details.Hide();
            panel_one_way_ticket_indirect_details.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_new_connection.SelectedItem.ToString().Equals("Direct"))
            {
                //panel_one_way_ticket_direct_details.Show();
                panel_one_way_ticket_indirect_details.Hide();
             
            }
            else if (comboBox_new_connection.SelectedItem.ToString().Equals("Indirect"))
            {
                //panel_one_way_ticket_direct_details.Hide();
                panel_one_way_ticket_indirect_details.Show();

            }
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
MySQL_TOGL.airline = textBox_airline.Text;

MySQL_TOGL.new_connection = comboBox_new_connection.SelectedItem.ToString();
MySQL_TOGL.date_time = dateTimePicker_date.Value.ToLongDateString()+" "+textBox_time.Text;
MySQL_TOGL.new_from = textBox_new_from.Text;
MySQL_TOGL.new_to = textBox_new_to.Text;
MySQL_TOGL.new_class = textBox_class.Text;
MySQL_TOGL.pnr = textBox_pnr.Text;
MySQL_TOGL.issue = textBox_issue.Text;
MySQL_TOGL.amount = textBox_amount.Text;
MySQL_TOGL.commision = textBox_commision.Text;
MySQL_TOGL.total = textBox_total.Text;
MySQL_TOGL.new_date = label_current_date.Text;
MySQL_TOGL.id_client= label_client_id.Text.Substring(3);
if (MySQL_TOGL.insert_Ticket_one())
{
MessageBox.Show("Ticket Success");
}
        }
    }
}

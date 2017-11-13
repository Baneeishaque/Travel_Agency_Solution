using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using Travel_Agency_Soution.Codes.MySQL.Client.Money_Client;
using Al_Rayan_Travel_Agency.Codes.MySQL;
using Common_Programming_Tasks;
using Al_Rayan_Travel_Agency.Forms.Money_Exchange;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Money_Client_Addition : Form
    {
      
        MySQL_Money_Clients_DL MCDL = new MySQL_Money_Clients_DL();

        ErrorProvider e = new ErrorProvider();

        private int update_flag=0;
       
        public Money_Client_Addition()
        {
            InitializeComponent();

            //Data_Table = MySQL_MCDL.Return_Money_Client_Table(3, "0");
            //label_client_id.Text = "TR " + (Convert.ToInt64(MCDL.return_last_client_id().Rows[0][0].ToString()) + 1).ToString();

            label_client_id.Text = Common_Tasks.return_next_id_with_prefix(MCDL.return_last_client_id(), 1000, Money_Exchange_Common.prefix);
         
            
        }

        public Money_Client_Addition(string no, string name, string address, string mobile_number)
        {
           
            InitializeComponent();

            this.Text = "Money Client Updation";

          
            label_client_id.Text =no;
            textBox_client_name.Text = name;
            richTextBox_client_address.Text = address;
            textBox_client_mobile_number.Text = mobile_number;

            update_flag = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (update_flag == 0)
                {
                    //MessageBox.Show(label_client_id.Text.Substring(3));
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
                else
                {
                    if(MCDL.update_client(label_client_id.Text.Substring(3), textBox_client_name.Text, richTextBox_client_address.Text, textBox_client_mobile_number.Text))
                    {

                        MessageBox.Show("Updated Successfully");
                        this.Close();
                    }
                    else
                    {
                        Common_Tasks.display_support();
                    }
                }
            }
            
        }


        private bool Validation()
        {

            e.Dispose();

            bool ret = (isempty(textBox_client_name, "Enter Client Name")) && (isempty(richTextBox_client_address, "Enter Client Address")) && (isempty(textBox_client_mobile_number, "Enter Client Mobile Number"));
            
            return ret;
        }

        private bool isempty(RichTextBox c, string text)
        {
            bool ret = true;

            if (c.Text.Equals(""))
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }


        bool isempty(System.Windows.Forms.TextBox c, String text)
        {
            
            bool ret = true;

            if (c.Text.Equals(""))
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        bool isselected(System.Windows.Forms.ComboBox c, String text)
        {
           
            bool ret = true;

            if (c.SelectedIndex == 0)
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        bool iscorrect(System.Windows.Forms.TextBox c, String text)
        {
            
            bool ret = true;
            try
            {
               
                Decimal i=Convert.ToDecimal(c.Text);
                if (i == 0)
                {
                    e.SetError(c, text);
                    c.Focus();
                    ret = false;
                }
            }
            catch (FormatException ex)
            {
                
                e.SetError(c, text);
                c.Focus();
                ret = false;
            }

            return ret;
        }

       

       

        
    }
}

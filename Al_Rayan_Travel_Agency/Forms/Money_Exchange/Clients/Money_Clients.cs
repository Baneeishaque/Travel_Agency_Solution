using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using Al_Rayan_Travel_Agency.Codes.MySQL;
using Common_Programming_Tasks;
using Al_Rayan_Travel_Agency.Forms.Money_Exchange;


namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Money_Clients : Form
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();

        MySQL_Money_Clients_DL MCDL = new MySQL_Money_Clients_DL();
        
        public Money_Clients()
        {
            InitializeComponent();
            //dataGridView6.DataSource = MCDL.return_clients("");
            Common_Tasks.data_table_to_data_grid_view_with_custom_prefix(dataGridView6, MCDL.return_clients(), 0, Money_Exchange_Common.prefix);
            groupBox1.Hide();
            
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            new Money_Client_Addition().ShowDialog();
            //dataGridView6.DataSource = MCDL.return_clients("");
            Common_Tasks.data_table_to_data_grid_view_with_custom_prefix(dataGridView6, MCDL.return_clients(), 0, Money_Exchange_Common.prefix);
            groupBox1.Hide();
            
        }

        
       
        private void dataGridView6_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Client ID : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString();

            //dt = new DataTable();
            //dt = MCDL.return_client(dataGridView6.SelectedRows[0].Cells[0].Value.ToString());

            lb_fc.Text = "Name : " + dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
            lb_address.Text = "Address : " + dataGridView6.SelectedRows[0].Cells[2].Value.ToString();
            lb_sc.Text = "Mobile No. : " + dataGridView6.SelectedRows[0].Cells[3].Value.ToString();

           

            groupBox1.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to delete Client ID : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "", "Confirmation", MessageBoxButtons.YesNo).ToString().Equals("Yes")))
            {
                try
                {
                    if (MCDL.delete_client(dataGridView6.SelectedRows[0].Cells[0].Value.ToString().Substring(3)))
                    {


                        MessageBox.Show("Client ID : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + " Deleted SuccessFully", "Information");
                        //dataGridView6.DataSource = MCDL.return_clients();
                        Common_Tasks.data_table_to_data_grid_view_with_custom_prefix(dataGridView6, MCDL.return_clients(), 0, Money_Exchange_Common.prefix);
                        groupBox1.Hide();
                    }
                    else
                    {
                        Common_Tasks.display_support();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again\nReason : " + ex.Message + "", "Information");
                }
            }
        }

       

       

        

       
        private void button1_Click(object sender, EventArgs e)
        {


            new Money_Client_Addition(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString()).ShowDialog(); ;

            //dataGridView6.DataSource = MCDL.return_clients();
            Common_Tasks.data_table_to_data_grid_view_with_custom_prefix(dataGridView6, MCDL.return_clients(), 0, Money_Exchange_Common.prefix);
           
            groupBox1.Hide();
            
        }

        
    }
}

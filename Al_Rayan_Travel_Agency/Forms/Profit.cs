using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Profit : Form
    {
        MySQL_Collection_DL MySQL_CDL = new MySQL_Collection_DL();
        DataTable Data_Table = new DataTable();

        public double total_benefit { get; set; }

        public double total_amount { get; set; }

        public string[] columns { get; set; }

        public string[] columns2 { get; set; }

        public string[] columns3 { get; set; }

        public string[] columns4 { get; set; }


        public string[] rows { get; set; }

        public string[] rows2 { get; set; }

        public string[] rows3 { get; set; }

        public string[] rows4 { get; set; }


        public Profit()
        {
            InitializeComponent();
            Data_Table = MySQL_CDL.Return_Collection_Table(2);

            //MessageBox.Show(Data_Table.Rows[0][0].ToString());

            String[] rows = Data_Table.Rows[0][0].ToString().Split('-');

            for (int i = 1; i < rows.Length-1; i++)
            {
                //MessageBox.Show(rows[i]);
                columns = rows[i].Split('~');
                dataGridView6.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);
               
                for (int j = 0;j < columns.Length; j++)
                {
                    //MessageBox.Show(columns[j]);
                    
                }
            }
             total_benefit=total_benefit+Double.Parse(columns[5]);
                total_amount=total_amount+Double.Parse(columns[6]);

            Data_Table = new DataTable();
            Data_Table = MySQL_CDL.Return_Collection_Table(3);

            //MessageBox.Show(Data_Table.Rows[0][0].ToString());

            String[] rows2 = Data_Table.Rows[0][0].ToString().Split('-');

            for (int i = 1; i < rows2.Length-1 ; i++)
            {
                //MessageBox.Show(rows2[i]);
                columns2 = rows2[i].Split('~');
                dataGridView6.Rows.Add(columns2[0], columns2[1], columns2[2], columns2[3], columns2[4]);
                for (int j = 0; j < columns.Length; j++)
                {
                    //MessageBox.Show(columns2[j]);
                    
                }
            }
            total_benefit=total_benefit+Double.Parse(columns2[5]);
                total_amount=total_amount+Double.Parse(columns2[6]);

                Data_Table = new DataTable();
                Data_Table = MySQL_CDL.Return_Collection_Table(4);

                //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                String[] rows3 = Data_Table.Rows[0][0].ToString().Split('-');

                for (int i = 1; i < rows3.Length - 1; i++)
                {
                    //MessageBox.Show(rows3[i]);
                    columns3 = rows3[i].Split('~');
                    dataGridView6.Rows.Add(columns3[0], columns3[1], columns3[2], columns3[3], columns3[4]);
                    for (int j = 0; j < columns.Length; j++)
                    {
                        //MessageBox.Show(columns3[j]);

                    }
                }
                total_benefit = total_benefit + Double.Parse(columns3[5]);
                total_amount = total_amount + Double.Parse(columns3[6]);

                Data_Table = new DataTable();
                Data_Table = MySQL_CDL.Return_Collection_Table(5);

                //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                String[] rows4 = Data_Table.Rows[0][0].ToString().Split('-');

                for (int i = 1; i < rows4.Length - 1; i++)
                {
                    //MessageBox.Show(rows4[i]);
                    columns4 = rows4[i].Split('~');
                    dataGridView6.Rows.Add(columns4[0], columns4[1], columns4[2], columns4[3], columns4[4]);
                    for (int j = 0; j < columns.Length; j++)
                    {
                        //MessageBox.Show(columns3[j]);

                    }
                }
                total_benefit = total_benefit + Double.Parse(columns4[5]);
                total_amount = total_amount + Double.Parse(columns4[6]);

                dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);



              
            
        }


        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] columns=new String[5];

            string[] columns2=new String[5];

            string[] columns3 = new String[5];

            string[] columns4 = new String[5];


            string[] rows;

            string[] rows2;

            string[] rows3;

            string[] rows4;

            total_benefit = 0;
            total_amount = 0;

            

            while (dataGridView6.Rows.Count != 0)
            {

                dataGridView6.Rows.RemoveAt(0);
            }

            switch (comboBox_filter.SelectedItem.ToString())
            {
                case "All": Data_Table = MySQL_CDL.Return_Collection_Table(2);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());

                    rows = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows.Length - 1; i++)
                    {
                        //MessageBox.Show(rows[i]);
                        columns = rows[i].Split('~');
                        dataGridView6.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);

                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns[5]);
                    total_amount = total_amount + Double.Parse(columns[6]);

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(3);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());

                    rows2 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows2.Length - 1; i++)
                    {
                        //MessageBox.Show(rows2[i]);
                        columns2 = rows2[i].Split('~');
                        dataGridView6.Rows.Add(columns2[0], columns2[1], columns2[2], columns2[3], columns2[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns2[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns2[5]);
                    total_amount = total_amount + Double.Parse(columns2[6]);

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(4);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                    rows3 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows3.Length - 1; i++)
                    {
                        //MessageBox.Show(rows3[i]);
                        columns3 = rows3[i].Split('~');
                        dataGridView6.Rows.Add(columns3[0], columns3[1], columns3[2], columns3[3], columns3[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns3[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns3[5]);
                    total_amount = total_amount + Double.Parse(columns3[6]);

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(5);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                    rows4 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows4.Length - 1; i++)
                    {
                        //MessageBox.Show(rows4[i]);
                        columns4 = rows4[i].Split('~');
                        dataGridView6.Rows.Add(columns4[0], columns4[1], columns4[2], columns4[3], columns4[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns3[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns4[5]);
                    total_amount = total_amount + Double.Parse(columns4[6]);

                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;

                case "Money Exchange": Data_Table = MySQL_CDL.Return_Collection_Table(2);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());

                    rows = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows.Length - 1; i++)
                    {
                        //MessageBox.Show(rows[i]);
                        columns = rows[i].Split('~');
                        dataGridView6.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);

                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns[5]);
                    total_amount = total_amount + Double.Parse(columns[6]);

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(3);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());

                    rows2 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows2.Length - 1; i++)
                    {
                        //MessageBox.Show(rows2[i]);
                        columns2 = rows2[i].Split('~');
                        dataGridView6.Rows.Add(columns2[0], columns2[1], columns2[2], columns2[3], columns2[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns2[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns2[5]);
                    total_amount = total_amount + Double.Parse(columns2[6]);

                    

                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;

                case "Money Exchange : Send Money": Data_Table = MySQL_CDL.Return_Collection_Table(2);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());

                    rows = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows.Length - 1; i++)
                    {
                        //MessageBox.Show(rows[i]);
                        columns = rows[i].Split('~');
                        dataGridView6.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);

                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns[5]);
                    total_amount = total_amount + Double.Parse(columns[6]);

                    
                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;

                case "Money Exchange : Receive Money": 

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(3);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());

                    rows2 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows2.Length - 1; i++)
                    {
                        //MessageBox.Show(rows2[i]);
                        columns2 = rows2[i].Split('~');
                        dataGridView6.Rows.Add(columns2[0], columns2[1], columns2[2], columns2[3], columns2[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns2[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns2[5]);
                    total_amount = total_amount + Double.Parse(columns2[6]);

                    

                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;
                case "Travels": Data_Table = 

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(4);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                    rows3 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows3.Length - 1; i++)
                    {
                        //MessageBox.Show(rows3[i]);
                        columns3 = rows3[i].Split('~');
                        dataGridView6.Rows.Add(columns3[0], columns3[1], columns3[2], columns3[3], columns3[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns3[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns3[5]);
                    total_amount = total_amount + Double.Parse(columns3[6]);

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(5);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                    rows4 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows4.Length - 1; i++)
                    {
                        //MessageBox.Show(rows4[i]);
                        columns4 = rows4[i].Split('~');
                        dataGridView6.Rows.Add(columns4[0], columns4[1], columns4[2], columns4[3], columns4[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns3[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns4[5]);
                    total_amount = total_amount + Double.Parse(columns4[6]);

                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;
                case "Travels : Visa": 

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(5);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                    rows4 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows4.Length - 1; i++)
                    {
                        //MessageBox.Show(rows4[i]);
                        columns4 = rows4[i].Split('~');
                        dataGridView6.Rows.Add(columns4[0], columns4[1], columns4[2], columns4[3], columns4[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns3[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns4[5]);
                    total_amount = total_amount + Double.Parse(columns4[6]);

                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;
                case "Travels : Ticket": 

                    Data_Table = new DataTable();
                    Data_Table = MySQL_CDL.Return_Collection_Table(4);

                    //MessageBox.Show(Data_Table.Rows[0][0].ToString());
                    rows3 = Data_Table.Rows[0][0].ToString().Split('-');

                    for (int i = 1; i < rows3.Length - 1; i++)
                    {
                        //MessageBox.Show(rows3[i]);
                        columns3 = rows3[i].Split('~');
                        dataGridView6.Rows.Add(columns3[0], columns3[1], columns3[2], columns3[3], columns3[4]);
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //MessageBox.Show(columns3[j]);

                        }
                    }
                    total_benefit = total_benefit + Double.Parse(columns3[5]);
                    total_amount = total_amount + Double.Parse(columns3[6]);

                   

                    dataGridView6.Rows.Add("", "", "Total", total_benefit, total_amount);
                    break;
            }
        }


        
    }
}

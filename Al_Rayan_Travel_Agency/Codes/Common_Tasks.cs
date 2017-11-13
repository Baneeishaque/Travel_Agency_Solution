using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Common_Programming_Tasks
{
    class Common_Tasks
    {
        
     

        internal static void nullify(System.Windows.Forms.Control[] c)
        {
        
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Text = "";
            }
        }

        internal static void readOnly(System.Windows.Forms.TextBox[] c)
        {

            for (int i = 0; i < c.Length; i++)
            {
                c[i].ReadOnly = true;
            }
        }



        internal static void disable(System.Windows.Forms.Control c)
        {
            c.Enabled = false;
            
        }


        internal static void disable(System.Windows.Forms.Control[] c)
        {
            
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Enabled = false;
            }

        }

        internal static void populate_zero(System.Windows.Forms.Control[] c)
        {

            for (int i = 0; i < c.Length; i++)
            {
                c[i].Text = "0";
            }

        }


        internal static bool isempty(System.Windows.Forms.TextBox c,String text)
        {
            ErrorProvider e = new ErrorProvider();
            bool ret = true;
            
            if (c.Text.Equals(""))
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        internal static bool isselected(System.Windows.Forms.ComboBox c, String text)
        {
            ErrorProvider e = new ErrorProvider();
            bool ret = true;
            
            if (c.SelectedIndex==0)
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        internal static bool iscorrect(System.Windows.Forms.TextBox c, String text)
        {
            ErrorProvider e = new ErrorProvider();
            bool ret = true;
            try
            {
                int i = Convert.ToInt32(c.Text);
            }
            catch (FormatException ex)
            {
                
                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            
            return ret;
        }


        internal static void display_support()
        {
            MessageBox.Show("Contact support");

        }



        internal static void hide(Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Hide();
            }

        }

        internal static void show(Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Show();
            }
        }

        internal static bool return_and_assign_next_id_with_prefix(string prefix, DataTable dt, Label l, int initial)
        {
            
            bool result = false;
            if (!dt.Rows[0][0].ToString().Equals(""))
            {
                l.Text = prefix + " " + (Convert.ToInt64(dt.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                l.Text = prefix + " " + initial.ToString();
                result = true;
                
            }
            return result;

        }

        internal static void populate_form(Control[] c, DataTable dt)
        {
            //for(int i=0;
        }

        internal static void bind_combo_with_id_with_prefix_and_field_after_clear(DataTable dt, ComboBox cb, int id_column, int field_column, string prefix)
        {
            cb.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(prefix +" " + dt.Rows[i][id_column].ToString() + " : " + dt.Rows[i][field_column].ToString());
            }
        }

        internal static void data_table_to_data_grid_view_with_custom_prefix(DataGridView dgv, DataTable dt,int prefix_column_number,string prefix)
        {
            while (dgv.Rows.Count != 0)
            {
                dgv.Rows.RemoveAt(0);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] dr = new string[dt.Columns.Count];
       
                for (int j = 0; j < dt.Columns .Count ; j++)
                {
                    if (j == prefix_column_number)
                    {
                        //row_data = string_concatination(row_data, prefix+" "+dt.Rows[i][j].ToString(), j, ",");
                        dr[j] = prefix + " " + dt.Rows[i][j].ToString();

                    }
                    else
                    {
                        //row_data = string_concatination(row_data, dt.Rows[i][j].ToString(), j, ",");
                        dr[j] =dt.Rows[i][j].ToString();
                    }
                    
                    
                }
                //for (int k = 0; k < dr.Length; k++)
                //{
                //    MessageBox.Show(dr[k]);
                //}
                dgv.Rows.Add(dr);
            }
        }

        internal static string string_concatination(string result, string to_concatinate, int index,string seperator)
        {
            if (index == 0)
            {
                result = result + to_concatinate;
            }
            else
            {
                result = result + seperator + to_concatinate;
            }
            //MessageBox.Show(result);
            return result;
        }

        internal static long return_next_id(DataTable dt,int initial_value)
        {
            if (dt.Rows[0][0].ToString().Equals(""))
            {
                return initial_value;
            }
            else
            {
                return Convert.ToInt64(dt.Rows[0][0].ToString()) + 1;
            }
        }

        internal static string return_next_id_with_prefix(DataTable dt, int initial_value, string prefix)
        {
            if (dt.Rows[0][0].ToString().Equals(""))
            {
                return prefix+" "+initial_value;
            }
            else
            {
                return prefix + " " + (Convert.ToInt64(dt.Rows[0][0].ToString()) + 1);
            }
        }


        internal static void hide(Control  c)
        {
            c.Hide();
        }

        internal static string return_current_date_time()
        {
            return DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        
    }
}

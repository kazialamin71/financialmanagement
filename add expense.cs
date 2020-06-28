using financialManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financialManagement
{
    public partial class add_expense : Form
    {
        int total;
        payer p = new payer();
        public add_expense()
        {
            InitializeComponent();
            
            DataSet dt = p.selectpayer();
            Console.WriteLine(dt.GetType());

            cmp_payer.DisplayMember = "name";
            cmp_payer.ValueMember = "payeerid";
            cmp_payer.DataSource = dt.Tables[0];

            //foreach (DataRow dr in dt.Rows) 
            //{
            //   cmp_payer.Items.Add(dr["name"]);
            //}
            //here 


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adds_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();
                dt.Columns.Add("name");
                dt.Columns.Add("mode");
                dt.Columns.Add("description");
                dt.Columns.Add("amount");
                dt.Columns.Add("date");
                dt.Columns.Add("inout");

            DataRow row = dt.NewRow();
                row["name"] =cmp_payer.SelectedValue;
                row["mode"] = txt_mode.Text;
                row["description"] = txt_desc.Text;
                row["amount"] = txt_amount.Text;
                row["date"] = dateTimePicker1.Text;
                row["inout"] = "out";
            dt.Rows.Add(row);
            int amount = int.Parse(txt_amount.Text);
            total = total + amount;
            textBox1.Text = total.ToString();
                foreach (DataRow drow in dt.Rows)
                {
                    int num = grid_expense.Rows.Add();
                grid_expense.Rows[num].Cells[0].Value = drow["name"].ToString();
                grid_expense.Rows[num].Cells[1].Value = drow["mode"].ToString();
                grid_expense.Rows[num].Cells[2].Value = drow["description"].ToString();
                grid_expense.Rows[num].Cells[3].Value = drow["amount"].ToString();
                grid_expense.Rows[num].Cells[4].Value = drow["date"].ToString();
                grid_expense.Rows[num].Cells[5].Value = drow["inout"].ToString();
                
            }
                
            
        }
    }
}

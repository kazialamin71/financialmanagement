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
    public partial class Add_payerpayee : Form
    {
        public Add_payerpayee()
        {
            InitializeComponent();

        }
        payer p = new payer();
        private void button1_Click(object sender, EventArgs e)
        {
            p.payername = txt_name.Text;
            p.contact = txt_contact.Text;
            p.frequent = txt_frequent.Text;
            p.type = cmb_type.Text;

            bool success=p.insert(p);
            if (success == true)
            {
                MessageBox.Show("successfully inserted data");
            }
            else
            {
                MessageBox.Show("Try again");
            }
        }
    }
}

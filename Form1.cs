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
    public partial class form_welcome : Form
    {
        public form_welcome()
        {
            InitializeComponent();
        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            add_expense income = new add_expense();
            income.Show();
            this.Hide();
        }

        private void btn_payer_Click(object sender, EventArgs e)
        {
            Add_payerpayee payerpayee = new Add_payerpayee();
            payerpayee.Show();
            this.Hide();
        }
    }
}

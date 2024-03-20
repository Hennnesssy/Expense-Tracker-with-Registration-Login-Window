using Program_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class FrmAdd : Form
    {
        public Expense Expense { get; set; }
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(txtPrice.Text);
            string category = txtCategory.Text;
            string description = txtDescription.Text;
            DateTime date = DateTime.Now;

            Expense expense = new Expense(category, description, price, date);

            this.Close();
        }
    }
}

using ExpenseTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//delete //delete222gasdasd
//sadasas
//test 3
namespace Program_1
{

    //string path = @"D:\Program Files";
    public partial class frmMain : Form
    {
        public List<Expense> Expenses { get; set; }
        public frmMain()
        {
            InitializeComponent();
            Expenses = new List<Expense>();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        private void bnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            if (Application.OpenForms["FrmAdd"] == null)
            { 
                frmAdd.Show();
            }
            if (frmAdd.Expense != null)
            {
                Expenses.Add(frmAdd.Expense);
                
                expenseBox.Items.Add(frmAdd.Expense);
            }
        }

    }
}

/*panel1.MouseEnter += (s, a) => 
            {
                while (panel1.Location.Y != panel1.Location.))
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 1);
            };*/

/*
 Label colors = new Label();
            colors.Text = "test \"=>\"";
            colors.ForeColor = Color.Black;
            colors.Location = new Point(64, 64);
            this.Controls.Add(colors);
            colors.Click += async (s, a) =>
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;
                for (r = 0; r < 255; r += 10)
                {
                    this.BackColor = Color.FromArgb(r, 0, 0);
                    await Task.Delay(10);
                }

                this.BackColor = Color.FromArgb(255, 0, 0);
                await Task.Delay(100);

                for (g = 0; g < 255; g += 10)
                {
                    this.BackColor = Color.FromArgb(255, g, 0);
                    await Task.Delay(10);
                }

                this.BackColor = Color.FromArgb(255, 255, 0);
                await Task.Delay(10);

                for (b = 0; b < 255; b += 10)
                {
                    this.BackColor = Color.FromArgb(255, 255, b);
                    await Task.Delay(100);
                }

                this.BackColor = Color.FromArgb(255, 255, 255);
            };
 */
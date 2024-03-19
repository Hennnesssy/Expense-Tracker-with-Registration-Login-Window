using ExpenseTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            /*panel1.MouseEnter += (s, a) => 
            {
                while (panel1.Location.Y != panel1.Location.))
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 1);
            };*/
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
        }
        private void bnAdd_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAdd"] == null)
            {
                new FrmAdd().Show();
            }
        }
    }
}
/*
byte r = 0;
byte g = 0;
byte b = 0;
for (r = 0; r <= 255; r++)
{
    this.BackColor = Color.FromArgb(r, g, b);
}

this.BackColor = Color.FromArgb(255, g, b);
await Task.Delay(100);

for (g = 0; g <= 255; g++)
{
    this.BackColor = Color.FromArgb(r, g, b);
}

this.BackColor = Color.FromArgb(r, 255, b);
await Task.Delay(100);

for (b = 0; b <= 255; b++)
{
    this.BackColor = Color.FromArgb(r, g, b);
}

this.BackColor = Color.FromArgb(r, g, 250);
*/
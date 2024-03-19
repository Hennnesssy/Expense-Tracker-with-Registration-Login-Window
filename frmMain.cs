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
        List<string> newList = new List<string>();
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
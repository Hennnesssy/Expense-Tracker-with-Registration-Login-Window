using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        DateBase db = new DateBase();
        public frmLogin()
        {
            InitializeComponent();

            txtLinkRegister.Click += async (s, a) =>
            {
                this.Hide();
                await Task.Delay(60);
                frmRegister frmLogin = new frmRegister();
                frmLogin.Show();
            };
        }

        private void LoginWin_Load(object sender, EventArgs e)
        {
            
        }

        private void bnLogin_Click(object sender, EventArgs e)
        {
            db.openConnection();
            string login = "SELECT * FROM users WHERE login= '" + txtBxUsername.Text +
                "' and pass= '" + txtBxPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(login, db.getConnection());
            cmd.Parameters.AddWithValue("@login", txtBxUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtBxPassword.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                this.Hide();
                new frmMain().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxUsername.Text = "";
                txtBxPassword.Text = "";
                txtBxUsername.Focus();
            }
            reader.Close();
            db.closeConnection();
        }
        private void checkBxShPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShPassw.Checked)
                checkBxShPassw.Text = "Hide password";
            else
                checkBxShPassw.Text = "Show password";

            if (checkBxShPassw.Checked)
            {
                txtBxPassword.PasswordChar = '\0';
            }
            else
            {
                txtBxPassword.PasswordChar = '*';
            }
        }

        private void txtBxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtBxPassword.Focus(); }
        }
        //asdasdadaddas
        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { e.SuppressKeyPress= true; bnLogin_Click(bnLogin, null); }
        }
    }
}
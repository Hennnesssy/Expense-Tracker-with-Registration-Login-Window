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
    public partial class frmRegister : Form
    {
        DateBase db = new DateBase();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            txtLinkLogin.Click += async (s, a) => 
            { 
                this.Hide();
                await Task.Delay(50);
                frmLogin loginWin = new frmLogin();
                loginWin.Show();
                
            };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bnRegister_Click(object sender, EventArgs e)
        {
            if (txtBxUsername.Text == "" && txtBxPassword.Text == "" && txtBxConfPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtBxUsername.Text))
            {
                MessageBox.Show("Username field is empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBxPassword.Text == txtBxConfPassword.Text & !string.IsNullOrWhiteSpace(txtBxUsername.Text))
            {
                if(RegexValidator.isValidatoinPassword(txtBxPassword.Text)){
                    try
                    {
                        db.openConnection();
                        string registerUser = "INSERT INTO users (login, pass) VALUES (@login, @pass)";
                        MySqlCommand cmd = new MySqlCommand(registerUser, db.getConnection());
                        cmd.Parameters.AddWithValue("login", txtBxUsername.Text);
                        cmd.Parameters.AddWithValue("pass", txtBxPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered is succsessfully", "succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        frmLogin loginWin = new frmLogin();
                        loginWin.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when adding a user" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.closeConnection();
                }
                else
                    MessageBox.Show("password must contain 1 uppercase letter, 1 lowercase letter, 1 special character, minimum length 8 characters",
                        "Validation password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtBxConfPassword != txtBxPassword)
            {
                MessageBox.Show("Password does not match, please re-enter", "Registration Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtBxPassword.Text = "";
                txtBxConfPassword.Text = "";
                txtBxPassword.Focus();
            }

            txtBxUsername.Text = "";
            txtBxPassword.Text = "";
            txtBxConfPassword.Text = "";
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
                txtBxConfPassword.PasswordChar = '\0';
            }
            else
            {
                txtBxPassword.PasswordChar = '*';
                txtBxConfPassword.PasswordChar = '*';
            }
        }

        private void txtBxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtBxPassword.Focus(); }
        }

        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtBxConfPassword.Focus(); }
        }

        private void txtBxConfPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; bnRegister_Click(bnRegister, null); }
        }
    }
}
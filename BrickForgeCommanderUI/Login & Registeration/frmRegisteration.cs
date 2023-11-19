using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Login___Registeration
{
    public partial class frmRegisteration : Form
    {
        public frmRegisteration()
        {
            InitializeComponent();
        }

        private void frmRegisteration_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConPassword.PasswordChar = '*';
            }
        }

        private void btbRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True");
            if (txtUserName.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("Please enter User Name and Password", "Registeration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                try
                {
                    con.Open();
                    string register = "INSERT INTO kanif.Login_Credentials (UserName , Password) VALUES (@UserName,@Password)";
                    SqlCommand command = new SqlCommand(register, con);
                    command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    command.ExecuteNonQuery();
                    con.Close();

                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Successful", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUserName.Focus();
        }

        private void lblBackToLogIN_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConPassword.Focus();
            }
        }

        private void txtConPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btbRegister.Focus();
            }
        }
    }
}

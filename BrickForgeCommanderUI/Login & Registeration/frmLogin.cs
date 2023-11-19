using BrickForgeCommanderUI.Dashboard;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        

        private void btbLogin_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string login = "SELECT * FROM kanif.Login_Credentials WHERE UserName = '" + txtUserName.Text + "'AND Password = '" + txtPassword.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    new frmDashBoard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again!!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new frmRegisteration().Show();
            this.Hide();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btbLogin.Focus();
            }
        }
    }
}

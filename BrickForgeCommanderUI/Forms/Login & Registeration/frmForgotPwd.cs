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
    public partial class frmForgotPwd : Form
    {
        private const int InitialHeight = 400;
        private const int AnimationSpeed = 2;

        private bool isExpanded = false;

        public frmForgotPwd()
        {
            InitializeComponent();
            this.ControlBox = false;

            this.KeyDown += new KeyEventHandler(frmForgotPwd_KeyDown);
            txtUserName.KeyDown += txtUserName_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtConfirmPwd.KeyDown += txtConfirmPwd_KeyDown;
        }

        private void frmForgotPwd_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void CheckbxShowKey_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowKey.Checked)
            {
                txtKey.PasswordChar = '\0';
            }
            else
            {
                txtKey.PasswordChar = '*';
            }
        }

        private void cbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPwd.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPwd.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPwd.PasswordChar = '*';
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string login = "SELECT * FROM BFC.Login_Credentials WHERE UserName = '" + txtUserName.Text + "'AND Password = '" + txtPassword.Text + "'";
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string checkUserAndKey = "SELECT * FROM BFC.Login_Credentials WHERE UserName = @UserName AND AuthenticationKey = @AuthenticationKey";
                cmd = new SqlCommand(checkUserAndKey, con);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@AuthenticationKey", txtKey.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Smooth transition effect
                    Timer timer = new Timer();
                    timer.Interval = AnimationSpeed;
                    timer.Tick += (s, args) =>
                    {
                        if (isExpanded)
                        {
                            if (this.Height > InitialHeight)
                            {
                                this.Height -= AnimationSpeed;
                                if (this.Height <= InitialHeight)
                                {
                                    timer.Stop();
                                    ShowPasswordControls();
                                    isExpanded = false;
                                }
                            }
                        }
                        else
                        {
                            if (this.Height > InitialHeight)
                            {
                                this.Height -= AnimationSpeed;
                            }
                            else
                            {
                                timer.Stop();
                                HideUsernameKeyControls();
                                isExpanded = true;
                            }
                        }
                    };

                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Authentication Key, Please Try Again!!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtKey.Text = "";
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void HideUsernameKeyControls()
        {
            lblHead.Visible = false;
            lblUserName.Visible = false;
            lblKey.Visible = false;
            txtKey.Visible = false;
            txtUserName.Visible = false;
            CheckbxShowKey.Visible = false;
            btnSubmit.Visible = false;

            lblPassword.Location = lblHead.Location;
            txtPassword.Location = lblUserName.Location;
            lblConfirmPwd.Location = txtUserName.Location;
            txtConfirmPwd.Location = lblKey.Location;
            cbShowPwd.Location = txtKey.Location;
            btnResetPwd.Location = btnSubmit.Location;
        }

        private void ShowPasswordControls()
        {
            lblPassword.Visible = true;
            lblConfirmPwd.Visible = true;
            txtPassword.Visible = true;
            txtConfirmPwd.Visible = true;
            btnResetPwd.Visible = true;
            cbShowPwd.Visible = true;

            txtPassword.Text = "";
            txtConfirmPwd.Text = "";
            txtPassword.Focus();
        }

        private void btnResetPwd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPwd.Text))
                {
                    MessageBox.Show("Please enter both the current password and the new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                con.Open();

                string getOldPasswordQuery = "SELECT Password FROM BFC.Login_Credentials WHERE UserName = @UserName";
                cmd = new SqlCommand(getOldPasswordQuery, con);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);

                object existingPasswordObj = cmd.ExecuteScalar();

                if (existingPasswordObj != null)
                {
                    string existingPassword = existingPasswordObj.ToString();

                    if (txtPassword.Text == existingPassword)
                    {
                        MessageBox.Show("The new password cannot be the same as the old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updatePassword = "UPDATE BFC.Login_Credentials SET Password = @Password WHERE UserName = @UserName";
                    cmd = new SqlCommand(updatePassword, con);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        new frmLogin().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtKey.Focus();
            }
        }

        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtConfirmPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnResetPwd_Click(sender, e);
            }
        }

        private void frmForgotPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

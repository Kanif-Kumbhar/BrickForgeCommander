using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Login___Registeration
{
    public partial class frmRegisteration : Form
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True";

        public frmRegisteration()
        {
            InitializeComponent();
        }

        private void frmRegisteration_Load(object sender, EventArgs e)
        {
            LoadUserTypes();
            LoadCityName();
            txtName.Focus();
            this.KeyDown += frmRegisteration_KeyDown;

            LoadLastSavedUserId();
        }

        private void btbRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (ValidateFields())
                {
                    MessageBox.Show("Please fill in all fields", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == txtConPassword.Text)
                {
                    try
                    {
                        con.Open();

                        UserTypeItem selectedUserType = (UserTypeItem)dboxUserType.SelectedItem;

                        string register = "INSERT INTO kanif.Login_Credentials (UserName, Password, AuthenticationKey,VendorTypeID) VALUES (@UserName, @Password, @AuthenticationKey,@VendorTypeID)";
                        SqlCommand command = new SqlCommand(register, con);
                        command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@AuthenticationKey", txtKey.Text);
                        command.Parameters.AddWithValue("@VendorTypeID", selectedUserType.ID);
                        command.ExecuteNonQuery();

                        string insertVTD = "INSERT INTO YourOtherTable (Id, Name, Address, City, Phone, VendorTypeID) VALUES (@Id, @Name, @Address, @City, @Phone, @VendorTypeID)";
                        using (SqlCommand insertVTDCommand = new SqlCommand(insertVTD, con))
                        {
                            insertVTDCommand.Parameters.AddWithValue("@Id", txtId.Text);
                            insertVTDCommand.Parameters.AddWithValue("@Name", txtName.Text);
                            insertVTDCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                            insertVTDCommand.Parameters.AddWithValue("@City", dboxCity.SelectedItem.ToString());
                            insertVTDCommand.Parameters.AddWithValue("@Phone", txtPhoneNo.Text);
                            insertVTDCommand.Parameters.AddWithValue("@VendorTypeID", selectedUserType.ID);
                            insertVTDCommand.ExecuteNonQuery();
                        }

                        con.Close();

                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConPassword.Text = "";
                        dboxUserType.SelectedIndex = -1;

                        MessageBox.Show("Your Account has been Successfully Created", "Registration Successful", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
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
                btnRegister.Focus();
            }
        }

        #region Functions

        private void ClearData()
        {
            txtPhoneNo.Clear();
            txtKey.Clear();
            txtAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConPassword.Clear();

            txtName.Clear();
            txtName.Focus();
            dboxUserType.SelectedIndex = 0;
            dboxCity.SelectedIndex = 0;
        }

        private void LoadLastSavedUserId()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT TOP 1 UserId FROM kanif.Login_Credentials ORDER BY UserId DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int lastUserId = Convert.ToInt32(result);
                        txtId.Text = lastUserId.ToString();
                    }
                }
            }

            txtId.Enabled = false;
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

        private void LoadUserTypes()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT VenderTypeId, VenderTypeName FROM kanif.VendorTypeDetails WHERE VenderTypeName IN ('Admin', 'Manager')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["VenderTypeId"]);
                            string userType = reader["VenderTypeName"].ToString();
                            dboxUserType.Items.Add(new UserTypeItem(id, userType));
                        }
                    }
                }
            }
            if (dboxUserType.Items.Count > 0)
            {
                dboxUserType.SelectedIndex = 0;
            }
        }

        private void LoadCityName()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT CityId, CityName FROM kanif.CityDetails";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["CityId"]);
                            string cityName = reader["CityName"].ToString();
                            dboxCity.Items.Add(new CityNameItem(id, cityName));
                        }
                    }
                }
            }
            if (dboxCity.Items.Count > 0)
            {
                dboxCity.SelectedIndex = 0;
            }
        }


        private bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(txtUserName.Text) &&
                   ValidatePassword(txtPassword.Text) &&
                   dboxUserType.SelectedItem != null;
        }

        private bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).*$";
            return Regex.IsMatch(password, pattern);
        }

        #endregion

        private void frmRegisteration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnRegister.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Delete)
            {
                ClearData();
            }
        }
    }
    public class UserTypeItem
    {
        public int ID { get; }
        public string UserType { get; }

        public UserTypeItem(int id, string userType)
        {
            ID = id;
            UserType = userType;
        }

        public override string ToString()
        {
            return UserType;
        }
    }

    public class CityNameItem
    {
        public int ID { get; }
        public string CityName { get; }

        public CityNameItem(int id, string cityname)
        {
            ID = id;
            CityName = cityname;
        }

        public override string ToString()
        {
            return CityName;
        }
    }
}

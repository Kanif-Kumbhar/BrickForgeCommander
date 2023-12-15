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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

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

            txtName.KeyPress += EnterKeyPressHandler;
           // txtAddress.KeyPress += EnterKeyPressHandler;
            txtPhoneNo.KeyPress += EnterKeyPressHandler;
            txtUserName.KeyPress += EnterKeyPressHandler;
            txtKey.KeyPress += EnterKeyPressHandler;
            txtPassword.KeyPress += EnterKeyPressHandler;
            txtConfirmPassword.KeyPress += EnterKeyPressHandler;
            dboxCity.KeyPress += EnterKeyPressHandler;
            dboxUserType.KeyPress += EnterKeyPressHandler;
            dboxCity.KeyPress += EnterKeyPressHandler;
            dboxUserType.KeyPress += EnterKeyPressHandler;

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
                else if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    try
                    {
                        con.Open();

                        UserTypeItem selectedUserType = (UserTypeItem)dboxUserType.SelectedItem;

                        string register = "INSERT INTO kanif.Login_Credentials (UserName, Password, AuthenticationKey,VenderTypeID) VALUES (@UserName, @Password, @AuthenticationKey,@VenderTypeID)";
                        SqlCommand command = new SqlCommand(register, con);
                        command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@AuthenticationKey", txtKey.Text);
                        command.Parameters.AddWithValue("@VendorTypeID", selectedUserType.ID);
                        command.ExecuteNonQuery();

                        string insertVTD = "INSERT INTO YourOtherTable (Id, Name, Address, City, Phone, VenderTypeID) VALUES (@Id, @Name, @Address, @City, @Phone, @VenderTypeID)";
                        using (SqlCommand insertVTDCommand = new SqlCommand(insertVTD, con))
                        {
                            insertVTDCommand.Parameters.AddWithValue("@Id", txtId.Text);
                            insertVTDCommand.Parameters.AddWithValue("@Name", txtName.Text);
                            insertVTDCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                            insertVTDCommand.Parameters.AddWithValue("@City", dboxCity.SelectedItem.ToString());
                            insertVTDCommand.Parameters.AddWithValue("@Phone", txtPhoneNo.Text);
                            insertVTDCommand.Parameters.AddWithValue("@VenderTypeID", selectedUserType.ID);
                            insertVTDCommand.ExecuteNonQuery();
                        }

                        con.Close();


                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
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


             #region Functions

        private void ClearData()
        {
            txtPhoneNo.Clear();
            txtKey.Clear();
            txtAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            txtName.Clear();
            txtName.Focus();
            dboxUserType.SelectedIndex = 0;
            dboxCity.SelectedIndex = 0;
        }

        private void EnterKeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control nextControl = GetNextControl((Control)sender, true);

                if (nextControl != null)
                {
                    if (sender == dboxUserType)
                    {
                        txtUserName.Focus();
                    }
                    else if (sender == dboxCity)
                    {
                        txtAddress.Focus();
                    }
                    else
                    {
                        nextControl.Focus();
                    }

                    e.Handled = true;
                }
            }
            else if (e.KeyChar == (char)Keys.Down)
            {
                if (sender is ComboBox comboBox)
                {
                    int newIndex = (comboBox.SelectedIndex + 1) % comboBox.Items.Count;
                    comboBox.SelectedIndex = newIndex;
                }
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                if (sender is ComboBox comboBox)
                {
                    int newIndex = (comboBox.SelectedIndex - 1 + comboBox.Items.Count) % comboBox.Items.Count;
                    comboBox.SelectedIndex = newIndex;
                }
            }
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
                txtPassword.PasswordChar = false;
                txtConfirmPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
                txtConfirmPassword.PasswordChar = true;
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

             #region KeyEvents

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
                txtConfirmPassword.Focus();
            }
        }

        private void txtConPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.Focus();
            }
        }

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

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Right) 
            {
                dboxUserType.Focus();
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnRegister.PerformClick();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dboxCity.Focus();
            }
        }

        #endregion
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

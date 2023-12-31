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

            txtPhoneNo.KeyPress += EnterKeyPressHandler;
            txtUserName.KeyPress += EnterKeyPressHandler;
            txtKey.KeyPress += EnterKeyPressHandler;
            txtPassword.KeyPress += EnterKeyPressHandler;
            txtConfirmPassword.KeyPress += EnterKeyPressHandler;
            dboxCity.KeyPress += EnterKeyPressHandler;
            dboxUserType.KeyPress += EnterKeyPressHandler;
            dboxCity.KeyPress += EnterKeyPressHandler;
            dboxUserType.KeyPress += EnterKeyPressHandler;

            dboxCity.Items.Insert(0, "Select City");
            dboxCity.SelectedIndex = 0;

            dboxUserType.Items.Insert(0, "Select User Type");
            dboxUserType.SelectedIndex = 0;

            LoadLastSavedUserId();
        }

        private void btbRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (!ValidateFields())
                {
                    MessageBox.Show("Please fill in all fields", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    try
                    {
                        con.Open();

                        int nextUserId = GetNextUserId();
                        int nextVenderId = GetNextVenderId();

                        UserTypeItem selectedUserType = (UserTypeItem)dboxUserType.SelectedItem;

                        string register = "INSERT INTO kanif.Login_Credentials (UserId, UserName, Password, AuthenticationKey) VALUES (@UserId, @UserName, @Password, @AuthenticationKey)";
                        SqlCommand command = new SqlCommand(register, con);
                        command.Parameters.AddWithValue("@UserId", nextUserId);
                        command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@AuthenticationKey", txtKey.Text);
                        command.ExecuteNonQuery();

                        string insertVTD = "INSERT INTO kanif.VenderDetails (VenderId, FirstName, MiddleName, LastName, Address, CityId, PhoneNo, VenderTypeId,UserId) VALUES (@VenderId, @FirstName, @MiddleName, @LastName, @Address, @CityId, @PhoneNo, @VenderTypeId, @UserId)";
                        using (SqlCommand insertVTDCommand = new SqlCommand(insertVTD, con))
                        {
                            insertVTDCommand.Parameters.AddWithValue("@VenderId", nextVenderId);

                            string[] names = txtName.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            insertVTDCommand.Parameters.AddWithValue("@FirstName", names.Length > 0 ? names[0] : string.Empty);

                            if (names.Length > 1)
                            {
                                insertVTDCommand.Parameters.AddWithValue("@MiddleName", names[1]);
                            }
                            else
                            {
                                insertVTDCommand.Parameters.AddWithValue("@MiddleName", DBNull.Value);
                            }

                            if (names.Length > 2)
                            {
                                insertVTDCommand.Parameters.AddWithValue("@LastName", names[2]);
                            }
                            else
                            {
                                insertVTDCommand.Parameters.AddWithValue("@LastName", DBNull.Value);
                            }

                            insertVTDCommand.Parameters.AddWithValue("@Address", txtAddress.Text);

                            if (dboxCity.SelectedItem != null)
                            {
                                insertVTDCommand.Parameters.AddWithValue("@CityId", ((CityNameItem)dboxCity.SelectedItem).ID);
                            }
                            else
                            {
                                MessageBox.Show("Please select a city", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            insertVTDCommand.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text); // Fix parameter name

                            if (dboxUserType.SelectedItem != null)
                            {
                                insertVTDCommand.Parameters.AddWithValue("@VenderTypeId", selectedUserType.ID);
                                insertVTDCommand.Parameters.AddWithValue("@UserId", nextUserId);
                            }
                            else
                            {
                                MessageBox.Show("Please select a user type", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            insertVTDCommand.ExecuteNonQuery();
                        }

                        con.Close();

                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";

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


        private int GetNextUserId()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT ISNULL(MAX(UserId), 0) + 1 FROM kanif.Login_Credentials";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }

            return 1;
        }

        private void LoadLastSavedUserId()
        {
            int nextUserId = GetNextUserId();
            txtId.Text = nextUserId.ToString();
            txtId.Enabled = false;
        }

        private int GetNextVenderId()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT ISNULL(MAX(VenderId), 0) + 1 FROM kanif.VenderDetails";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }

            return 1;
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
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter an address", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please enter a phone number", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter a username", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm the password", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dboxCity.SelectedItem == null)
            {
                MessageBox.Show("Please select a city", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dboxUserType.SelectedItem == null)
            {
                MessageBox.Show("Please select a user type", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!ValidatePassword(txtPassword.Text))
            {
                MessageBox.Show("Please enter a valid password. It should contain at least one uppercase letter and one special character, and be at least 8 characters long.", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }


        private void HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627) 
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    
    public partial class login : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        public string txtuserexist, txtpassexist;
        MySqlDataReader dr;

        public login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login_user();
        }

        private void login_user()
        {
            usernameexist();
            mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);

            if (verifyMd5Hash(txtpassword.Text, txtpassexist))
            {
                this.Hide();
                /*MessageBox.Show("login Success");*/
                admindashboard fm = new admindashboard();
                fm.Show();

            }
            else
            {
                MessageBox.Show("Password is invalid", "GL");
                txtpassword.Focus();
            }
        }

        static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static bool verifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_Enter(object sender, EventArgs e)
        {
            login_user();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                login_user();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                login_user();
            }
        }

        private void usernameexist()
        {
            try
            {

                mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                mysqliconnection.Open();

                mycommand = new MySqlCommand("SELECT username, password FROM tbluser WHERE username='" + txtusername.Text.Trim() + "'", mysqliconnection);
                dr = mycommand.ExecuteReader();
                while (dr.Read())
                {
                    txtuserexist = dr["username"].ToString();
                    txtpassexist = dr["password"].ToString();
                }
                dr.Close();
                mysqliconnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                mysqliconnection.Close();
            }
        }
    }
}

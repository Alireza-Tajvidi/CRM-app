using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Generic;
using CRMMenues;
using System.Runtime.CompilerServices;

namespace CRM_Interface
{
    public partial class frmLogin : Form
    {
        SQLiteConnection conn;
        public frmLogin()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=C:\Parsi\Morya\CRM\Database\LoginDb.sqlite;Version=3;New=True;Compress=True;");
        }

        private void csbtnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
        }

        private void csbtnLogin_Click(object sender, EventArgs e)
        {
            string username = cstxtUsername.texts1;
            string password = cstxtPassword.texts1;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifrenizi girin.");
                return;
            }
            if (CheckLogin(username, password))
            {
                // login successful, go to menu and close login page
                MessageBox.Show("Giriş yapıldı!");
                this.Hide();
                var frmMain = new frmMain();
                frmMain.Closed += (s, args) => this.Close();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre.");
            }
        }
        private bool CheckLogin(string username, string password)
        {
            bool isValid = false;
            //controls login information username
            try
            {
                conn.Open();

                string query = "SELECT * FROM Users WHERE Username = @username";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedPassword = reader["Password"].ToString();
                    // checks if password and user name match
                    if (storedPassword == password)
                    {
                        isValid = true;
                    }
                }
            }
            //catches exceptions
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isValid;
        }
        public static void CloseLogin()
        { 
            frmLogin frmLogin = new frmLogin();
            frmLogin.Close();
        
        }
    }
}

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

namespace CRM_Interface
{
    public partial class frmSignUp : Form
    {
        SQLiteConnection conn;
        public frmSignUp()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=C:\Parsi\Morya\CRM\Database\LoginDb.sqlite;Version=3;New=True;Compress=True;");
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void csbtnSignUp_Click(object sender, EventArgs e)
        {
            
            if (cstxtPassword.texts1 == cstxtPasswordControl.texts1)
            {
                conn.Open();
                string Name = cstxtName.texts1;
                string Surname = cstxtSurname.texts1;
                string Username = cstxtUsername.texts1;
                string Email = cstxtEmail.texts1;
                string Password = cstxtPassword.texts1;
                string InsertQuery = "INSERT INTO Users (Name, Surname, Username, Email, Password) VALUES (@Name, @Surname, @Username, @Email, @Password)";
                try 
                {
                    using (SQLiteCommand cmdInsert = new SQLiteCommand(InsertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@Name", Name);
                        cmdInsert.Parameters.AddWithValue("@Surname", Surname);
                        cmdInsert.Parameters.AddWithValue("@Username", Username);
                        cmdInsert.Parameters.AddWithValue("@Email", Email);
                        cmdInsert.Parameters.AddWithValue("@Password", Password);

                        cmdInsert.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Bize katıldınız");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //shows error if the password repeat is incorrect
            else
            {
                MessageBox.Show("Sifre tekrar yanliş");
                conn.Close();
            }
        }
    }
}

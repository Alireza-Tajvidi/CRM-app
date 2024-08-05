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


namespace CRMMenues
{
    public partial class frmCostumersList : Form
    {
        SQLiteConnection conn;
        public frmCostumersList()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=C:\Parsi\Morya\CRM\Database\CRMdb.sqlite;Version=3;New=True;Compress=True;");
        }
        
        private void frmCostumersList_Load(object sender, EventArgs e)
        {
            PullData();
        }
        
        private string GenerateID()
        {
            //issues with generating the same ID over and over again
            string CustomerID = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            return CustomerID;  
        }

        private void csbtnAdd_Click(object sender, EventArgs e)
        {
            string Name = cstxtName.texts1;
            string Surname = cstxtSurname.texts1;
            string Phone = cstxtPhone.texts1;
            string CustomerID = GenerateID();
            conn.Open();
            string InsertQuery = "INSERT INTO Customers (Name, Surname, Phone, CustomerID) VALUES (@Name, @Surname, @Phone, @CustomerID)";
            try
            {
                using (SQLiteCommand cmdInsert = new SQLiteCommand(InsertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@Name", Name);
                    cmdInsert.Parameters.AddWithValue("@Surname", Surname);
                    cmdInsert.Parameters.AddWithValue("@Phone", Phone);
                    cmdInsert.Parameters.AddWithValue("@CustomerID", CustomerID);

                    cmdInsert.ExecuteNonQuery();
                    conn.Close();
                    PullData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void csbtnDelete_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @FindID";
            string FindID = cstxtCustomerID.texts1; // Assuming texts1 should be Text
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FindID", FindID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // If an identical CustomerID exists
                        if (reader.Read())
                        {
                            string id = reader.GetString(3); // Get the CustomerID column value
                            string deleteQuery = "DELETE FROM Customers WHERE CustomerID = @CustomerId"; // Corrected DELETE query syntax
                            using (SQLiteCommand cmdDelete = new SQLiteCommand(deleteQuery, conn))
                            {
                                cmdDelete.Parameters.AddWithValue("@CustomerId", id);
                                cmdDelete.ExecuteNonQuery(); // Use ExecuteNonQuery for DELETE command
                            }
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
                PullData();
            }
        }

        private void dtgrdCostumers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string searchText = cstxtCustomerID.texts1;

            conn.Open();

            if (e.RowIndex >= 0)
            {
             
                // Get the current row
                DataGridViewRow row = dtgrdCostumers.Rows[e.RowIndex];

                // Assuming columns: 0 = Id, 1 = Name, 2 = Age, 3 = Email
                string Name = row.Cells[0].Value.ToString();
                string Surname = row.Cells[1].Value.ToString();
                string Phone = row.Cells[2].Value.ToString();
                string CustomerID = row.Cells[3].Value.ToString();


                // Update text boxes with the values from the selected row
                cstxtName.texts1 = Name;
                cstxtSurname.texts1 = Surname;
                cstxtPhone.texts1 = Phone;
                cstxtCustomerID.texts1 = CustomerID;
                
            }
            conn.Close();

        }

        private void PullData()
        {

            conn.Open();

            string selectQuery = "SELECT * FROM Customers";
            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, conn))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgrdCostumers.DataSource = dataTable;
            }

            conn.Close();
        }

        private void panBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            GoBack();
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            this.Hide();
            var frmMain = new frmMain();
            frmMain.Closed += (s, args) => this.Close();
            frmMain.Show();
        }

       
    }
}

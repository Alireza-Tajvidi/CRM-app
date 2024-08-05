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
    public partial class frmCustomerDetails : Form
    {
        SQLiteConnection conn;
        public frmCustomerDetails()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=C:\Parsi\Morya\CRM\Database\CRMdb.sqlite;Version=3;New=True;Compress=True;");
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

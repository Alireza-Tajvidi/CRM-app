using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMMenues
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void csbtnCostumer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmCostumers = new frmCostumersList();
            frmCostumers.Closed += (s, args) => this.Close();
            frmCostumers.Show();
        }

        private void csbtnCustomerDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmCsDetails = new frmCustomerDetails();
            frmCsDetails.Closed += (s, args) => this.Close();
            frmCsDetails.Show();
        }
    }
}

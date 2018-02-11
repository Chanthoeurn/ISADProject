using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_Project
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            slidePanel.Height = btnServices.Height;
            slidePanel.Top = btnServices.Top;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnServices.Height;
            slidePanel.Top = btnServices.Top;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnCustomer.Height;
            slidePanel.Top = btnCustomer.Top;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnEmployees.Height;
            slidePanel.Top = btnEmployees.Top;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnSupplier.Height;
            slidePanel.Top = btnSupplier.Top;

        }

        private void btnSpareparts_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnSpareparts.Height;
            slidePanel.Top = btnSpareparts.Top;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnReport.Height;
            slidePanel.Top = btnReport.Top;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnAccount.Height;
            slidePanel.Top = btnAccount.Top;
        }

     
    }
}

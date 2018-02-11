using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_Project
{
    public partial class openServicesControl : UserControl
    {
        public openServicesControl()
        {
            InitializeComponent();
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchService.Text =="") 
            {
                txtSearchService.Text = "Search Services here...";
                txtSearchService.ForeColor = Color.Silver;
            }
        }
    }
}

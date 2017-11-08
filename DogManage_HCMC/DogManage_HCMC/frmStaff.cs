using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {

        }

        private void tbFindDog_MouseDown(object sender, MouseEventArgs e)
        {
            tbFindDog.Text = "";
        }

        private void tbFindDog_TextChanged(object sender, EventArgs e)
        {
                
        }
    }
}

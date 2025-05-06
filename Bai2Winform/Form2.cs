using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2Winform
{
    public partial class frmB : Form
    {
        public frmB()
        {
            InitializeComponent();
        }

        private void frmB_Load(object sender, EventArgs e)
        {

        }

        private void frmB_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rs;
            //rs = MessageBox.Show("Mày muốn thoát à cu?",
            //                     "Thoát",
            //                     MessageBoxButtons.YesNo,
            //                     MessageBoxIcon.Question);
            //if (rs == DialogResult.No)
            //    e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mày muốn thoát à cu?",
                                                  "Thoát",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Close();
            else
                MessageBox.Show("Không out nữa nhé", "Out",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

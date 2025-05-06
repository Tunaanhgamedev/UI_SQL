using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide2
{
    public partial class frmMot : Form
    {
        public frmMot()
        {
            InitializeComponent();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            frmHai frm2 = new frmHai();
            // khi sang form 2 thì form 1 bien mat
            frm2.Show();
            this.Hide();
            // Nếu tắt form 2 thì form 1 hiện lại
            frm2.FormClosed += (s, args) => this.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblOutput.ForeColor = radBlack.ForeColor;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát!",
                                              "Thông báo",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                Close();
            else
                return;
        }

        private void frmMot_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            chkIndam.Checked = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked)
            {
                lblOutput.ForeColor = radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(radGreen.Checked)
            {
                lblOutput.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlue.Checked)
            {
                lblOutput.ForeColor = radBlue.ForeColor;
            }
        }

        private void chkIndam_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font.Name, 
                                      lblOutput.Font.Size,
                                      lblOutput.Font.Style ^FontStyle.Bold);
        }

        private void chkInnghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font.Name,
                                      lblOutput.Font.Size,
                                      lblOutput.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachchan_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font.Name,
                                      lblOutput.Font.Size,
                                      lblOutput.Font.Style ^ FontStyle.Underline);
        }
        /*        private void radBlack_CheckedChanged(object sender, EventArgs e)
{
if(radBlack.Checked)
{
lblOutput.ForeColor = radBlack.ForeColor;
}
}*/
    }
}

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
    public partial class frmTinh : Form
    {
        public frmTinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSonguyenb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetqua.Text = txtA.Text + " + " + txtB.Text + " = " + tong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Mày muốn thoát à cu?", 
                                 "Thoát", 
                                 MessageBoxButtons.YesNo, 
                                 MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                Close();
            else
                MessageBox.Show("Không out nữa nhé", "Out", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetqua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu.ToString();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Mày muốn reset à cu?", 
                                 "Reset", 
                                 MessageBoxButtons.YesNo, 
                                 MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                txtA.Text = "";
                txtB.Text = "";
                lblKetqua.Text = "";
            }
            else 
                {
                MessageBox.Show("Quay lại nhe", "Quay lại", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            // Chuyển sang form2
            frmB frm2 = new frmB();
            frm2.Show();
            // Nếu form 2 xuất hiện thì form 1 ẩn đi
            this.Hide();
            // Nếu form 2 đóng thì quay lại fom 1
            frm2.FormClosed += (s, args) => this.Show();
        }
    }
}

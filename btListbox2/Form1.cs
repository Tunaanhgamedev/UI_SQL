using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btListbox2
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            sv.MaSV = int.Parse(txtId.Text);
            sv.HoTen = txtName.Text;
            string s = sv.MaSV.ToString() + " - " + sv.HoTen;
            lstSv.Items.Add(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa lúc chọn bằng chuột và trước khi xóa phải hỏi người dùng
            if (lstSv.SelectedIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lstSv.Items.RemoveAt(lstSv.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên nào để xóa");
            }
        }
    }
}

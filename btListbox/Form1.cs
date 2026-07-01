using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btListbox
{
    public partial class frmBTbox : Form
    {
        public frmBTbox()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNhap.Text);
            lstSo.Items.Add(x);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int i in lstSo.Items)
                tong += i;
                MessageBox.Show("Tổng là: " + tong);
            
        }

        private void btnXoadaucuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnXoadangchon_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedIndex != -1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstSo.Items.Count; i++)
            {
                Console.WriteLine(lstSo.Items[i]);
                int x = (int)lstSo.Items[i] + 2;
                lstSo.Items[i] = x;
            }
        }

        private void btnBinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                Console.WriteLine(lstSo.Items[i]);
                int x = (int)lstSo.Items[i] * (int)lstSo.Items[i];
                lstSo.Items[i] = x;
            }
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?",
                                                  "Thông báo",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if(x % 2 == 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
            // Nhấp lần 2 sẽ bỏ chọn    
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }
    }
}

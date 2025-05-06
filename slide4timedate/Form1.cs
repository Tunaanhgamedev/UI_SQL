using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide4timedate
{
    public partial class frmDangki : Form
    {
        public frmDangki()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if(txtSdt.Text == "")
            {
                errorProvider1.SetError(txtSdt, "Bạn chưa nhập số điện thoại...");
                check = false;
            }
            int tuoi;
            if(int.TryParse(txtAge.Text, out tuoi) == false)
            {
                errorProvider2.SetError(txtAge, "Sai định dạng?");
                check = false;
            }
            else
            {
                if(tuoi < 12)
                {
                    errorProvider2.SetError(txtAge, "Bạn chưa đủ tuổi đăng kí...");
                    check = false;
                }
            }
            // Kiểm tra ngày đăng kí
            if(dtbNam.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider3.SetError(dtbNam, "Thứ 2 không làm việc...");
                check = false;
            }
            if(check) MessageBox.Show("Đăng kí thành công, chúng tôi sẽ thông báo lại với bạn!");
            else MessageBox.Show("Đăng kí không thành công");
        }

        private void grbDangki_Enter(object sender, EventArgs e)
        {

        }
    }
}

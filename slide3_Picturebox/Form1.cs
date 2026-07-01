using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace slie3_Picturebox
{
    public partial class Form1 : Form
    {
        private SoundPlayer choiNhac;
        public Form1()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer("sommai.wav");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void picTuanloc_Click(object sender, EventArgs e)
        {

        }
        int count = 1;

        private void btnDem_Click(object sender, EventArgs e)
        {
            if(picNoel.Visible == false)
            {
                picTuanloc.Visible = false;
                picNoel.Visible = true;
                btnDem.Text = btnDem.Text.Replace("đổi", "đổi tiếp");
                lblDem.Text = count.ToString();
                count++;
                if(count == 13)
                {
                    DialogResult result = MessageBox.Show("Bạn đã đổi 12 lần, bạn có muốn dừng lại không", 
                                                  "Thông báo", 
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question);
                    // Tắt thông báo
                    if(result == DialogResult.Yes)
                    {
                        Close();
                    }

                }
            }
            else
            {
                picTuanloc.Visible = true; 
                picNoel.Visible = false;
                btnDem.Text = btnDem.Text.Replace("đổi tiếp", "đổi");
            }
            /*btnDem.Text = txtDien.Text;*/
            /* btnDem.Font = new Font(btnDem.Font.Name,
                                    btnDem.Font.Size,
                                    btnDem.Font.Style ^ FontStyle.Underline);*/
        }

        private void txtDien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblNhapten_Click(object sender, EventArgs e)
        {

        }

        private void txtDien_TextChanged_1(object sender, EventArgs e)
        {
            if(picNoel.Visible == false)
            {
                btnDem.Text = txtDien.Text + " !đổi";
            }
            else
            {
                btnDem.Text = txtDien.Text + " !đổi tiếp";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picNoel.Visible = false;
            picTuanloc.Visible = true;
        }

        private void lblDem_Click(object sender, EventArgs e)
        {

        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMusic.Checked == true)
            {
                choiNhac.Play();
            }
            else
            {
                choiNhac.Stop();
            }
        }
    }
}

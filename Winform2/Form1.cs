using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siuuuuuuuuu",
                            "Khong co gi", 
                             MessageBoxButtons.YesNoCancel, 
                             MessageBoxIcon.Hand);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // ctrl + k + c
            // ctrl + k + u
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            else if (result == DialogResult.No)
                MessageBox.Show("Ban da chon khong thoat",
                                "Thong bao",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Ban co muon thoat khong?",
            //                                      "Confirm",
            //                                      MessageBoxButtons.YesNo,
            //                                      MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //    e.Cancel = true;
            //else
            //    e.Cancel = false;
        }
    }
}

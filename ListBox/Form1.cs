using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstDanhsach.Items.Add("item 10");
            lstDanhsach.Items.Add("item 0");
        }

        private void lstDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = lstDanhsach.Items.Count;
            MessageBox.Show("số phần tử lst box là: " + a);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDanhsach.Items[1].ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstDanhsach.Items.RemoveAt(0);
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            foreach(int i in lstDanhsach.SelectedIndices)
            {
                Console.WriteLine(i);
            }
            // Trả về phần tử đầu tiên trong lst được chọn
            Console.WriteLine(lstDanhsach.SelectedIndices[0]);
            // đếm
            Console.WriteLine(lstDanhsach.SelectedIndices.Count);
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            lstDanhsach.Items[0] = "phần tử mới";
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index items được chọn là: " + lstDanhsach.SelectedIndex);
        }
    }
}

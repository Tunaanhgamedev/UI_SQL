using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCheckedListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chklbTrai.CheckedItems;
            foreach (var item in items)
            {
                //Console.WriteLine(item);
                chklbPhai.Items.Add(item);
            }
            // Duyệt để xóa pt bên trái
            foreach (string item in chklbPhai.Items)
            {
                chklbTrai.Items.Remove(item);
            }
        }

        private void btnPhaihet_Click(object sender, EventArgs e)
        {
            chklbPhai.Items.AddRange(chklbTrai.Items);
            chklbTrai.Items.Clear();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chklbPhai.CheckedItems;
            foreach (var item in items)
            {
                //Console.WriteLine(item);
                chklbTrai.Items.Add(item);
            }
            // Duyệt để xóa pt bên phải
            foreach (string item in chklbTrai.Items)
            {
                chklbPhai.Items.Remove(item);
            }
        }

        private void btnTraihet_Click(object sender, EventArgs e)
        {
            chklbTrai.Items.AddRange(chklbPhai.Items);
            chklbPhai.Items.Clear();
        }
    }
}

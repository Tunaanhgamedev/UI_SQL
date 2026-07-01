using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListbox
{
    public partial class frmCheckListbox : Form
    {
        public frmCheckListbox()
        {
            InitializeComponent();
        }

        private void chklbDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chklbDanhsach.Items.Add("moi");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            chklbDanhsach.Items.Insert(1, 199);
        }

        private void btnAddrange_Click(object sender, EventArgs e)
        {
            chklbDanhsach.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // RemoveAt
            chklbDanhsach.Items.RemoveAt(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chklbDanhsach.Items.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So phan tu trong CheckedListBox la: " + chklbDanhsach.Items.Count.ToString());
        }

        private void btnCheckedIndices_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection checkedIndices = chklbDanhsach.CheckedIndices;
            string strCheck = "";
            foreach (int i in checkedIndices)
            {
                strCheck += i + " ";
            }
            MessageBox.Show("Chi so phan tu duoc chon la: " + strCheck.ToString());
        }

        private void btnCheckedItems_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedItems = chklbDanhsach.CheckedItems;
            string strItems = "";
            foreach (object item in checkedItems)
            {
                strItems += item.ToString() + " ";
            }
            MessageBox.Show(strItems.ToString());
        }

        private void btnGetItemChecked_Click(object sender, EventArgs e)
        {
            string strCheck = "";
            for (int i = 0; i < chklbDanhsach.Items.Count; i++)
            {
                if (chklbDanhsach.GetItemChecked(i))
                {
                    strCheck += chklbDanhsach.Items[i].ToString() + " ";
                }
            }
            MessageBox.Show(strCheck.ToString());
        }
    }
}

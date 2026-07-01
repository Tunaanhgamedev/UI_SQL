using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboDanhsach.Items.Add("Tuấn moi");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cboDanhsach.Items.Insert(1, "Tuấn moi");
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index pt đang chọn là: " + cboDanhsach.SelectedIndex);
        }

        private void btnSelectedItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("items pt đang chọn là: " + cboDanhsach.SelectedItem);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("số phần tử là: " + cboDanhsach.Items.Count);
        }

        private void btnAddrange_Click(object sender, EventArgs e)
        {
            cboDanhsach.Items.AddRange(new string[] { "Tuấn", "Hải", "Nam", "Hà" });
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboDanhsach.Items.Remove("Tuấn");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            cboDanhsach.Items.RemoveAt(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboDanhsach.Items.Clear();
        }
    }
}

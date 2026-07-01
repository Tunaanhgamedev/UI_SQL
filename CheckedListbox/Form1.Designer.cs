namespace CheckedListbox
{
    partial class frmCheckListbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chklbDanhsach = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAddrange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnCheckedIndices = new System.Windows.Forms.Button();
            this.btnCheckedItems = new System.Windows.Forms.Button();
            this.btnGetItemChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbDanhsach
            // 
            this.chklbDanhsach.FormattingEnabled = true;
            this.chklbDanhsach.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.chklbDanhsach.Location = new System.Drawing.Point(64, 45);
            this.chklbDanhsach.Name = "chklbDanhsach";
            this.chklbDanhsach.Size = new System.Drawing.Size(162, 123);
            this.chklbDanhsach.TabIndex = 0;
            this.chklbDanhsach.SelectedIndexChanged += new System.EventHandler(this.chklbDanhsach_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(64, 249);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAddrange
            // 
            this.btnAddrange.Location = new System.Drawing.Point(64, 291);
            this.btnAddrange.Name = "btnAddrange";
            this.btnAddrange.Size = new System.Drawing.Size(101, 23);
            this.btnAddrange.TabIndex = 3;
            this.btnAddrange.Text = "Addrange";
            this.btnAddrange.UseVisualStyleBackColor = true;
            this.btnAddrange.Click += new System.EventHandler(this.btnAddrange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(181, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(195, 290);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnCheckedIndices
            // 
            this.btnCheckedIndices.Location = new System.Drawing.Point(285, 202);
            this.btnCheckedIndices.Name = "btnCheckedIndices";
            this.btnCheckedIndices.Size = new System.Drawing.Size(139, 23);
            this.btnCheckedIndices.TabIndex = 7;
            this.btnCheckedIndices.Text = "CheckedIndices";
            this.btnCheckedIndices.UseVisualStyleBackColor = true;
            this.btnCheckedIndices.Click += new System.EventHandler(this.btnCheckedIndices_Click);
            // 
            // btnCheckedItems
            // 
            this.btnCheckedItems.Location = new System.Drawing.Point(285, 249);
            this.btnCheckedItems.Name = "btnCheckedItems";
            this.btnCheckedItems.Size = new System.Drawing.Size(129, 23);
            this.btnCheckedItems.TabIndex = 8;
            this.btnCheckedItems.Text = "CheckedItems";
            this.btnCheckedItems.UseVisualStyleBackColor = true;
            this.btnCheckedItems.Click += new System.EventHandler(this.btnCheckedItems_Click);
            // 
            // btnGetItemChecked
            // 
            this.btnGetItemChecked.Location = new System.Drawing.Point(285, 289);
            this.btnGetItemChecked.Name = "btnGetItemChecked";
            this.btnGetItemChecked.Size = new System.Drawing.Size(139, 25);
            this.btnGetItemChecked.TabIndex = 9;
            this.btnGetItemChecked.Text = "GetItemChecked";
            this.btnGetItemChecked.UseVisualStyleBackColor = true;
            this.btnGetItemChecked.Click += new System.EventHandler(this.btnGetItemChecked_Click);
            // 
            // frmCheckListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 388);
            this.Controls.Add(this.btnGetItemChecked);
            this.Controls.Add(this.btnCheckedItems);
            this.Controls.Add(this.btnCheckedIndices);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddrange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chklbDanhsach);
            this.Name = "frmCheckListbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbDanhsach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAddrange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnCheckedIndices;
        private System.Windows.Forms.Button btnCheckedItems;
        private System.Windows.Forms.Button btnGetItemChecked;
    }
}


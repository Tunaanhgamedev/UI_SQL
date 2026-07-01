namespace btListbox
{
    partial class frmBTbox
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbDanhsach = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.grbChucnang = new System.Windows.Forms.GroupBox();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBinhphuong = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnXoadangchon = new System.Windows.Forms.Button();
            this.btnXoadaucuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.grbDanhsach.SuspendLayout();
            this.grbChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhap.Location = new System.Drawing.Point(40, 28);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(81, 18);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập số: ";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(117, 28);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(322, 22);
            this.txtNhap.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(445, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbDanhsach
            // 
            this.grbDanhsach.Controls.Add(this.lstSo);
            this.grbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhsach.Location = new System.Drawing.Point(34, 82);
            this.grbDanhsach.Name = "grbDanhsach";
            this.grbDanhsach.Size = new System.Drawing.Size(314, 331);
            this.grbDanhsach.TabIndex = 3;
            this.grbDanhsach.TabStop = false;
            this.grbDanhsach.Text = "Danh sách số";
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(3, 18);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(308, 310);
            this.lstSo.TabIndex = 0;
            // 
            // grbChucnang
            // 
            this.grbChucnang.Controls.Add(this.btnLe);
            this.grbChucnang.Controls.Add(this.btnChan);
            this.grbChucnang.Controls.Add(this.btnBinhphuong);
            this.grbChucnang.Controls.Add(this.btnTang);
            this.grbChucnang.Controls.Add(this.btnXoadangchon);
            this.grbChucnang.Controls.Add(this.btnXoadaucuoi);
            this.grbChucnang.Controls.Add(this.btnTong);
            this.grbChucnang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucnang.Location = new System.Drawing.Point(354, 82);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Size = new System.Drawing.Size(314, 331);
            this.grbChucnang.TabIndex = 4;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chọn chức năng";
            // 
            // btnLe
            // 
            this.btnLe.BackColor = System.Drawing.Color.Silver;
            this.btnLe.Location = new System.Drawing.Point(7, 288);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(301, 40);
            this.btnLe.TabIndex = 6;
            this.btnLe.Text = "Chọn số lẻ";
            this.btnLe.UseVisualStyleBackColor = false;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnChan
            // 
            this.btnChan.BackColor = System.Drawing.Color.Silver;
            this.btnChan.Location = new System.Drawing.Point(6, 242);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(301, 40);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = false;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnBinhphuong
            // 
            this.btnBinhphuong.BackColor = System.Drawing.Color.Silver;
            this.btnBinhphuong.Location = new System.Drawing.Point(7, 196);
            this.btnBinhphuong.Name = "btnBinhphuong";
            this.btnBinhphuong.Size = new System.Drawing.Size(301, 40);
            this.btnBinhphuong.TabIndex = 4;
            this.btnBinhphuong.Text = "Thay bằng bình phương";
            this.btnBinhphuong.UseVisualStyleBackColor = false;
            this.btnBinhphuong.Click += new System.EventHandler(this.btnBinhphuong_Click);
            // 
            // btnTang
            // 
            this.btnTang.BackColor = System.Drawing.Color.Silver;
            this.btnTang.Location = new System.Drawing.Point(7, 150);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(301, 40);
            this.btnTang.TabIndex = 3;
            this.btnTang.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnXoadangchon
            // 
            this.btnXoadangchon.BackColor = System.Drawing.Color.Silver;
            this.btnXoadangchon.Location = new System.Drawing.Point(7, 104);
            this.btnXoadangchon.Name = "btnXoadangchon";
            this.btnXoadangchon.Size = new System.Drawing.Size(301, 40);
            this.btnXoadangchon.TabIndex = 2;
            this.btnXoadangchon.Text = "Xóa phần tử đang chọn";
            this.btnXoadangchon.UseVisualStyleBackColor = false;
            this.btnXoadangchon.Click += new System.EventHandler(this.btnXoadangchon_Click);
            // 
            // btnXoadaucuoi
            // 
            this.btnXoadaucuoi.BackColor = System.Drawing.Color.Silver;
            this.btnXoadaucuoi.Location = new System.Drawing.Point(7, 58);
            this.btnXoadaucuoi.Name = "btnXoadaucuoi";
            this.btnXoadaucuoi.Size = new System.Drawing.Size(301, 40);
            this.btnXoadaucuoi.TabIndex = 1;
            this.btnXoadaucuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoadaucuoi.UseVisualStyleBackColor = false;
            this.btnXoadaucuoi.Click += new System.EventHandler(this.btnXoadaucuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.Silver;
            this.btnTong.Location = new System.Drawing.Point(7, 13);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(301, 40);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng của danh sách";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.BackColor = System.Drawing.Color.Silver;
            this.btnKetthuc.Location = new System.Drawing.Point(34, 436);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(639, 37);
            this.btnKetthuc.TabIndex = 5;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = false;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // frmBTbox
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnKetthuc;
            this.ClientSize = new System.Drawing.Size(685, 485);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.grbChucnang);
            this.Controls.Add(this.grbDanhsach);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblNhap);
            this.Name = "frmBTbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điền Items";
            this.grbDanhsach.ResumeLayout(false);
            this.grbChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grbDanhsach;
        private System.Windows.Forms.GroupBox grbChucnang;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBinhphuong;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnXoadangchon;
        private System.Windows.Forms.Button btnXoadaucuoi;
        private System.Windows.Forms.Button btnTong;
    }
}


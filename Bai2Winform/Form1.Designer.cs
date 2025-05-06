namespace Bai2Winform
{
    partial class frmTinh
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
            this.lblSonguyenb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnRs = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.btnchuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSonguyenb
            // 
            this.lblSonguyenb.BackColor = System.Drawing.Color.Silver;
            this.lblSonguyenb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonguyenb.ForeColor = System.Drawing.Color.Red;
            this.lblSonguyenb.Location = new System.Drawing.Point(51, 131);
            this.lblSonguyenb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonguyenb.Name = "lblSonguyenb";
            this.lblSonguyenb.Size = new System.Drawing.Size(136, 30);
            this.lblSonguyenb.TabIndex = 1;
            this.lblSonguyenb.Text = "Số nguyên b: ";
            this.lblSonguyenb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSonguyenb.Click += new System.EventHandler(this.lblSonguyenb_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số nguyên a: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.Lime;
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.ForeColor = System.Drawing.Color.Blue;
            this.btnTong.Location = new System.Drawing.Point(56, 197);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(83, 59);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "&Tổng";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(433, 295);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 59);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.White;
            this.txtA.Location = new System.Drawing.Point(209, 78);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(253, 30);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.White;
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(209, 131);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(253, 30);
            this.txtB.TabIndex = 1;
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.Lime;
            this.btnHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieu.ForeColor = System.Drawing.Color.Blue;
            this.btnHieu.Location = new System.Drawing.Point(187, 197);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(83, 59);
            this.btnHieu.TabIndex = 3;
            this.btnHieu.Text = "&Hiệu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnRs
            // 
            this.btnRs.BackColor = System.Drawing.Color.Cyan;
            this.btnRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRs.Location = new System.Drawing.Point(323, 197);
            this.btnRs.Name = "btnRs";
            this.btnRs.Size = new System.Drawing.Size(83, 59);
            this.btnRs.TabIndex = 4;
            this.btnRs.Text = "&Reset";
            this.btnRs.UseVisualStyleBackColor = false;
            this.btnRs.Click += new System.EventHandler(this.btnRs_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.BackColor = System.Drawing.Color.Yellow;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetqua.Location = new System.Drawing.Point(209, -1);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(253, 63);
            this.lblKetqua.TabIndex = 0;
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnchuyen
            // 
            this.btnchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuyen.Location = new System.Drawing.Point(56, 282);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(83, 59);
            this.btnchuyen.TabIndex = 6;
            this.btnchuyen.Text = "Chuyển";
            this.btnchuyen.UseVisualStyleBackColor = true;
            this.btnchuyen.Click += new System.EventHandler(this.btnchuyen_Click);
            // 
            // frmTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(517, 353);
            this.Controls.Add(this.btnchuyen);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.btnRs);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonguyenb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTinh";
            this.Text = "Tính toán học sinh lớp 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSonguyenb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnRs;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Button btnchuyen;
    }
}


namespace slie3_Picturebox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picNoel = new System.Windows.Forms.PictureBox();
            this.picTuanloc = new System.Windows.Forms.PictureBox();
            this.lblNhapten = new System.Windows.Forms.Label();
            this.lblNguoi = new System.Windows.Forms.Label();
            this.lblTanh = new System.Windows.Forms.Label();
            this.btnDem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDien = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.lblDem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNoel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTuanloc)).BeginInit();
            this.SuspendLayout();
            // 
            // picNoel
            // 
            this.picNoel.Image = ((System.Drawing.Image)(resources.GetObject("picNoel.Image")));
            this.picNoel.Location = new System.Drawing.Point(46, 67);
            this.picNoel.Name = "picNoel";
            this.picNoel.Size = new System.Drawing.Size(311, 216);
            this.picNoel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoel.TabIndex = 0;
            this.picNoel.TabStop = false;
            // 
            // picTuanloc
            // 
            this.picTuanloc.Image = ((System.Drawing.Image)(resources.GetObject("picTuanloc.Image")));
            this.picTuanloc.Location = new System.Drawing.Point(46, 67);
            this.picTuanloc.Name = "picTuanloc";
            this.picTuanloc.Size = new System.Drawing.Size(311, 216);
            this.picTuanloc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTuanloc.TabIndex = 1;
            this.picTuanloc.TabStop = false;
            this.picTuanloc.Visible = false;
            this.picTuanloc.Click += new System.EventHandler(this.picTuanloc_Click);
            // 
            // lblNhapten
            // 
            this.lblNhapten.AutoSize = true;
            this.lblNhapten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapten.Location = new System.Drawing.Point(41, 9);
            this.lblNhapten.Name = "lblNhapten";
            this.lblNhapten.Size = new System.Drawing.Size(153, 25);
            this.lblNhapten.TabIndex = 2;
            this.lblNhapten.Text = "Nhập tên vào: ";
            this.lblNhapten.Click += new System.EventHandler(this.lblNhapten_Click);
            // 
            // lblNguoi
            // 
            this.lblNguoi.AutoSize = true;
            this.lblNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoi.Location = new System.Drawing.Point(43, 367);
            this.lblNguoi.Name = "lblNguoi";
            this.lblNguoi.Size = new System.Drawing.Size(105, 18);
            this.lblNguoi.TabIndex = 3;
            this.lblNguoi.Text = "Designed by:";
            this.lblNguoi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTanh
            // 
            this.lblTanh.AutoSize = true;
            this.lblTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanh.Location = new System.Drawing.Point(42, 395);
            this.lblTanh.Name = "lblTanh";
            this.lblTanh.Size = new System.Drawing.Size(80, 20);
            this.lblTanh.TabIndex = 3;
            this.lblTanh.Text = "Tuấn Anh";
            this.lblTanh.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDem
            // 
            this.btnDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDem.ForeColor = System.Drawing.Color.Red;
            this.btnDem.Location = new System.Drawing.Point(47, 289);
            this.btnDem.Name = "btnDem";
            this.btnDem.Size = new System.Drawing.Size(310, 55);
            this.btnDem.TabIndex = 4;
            this.btnDem.UseVisualStyleBackColor = true;
            this.btnDem.Click += new System.EventHandler(this.btnDem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(268, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 58);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDien
            // 
            this.txtDien.Location = new System.Drawing.Point(46, 39);
            this.txtDien.Name = "txtDien";
            this.txtDien.Size = new System.Drawing.Size(311, 22);
            this.txtDien.TabIndex = 6;
            this.txtDien.TextChanged += new System.EventHandler(this.txtDien_TextChanged_1);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(293, 15);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(64, 20);
            this.chkMusic.TabIndex = 7;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // lblDem
            // 
            this.lblDem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDem.Location = new System.Drawing.Point(168, 357);
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(82, 58);
            this.lblDem.TabIndex = 8;
            this.lblDem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDem.Click += new System.EventHandler(this.lblDem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(410, 426);
            this.Controls.Add(this.lblDem);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.txtDien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDem);
            this.Controls.Add(this.lblTanh);
            this.Controls.Add(this.lblNguoi);
            this.Controls.Add(this.lblNhapten);
            this.Controls.Add(this.picTuanloc);
            this.Controls.Add(this.picNoel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNoel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTuanloc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNoel;
        private System.Windows.Forms.PictureBox picTuanloc;
        private System.Windows.Forms.Label lblNhapten;
        private System.Windows.Forms.Label lblNguoi;
        private System.Windows.Forms.Label lblTanh;
        private System.Windows.Forms.Button btnDem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDien;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Label lblDem;
    }
}


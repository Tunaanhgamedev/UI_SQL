namespace slide4timedate
{
    partial class frmDangki
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
            this.components = new System.ComponentModel.Container();
            this.grbDangki = new System.Windows.Forms.GroupBox();
            this.dtbNam = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.btnDangki = new System.Windows.Forms.Button();
            this.lblNgaydki = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDangki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDangki
            // 
            this.grbDangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbDangki.Controls.Add(this.dtbNam);
            this.grbDangki.Controls.Add(this.txtAge);
            this.grbDangki.Controls.Add(this.txtSdt);
            this.grbDangki.Controls.Add(this.btnDangki);
            this.grbDangki.Controls.Add(this.lblNgaydki);
            this.grbDangki.Controls.Add(this.lblTuoi);
            this.grbDangki.Controls.Add(this.lblSdt);
            this.grbDangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangki.Location = new System.Drawing.Point(12, 12);
            this.grbDangki.Name = "grbDangki";
            this.grbDangki.Size = new System.Drawing.Size(524, 298);
            this.grbDangki.TabIndex = 0;
            this.grbDangki.TabStop = false;
            this.grbDangki.Text = "Thông tin đăng kí";
            this.grbDangki.Enter += new System.EventHandler(this.grbDangki_Enter);
            // 
            // dtbNam
            // 
            this.dtbNam.CustomFormat = "dd/MM/yyyy";
            this.dtbNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNam.Location = new System.Drawing.Point(147, 174);
            this.dtbNam.Name = "dtbNam";
            this.dtbNam.Size = new System.Drawing.Size(241, 27);
            this.dtbNam.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(147, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(241, 24);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(147, 71);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(241, 24);
            this.txtSdt.TabIndex = 4;
            this.txtSdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDangki
            // 
            this.btnDangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangki.Location = new System.Drawing.Point(202, 221);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(134, 39);
            this.btnDangki.TabIndex = 3;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // lblNgaydki
            // 
            this.lblNgaydki.AutoSize = true;
            this.lblNgaydki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaydki.Location = new System.Drawing.Point(6, 176);
            this.lblNgaydki.Name = "lblNgaydki";
            this.lblNgaydki.Size = new System.Drawing.Size(129, 20);
            this.lblNgaydki.TabIndex = 2;
            this.lblNgaydki.Text = "Ngày đăng kí: ";
            // 
            // lblTuoi
            // 
            this.lblTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuoi.Location = new System.Drawing.Point(37, 117);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(71, 31);
            this.lblTuoi.TabIndex = 1;
            this.lblTuoi.Text = "Tuổi :";
            this.lblTuoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSdt
            // 
            this.lblSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(26, 62);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(92, 45);
            this.lblSdt.TabIndex = 0;
            this.lblSdt.Text = "Phone";
            this.lblSdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // frmDangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 323);
            this.Controls.Add(this.grbDangki);
            this.Name = "frmDangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí xem phim";
            this.grbDangki.ResumeLayout(false);
            this.grbDangki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangki;
        private System.Windows.Forms.DateTimePicker dtbNam;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.Label lblNgaydki;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}


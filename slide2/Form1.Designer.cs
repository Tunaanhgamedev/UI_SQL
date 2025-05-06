namespace slide2
{
    partial class frmMot
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
            this.btnChuyen = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.chkGachchan = new System.Windows.Forms.CheckBox();
            this.chkInnghieng = new System.Windows.Forms.CheckBox();
            this.chkIndam = new System.Windows.Forms.CheckBox();
            this.grpColor.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChuyen
            // 
            this.btnChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.Location = new System.Drawing.Point(41, 349);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(116, 72);
            this.btnChuyen.TabIndex = 3;
            this.btnChuyen.Text = "Hiển thị";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(250, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(285, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.Cyan;
            this.lblInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(144, 32);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(100, 23);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Nhập vào";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpColor.Controls.Add(this.radBlack);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.Location = new System.Drawing.Point(78, 126);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(198, 189);
            this.grpColor.TabIndex = 1;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(7, 159);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(72, 24);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = false;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(7, 116);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(64, 24);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = false;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(7, 79);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(76, 24);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = false;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(7, 41);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(60, 24);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = false;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.White;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(311, 349);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(205, 59);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Tuấn Moi";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(641, 346);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 72);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpFont
            // 
            this.grpFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpFont.Controls.Add(this.chkGachchan);
            this.grpFont.Controls.Add(this.chkInnghieng);
            this.grpFont.Controls.Add(this.chkIndam);
            this.grpFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFont.Location = new System.Drawing.Point(505, 126);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(217, 189);
            this.grpFont.TabIndex = 2;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font chữ";
            // 
            // chkGachchan
            // 
            this.chkGachchan.AutoSize = true;
            this.chkGachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachchan.Location = new System.Drawing.Point(6, 117);
            this.chkGachchan.Name = "chkGachchan";
            this.chkGachchan.Size = new System.Drawing.Size(198, 24);
            this.chkGachchan.TabIndex = 2;
            this.chkGachchan.Text = "Gạch chân(Undeeline)";
            this.chkGachchan.UseVisualStyleBackColor = true;
            this.chkGachchan.CheckedChanged += new System.EventHandler(this.chkGachchan_CheckedChanged);
            // 
            // chkInnghieng
            // 
            this.chkInnghieng.AutoSize = true;
            this.chkInnghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInnghieng.Location = new System.Drawing.Point(6, 80);
            this.chkInnghieng.Name = "chkInnghieng";
            this.chkInnghieng.Size = new System.Drawing.Size(154, 24);
            this.chkInnghieng.TabIndex = 1;
            this.chkInnghieng.Text = "In nghiêng(Italic)";
            this.chkInnghieng.UseVisualStyleBackColor = true;
            this.chkInnghieng.CheckedChanged += new System.EventHandler(this.chkInnghieng_CheckedChanged);
            // 
            // chkIndam
            // 
            this.chkIndam.AutoSize = true;
            this.chkIndam.Location = new System.Drawing.Point(6, 42);
            this.chkIndam.Name = "chkIndam";
            this.chkIndam.Size = new System.Drawing.Size(135, 24);
            this.chkIndam.TabIndex = 0;
            this.chkIndam.Text = "In đậm(Bolt)";
            this.chkIndam.UseVisualStyleBackColor = true;
            this.chkIndam.CheckedChanged += new System.EventHandler(this.chkIndam_CheckedChanged);
            // 
            // frmMot
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(784, 433);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnChuyen);
            this.Name = "frmMot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng";
            this.Load += new System.EventHandler(this.frmMot_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.CheckBox chkGachchan;
        private System.Windows.Forms.CheckBox chkInnghieng;
        private System.Windows.Forms.CheckBox chkIndam;
    }
}


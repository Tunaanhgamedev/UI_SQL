namespace Bai2Winform
{
    partial class frmB
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
            this.lblJoke = new System.Windows.Forms.Label();
            this.btnTrl1 = new System.Windows.Forms.Button();
            this.btnTrl3 = new System.Windows.Forms.Button();
            this.btnTrl2 = new System.Windows.Forms.Button();
            this.btnTrl4 = new System.Windows.Forms.Button();
            this.lblHoi1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoke
            // 
            this.lblJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoke.Location = new System.Drawing.Point(267, 44);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(282, 102);
            this.lblJoke.TabIndex = 0;
            this.lblJoke.Text = "Joke off the day";
            this.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrl1
            // 
            this.btnTrl1.Location = new System.Drawing.Point(153, 232);
            this.btnTrl1.Name = "btnTrl1";
            this.btnTrl1.Size = new System.Drawing.Size(138, 62);
            this.btnTrl1.TabIndex = 1;
            this.btnTrl1.Text = "Minohuck";
            this.btnTrl1.UseVisualStyleBackColor = true;
            // 
            // btnTrl3
            // 
            this.btnTrl3.Location = new System.Drawing.Point(153, 345);
            this.btnTrl3.Name = "btnTrl3";
            this.btnTrl3.Size = new System.Drawing.Size(138, 62);
            this.btnTrl3.TabIndex = 3;
            this.btnTrl3.Text = "đau ruột";
            this.btnTrl3.UseVisualStyleBackColor = true;
            // 
            // btnTrl2
            // 
            this.btnTrl2.Location = new System.Drawing.Point(570, 232);
            this.btnTrl2.Name = "btnTrl2";
            this.btnTrl2.Size = new System.Drawing.Size(138, 62);
            this.btnTrl2.TabIndex = 2;
            this.btnTrl2.Text = "Ải chỉa";
            this.btnTrl2.UseVisualStyleBackColor = true;
            // 
            // btnTrl4
            // 
            this.btnTrl4.Location = new System.Drawing.Point(570, 345);
            this.btnTrl4.Name = "btnTrl4";
            this.btnTrl4.Size = new System.Drawing.Size(138, 62);
            this.btnTrl4.TabIndex = 4;
            this.btnTrl4.Text = "Tích phân";
            this.btnTrl4.UseVisualStyleBackColor = true;
            // 
            // lblHoi1
            // 
            this.lblHoi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoi1.ForeColor = System.Drawing.Color.Red;
            this.lblHoi1.Location = new System.Drawing.Point(129, 133);
            this.lblHoi1.Name = "lblHoi1";
            this.lblHoi1.Size = new System.Drawing.Size(600, 59);
            this.lblHoi1.TabIndex = 5;
            this.lblHoi1.Text = "Nếu bạn bị táo bón lâu ngày thì gọi là gì?";
            this.lblHoi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(391, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 43);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblHoi1);
            this.Controls.Add(this.btnTrl4);
            this.Controls.Add(this.btnTrl2);
            this.Controls.Add(this.btnTrl3);
            this.Controls.Add(this.btnTrl1);
            this.Controls.Add(this.lblJoke);
            this.Name = "frmB";
            this.Text = "Trôn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmB_FormClosing);
            this.Load += new System.EventHandler(this.frmB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Button btnTrl1;
        private System.Windows.Forms.Button btnTrl3;
        private System.Windows.Forms.Button btnTrl2;
        private System.Windows.Forms.Button btnTrl4;
        private System.Windows.Forms.Label lblHoi1;
        private System.Windows.Forms.Button btnThoat;
    }
}
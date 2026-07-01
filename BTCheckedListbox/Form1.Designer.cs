namespace BTCheckedListbox
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
            this.chklbTrai = new System.Windows.Forms.CheckedListBox();
            this.chklbPhai = new System.Windows.Forms.CheckedListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnPhaihet = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnTraihet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbTrai
            // 
            this.chklbTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbTrai.FormattingEnabled = true;
            this.chklbTrai.Items.AddRange(new object[] {
            "Xuyên tường",
            "Aim bot",
            "Chống giật",
            "Nhảy cao"});
            this.chklbTrai.Location = new System.Drawing.Point(39, 79);
            this.chklbTrai.Name = "chklbTrai";
            this.chklbTrai.Size = new System.Drawing.Size(149, 174);
            this.chklbTrai.TabIndex = 0;
            // 
            // chklbPhai
            // 
            this.chklbPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbPhai.FormattingEnabled = true;
            this.chklbPhai.Location = new System.Drawing.Point(388, 79);
            this.chklbPhai.Name = "chklbPhai";
            this.chklbPhai.Size = new System.Drawing.Size(149, 174);
            this.chklbPhai.TabIndex = 1;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(237, 79);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(95, 27);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnPhaihet
            // 
            this.btnPhaihet.Location = new System.Drawing.Point(237, 128);
            this.btnPhaihet.Name = "btnPhaihet";
            this.btnPhaihet.Size = new System.Drawing.Size(95, 27);
            this.btnPhaihet.TabIndex = 3;
            this.btnPhaihet.Text = ">>";
            this.btnPhaihet.UseVisualStyleBackColor = true;
            this.btnPhaihet.Click += new System.EventHandler(this.btnPhaihet_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(237, 178);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(95, 28);
            this.btnTrai.TabIndex = 4;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnTraihet
            // 
            this.btnTraihet.Location = new System.Drawing.Point(237, 228);
            this.btnTraihet.Name = "btnTraihet";
            this.btnTraihet.Size = new System.Drawing.Size(95, 25);
            this.btnTraihet.TabIndex = 5;
            this.btnTraihet.Text = "<<";
            this.btnTraihet.UseVisualStyleBackColor = true;
            this.btnTraihet.Click += new System.EventHandler(this.btnTraihet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 325);
            this.Controls.Add(this.btnTraihet);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhaihet);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.chklbPhai);
            this.Controls.Add(this.chklbTrai);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbTrai;
        private System.Windows.Forms.CheckedListBox chklbPhai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnPhaihet;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnTraihet;
    }
}


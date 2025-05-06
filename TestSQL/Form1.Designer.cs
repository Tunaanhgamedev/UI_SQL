namespace TestSQL
{
    partial class frmTest1
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
            this.btnJoke = new System.Windows.Forms.Button();
            this.btnBamVao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJoke
            // 
            this.btnJoke.Location = new System.Drawing.Point(133, 116);
            this.btnJoke.Name = "btnJoke";
            this.btnJoke.Size = new System.Drawing.Size(138, 36);
            this.btnJoke.TabIndex = 1;
            this.btnJoke.Text = "Joke of the day";
            this.btnJoke.UseVisualStyleBackColor = true;
            this.btnJoke.Click += new System.EventHandler(this.btnJoke_Click);
            // 
            // btnBamVao
            // 
            this.btnBamVao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBamVao.Location = new System.Drawing.Point(408, 116);
            this.btnBamVao.Name = "btnBamVao";
            this.btnBamVao.Size = new System.Drawing.Size(75, 35);
            this.btnBamVao.TabIndex = 0;
            this.btnBamVao.Text = "bấm vào";
            this.btnBamVao.UseVisualStyleBackColor = true;
            this.btnBamVao.Click += new System.EventHandler(this.btnBamVao_Click);
            // 
            // frmTest1
            // 
            this.AcceptButton = this.btnJoke;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBamVao;
            this.ClientSize = new System.Drawing.Size(648, 353);
            this.Controls.Add(this.btnBamVao);
            this.Controls.Add(this.btnJoke);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmTest1";
            this.Text = "Test 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJoke;
        private System.Windows.Forms.Button btnBamVao;
    }
}



namespace TP1_PBO
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.btnBeli = new System.Windows.Forms.Button();
            this.lblJenis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempatGambar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempatGambar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(46, 167);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(99, 17);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama_Barang";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(46, 199);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(30, 17);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Rp.";
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(25, 263);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(143, 28);
            this.btnBeli.TabIndex = 3;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(46, 229);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(41, 17);
            this.lblJenis.TabIndex = 4;
            this.lblJenis.Text = "Jenis";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tempatGambar);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 161);
            this.panel1.TabIndex = 5;
            // 
            // tempatGambar
            // 
            this.tempatGambar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tempatGambar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempatGambar.Location = new System.Drawing.Point(0, 0);
            this.tempatGambar.Name = "tempatGambar";
            this.tempatGambar.Size = new System.Drawing.Size(190, 161);
            this.tempatGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tempatGambar.TabIndex = 0;
            this.tempatGambar.TabStop = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblNama);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(191, 313);
            this.Load += new System.EventHandler(this.ListItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tempatGambar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tempatGambar;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Panel panel1;
    }
}

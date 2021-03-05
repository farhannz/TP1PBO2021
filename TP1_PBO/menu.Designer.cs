
namespace TP1_PBO
{
    partial class menu
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
            this.btnHome = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.jenisBarang = new System.Windows.Forms.ComboBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblRangeHarga = new System.Windows.Forms.Label();
            this.rangeHarga = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempatTampilin = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(161, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(101, 82);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.logout);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(562, 70);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 17);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username :";
            // 
            // jenisBarang
            // 
            this.jenisBarang.FormattingEnabled = true;
            this.jenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.jenisBarang.Location = new System.Drawing.Point(15, 164);
            this.jenisBarang.Name = "jenisBarang";
            this.jenisBarang.Size = new System.Drawing.Size(119, 24);
            this.jenisBarang.TabIndex = 5;
            this.jenisBarang.Text = "-";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(12, 144);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(99, 17);
            this.lblJenis.TabIndex = 6;
            this.lblJenis.Text = "Jenis Barang :";
            // 
            // lblRangeHarga
            // 
            this.lblRangeHarga.AutoSize = true;
            this.lblRangeHarga.Location = new System.Drawing.Point(12, 212);
            this.lblRangeHarga.Name = "lblRangeHarga";
            this.lblRangeHarga.Size = new System.Drawing.Size(101, 17);
            this.lblRangeHarga.TabIndex = 8;
            this.lblRangeHarga.Text = "Range Harga :";
            // 
            // rangeHarga
            // 
            this.rangeHarga.FormattingEnabled = true;
            this.rangeHarga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.rangeHarga.Location = new System.Drawing.Point(15, 232);
            this.rangeHarga.Name = "rangeHarga";
            this.rangeHarga.Size = new System.Drawing.Size(119, 24);
            this.rangeHarga.TabIndex = 7;
            this.rangeHarga.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Catalog";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(15, 272);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 10;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tempatTampilin);
            this.panel1.Location = new System.Drawing.Point(166, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 373);
            this.panel1.TabIndex = 11;
            // 
            // tempatTampilin
            // 
            this.tempatTampilin.AutoScroll = true;
            this.tempatTampilin.AutoSize = true;
            this.tempatTampilin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempatTampilin.Location = new System.Drawing.Point(0, 0);
            this.tempatTampilin.Name = "tempatTampilin";
            this.tempatTampilin.Size = new System.Drawing.Size(916, 373);
            this.tempatTampilin.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnKembali);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.btnCari);
            this.panelMain.Controls.Add(this.lblRangeHarga);
            this.panelMain.Controls.Add(this.rangeHarga);
            this.panelMain.Controls.Add(this.lblJenis);
            this.panelMain.Controls.Add(this.jenisBarang);
            this.panelMain.Controls.Add(this.lbUsername);
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.button2);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1111, 535);
            this.panelMain.TabIndex = 12;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(15, 96);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 12;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Visible = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 535);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "menu";
            this.Text = "Menu Utama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ComboBox jenisBarang;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblRangeHarga;
        private System.Windows.Forms.ComboBox rangeHarga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel tempatTampilin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnKembali;
    }
}
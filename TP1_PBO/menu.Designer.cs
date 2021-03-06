
namespace TP1_PBO
{
    partial class Menu
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.jenisBarang = new System.Windows.Forms.ComboBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblRangeHarga = new System.Windows.Forms.Label();
            this.rangeHarga = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempatTampilin = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.catalog = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(634, 102);
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
            this.panelMain.Controls.Add(this.lblNama);
            this.panelMain.Controls.Add(this.lblNim);
            this.panelMain.Controls.Add(this.btnKembali);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.btnCari);
            this.panelMain.Controls.Add(this.lblRangeHarga);
            this.panelMain.Controls.Add(this.rangeHarga);
            this.panelMain.Controls.Add(this.lblJenis);
            this.panelMain.Controls.Add(this.jenisBarang);
            this.panelMain.Controls.Add(this.lbUsername);
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.catalog);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1111, 535);
            this.panelMain.TabIndex = 12;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(911, 54);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(171, 17);
            this.lblNama.TabIndex = 14;
            this.lblNama.Text = "Nama : Farhan Nurzaman";
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(911, 25);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(100, 17);
            this.lblNim.TabIndex = 13;
            this.lblNim.Text = "NIM : 1904908";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(15, 91);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 28);
            this.btnKembali.TabIndex = 12;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Visible = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // button3
            // 
            this.button3.Image = global::TP1_PBO.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(459, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.logout);
            // 
            // catalog
            // 
            this.catalog.Image = global::TP1_PBO.Properties.Resources.shopping_cart1;
            this.catalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalog.Location = new System.Drawing.Point(302, 37);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(151, 82);
            this.catalog.TabIndex = 1;
            this.catalog.Text = "Catalog";
            this.catalog.UseVisualStyleBackColor = true;
            this.catalog.Click += new System.EventHandler(this.catalogClick);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::TP1_PBO.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(161, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(135, 82);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.homeClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 535);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
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
        private System.Windows.Forms.Button catalog;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel tempatTampilin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNim;
    }
}
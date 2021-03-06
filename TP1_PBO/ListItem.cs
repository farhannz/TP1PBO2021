using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_PBO
{
    public partial class ListItem : UserControl
    {
        private string _NamaBarang;
        private int _HargaBarang;
        private string _JenisBarang;
        private Image _Gambar;
        private Menu formMenu;
        private bool _clicked = false;
        public string Nama
        {
            get { return _NamaBarang; }
            set { _NamaBarang = value; }
        }
        public int Harga
        {
            get { return _HargaBarang; }
            set { _HargaBarang = value; }
        }
        public string Jenis
        {
            get { return _JenisBarang; }
            set { _JenisBarang = value; }
        }
        public Image Gambar
        {
            get { return _Gambar; }
            set { _Gambar = value; }
        }
        public bool diKlik
        {
            get { return _clicked; }
            set { this._clicked = value; }
        }
        public ListItem()
        {
            InitializeComponent();
        }
        public ListItem(Menu m)
        {
            InitializeComponent();
            this.formMenu = m;
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            lblNama.Text = this.Nama;
            lblHarga.Text += " " + String.Format("{0:n0}",this._HargaBarang);
            lblJenis.Text = this.Jenis;
            tempatGambar.Image = Gambar;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
             formMenu.switchTampilan(this);
        }
    }
}

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
        public ListItem()
        {
            InitializeComponent();
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            lblNama.Text = this.Nama;
            lblHarga.Text += " " + this.Harga.ToString();
            lblJenis.Text = this.Jenis;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            
        }
    }
}

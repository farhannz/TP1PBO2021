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
    public partial class Menu : Form
    {
        public static bool _visible = true;
        private ListItem _detailItem;
        private ListItem[] items = new ListItem[16];
        public Menu()
        {
            InitializeComponent();
        }
        private void menu_Load(object sender, EventArgs e)
        {
            lbUsername.Text = lbUsername.Text + " " + Form1.UsernameValue;
            isiData();
            tampilData("","");
        }
        public void switchTampilan(ListItem detailItem)
        {
            if(detailItem.diKlik == false)
            {
                _visible = !(_visible);
                lblJenis.Visible = _visible;
                lblRangeHarga.Visible = _visible;
                jenisBarang.Visible = _visible;
                rangeHarga.Visible = _visible;
                btnCari.Visible = _visible;
                btnKembali.Visible = !(_visible);
                if (tempatTampilin.Controls.Count > 0)
                {
                    tempatTampilin.Controls.Clear();
                    tempatTampilin.Controls.Add(detailItem);
                }
                detailItem.diKlik = true;
            }
            this._detailItem = detailItem;
            /*if (pilih == 1)
            {
                foreach (ListItem isi in items)
                {
                    if (isi.isClicked == true)
                    {
                        if (tempatTampilin.Controls.Count > 0)
                        {
                            tempatTampilin.Controls.Clear();
                        }
                        tempatTampilin.Controls.Add(isi);
                        break;
                    }
                }
            }*/
        }
        private void isiData()
        {
            string[] a = new string[] { "Makanan", "Baju", "Elektronik" };
            Random _rand = new Random();
            for (int i = 0; i < items.Length; ++i)
            {
                items[i] = new ListItem(this);
                items[i].Nama = "Yooz";
                items[i].Harga = _rand.Next(3, 8) * 100000;
                items[i].Jenis = a[_rand.Next(0, a.Length)];
            }
        }
        private void tampilData(string jenis, string harga)
        {
            int i = 0;
            char pilih;
            if (harga.Contains("100rb -"))
            {
                pilih = 'a';
            }
            else if(harga.Contains("200rb -"))
            {
                pilih = 'b';
            }
            else if(harga.Contains("500rb -"))
            {
                pilih = 'c';
            }
            else
            {
                pilih = 'd';
            }
            foreach(ListItem isi in items)
            {
                if(isi.Jenis.Contains(jenis) && 
                    ((pilih =='a' && isi.Harga >= 100000 && isi.Harga <= 200000)||
                    (pilih == 'b' && isi.Harga >= 200000 && isi.Harga <= 500000) ||
                    (pilih == 'c' && isi.Harga >= 500000 && isi.Harga <= 1000000)||
                    (pilih == 'd' && isi.Harga >  0)))
                {

                    tempatTampilin.Controls.Add(isi);
                    if (i % 4 == 3)
                    {
                        tempatTampilin.SetFlowBreak(isi, true);
                    }
                    else
                    {
                        tempatTampilin.SetFlowBreak(isi, false);
                    }
                    ++i;
                }
            }
        }
        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.fOpc = 1.0f;
        }

        private void logout(object sender, EventArgs e)
        {
            Form1.fOpc = 1.0f;
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            String cari = jenisBarang.Text;
            String cariH = rangeHarga.Text;
            if (cari == "-") cari = "";
            if(tempatTampilin.Controls.Count > 0)
            {
                tempatTampilin.Controls.Clear();
            }
            tampilData(cari,cariH);
        }

        private void homeClick(object sender, EventArgs e)
        {
            tampilData("", "");
            jenisBarang.Text = "-";
            rangeHarga.Text = "-";
        }

        private void catalogClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tokopedia.com");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

            this._detailItem.diKlik = false;
            _visible = !(_visible);
            lblJenis.Visible = _visible;
            lblRangeHarga.Visible = _visible;
            jenisBarang.Visible = _visible;
            rangeHarga.Visible = _visible;
            btnCari.Visible = _visible;
            btnKembali.Visible = !(_visible);
            tampilData("", "");
        }
    }
}

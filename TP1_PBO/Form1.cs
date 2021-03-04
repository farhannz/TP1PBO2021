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
    public partial class Form1 : Form
    {
        public static string UsernameValue;
        public static float fOpc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(textPass.Text == "pbo123")
            {
                menu utama = new menu();
                //this.Opacity = 0.0f;
                this.Hide();
                UsernameValue = textUsername.Text;
                textPass.ResetText();
                textUsername.ResetText();
                utama.ShowDialog();
                //this.Opacity = fOpc;
                this.Show();
            }
            else
            {
                MessageBox.Show("Maaf password salah!");
                textPass.ResetText();
                textUsername.ResetText();
            }
        }
    }
}

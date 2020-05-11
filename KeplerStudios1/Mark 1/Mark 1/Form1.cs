using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mark_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = DRKEPLER\KEPLERSQL; Initial Catalog = guvenlik; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSeaGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kullanici_ad = textBox1.Text;
            string kullanici_sifre = textBox2.Text;
            veritabani_sinifi islemim = new veritabani_sinifi();
            islemim.girisYap(kullanici_ad, kullanici_sifre, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }

        void ogrencigetir()
        {
            baglanti = new SqlConnection(@"Data Source=DRKEPLER\KEPLERSQL;Initial Catalog=Sınav;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT*FROM sinav12", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ogrencigetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sinav12 (ders,derslik,gözetmen,tarih) values (@ders,@derslik,@gözetmen,@tarih)", baglanti);
            
            komut.Parameters.AddWithValue("@ders", comboBox1.Text);
            komut.Parameters.AddWithValue("@derslik", comboBox2.Text);
            komut.Parameters.AddWithValue("@gözetmen", comboBox3.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            komut.ExecuteNonQuery();
            ogrencigetir();
            baglanti.Close();

            


            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

           



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sinav12 where sira=@sira", baglanti);
            komut.Parameters.AddWithValue("@sira",textBox1.Text);
            komut.ExecuteNonQuery();
            ogrencigetir();
            baglanti.Close();



            


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}

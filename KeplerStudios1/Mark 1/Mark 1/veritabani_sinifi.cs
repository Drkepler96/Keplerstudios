using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mark_1
{
    class veritabani_sinifi
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DRKEPLER\KEPLERSQL;Initial Catalog=guvenlik;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public void girisYap(string ad, string sifre, Form frm1)
        {
            command = new SqlCommand("Select * From parola1 where ad='"+ad+"' and sifre='"+sifre+"'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 frm2 = new Form2();
                frm1.Hide();
                frm2.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Hatali giriş");
            }
            connection.Close();
            command.Dispose();
        }

    }
}

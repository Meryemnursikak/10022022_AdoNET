using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10022022_AdoNETgİRİS
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        //SqlConnection baglantiu = new SqlConnection("Server = .;Database=KuzeyYeli;Integrated Security=true");
        SqlConnection baglantiu = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        private void Urunler_Load(object sender, EventArgs e)
        {
            UrunListesi();

        }

        private void UrunListesi()
        {
            SqlDataAdapter adp2 = new SqlDataAdapter("select * from Urunler where Sonlandi=0", baglantiu);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);  //adp den dönen bilgiyi datatable e doldur.
            dataGridView1.DataSource = dt2;
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand();
            //string urunad = txturunadi.Text;
            //decimal fiyat = nudfiyat.Value;
            //int stok = (int)nudstok.Value;
            //komut.CommandText = string.Format
            //    ("insert into Urunler(UrunAdi,Fiyat,Stok) values('{0}',{1},{2})",urunad,fiyat,stok);
            //güvenlik açığından dolayı kullanılmaz

            //diğer yöntemi:parametre ile çağırmak
            //komut.CommandText =
            //    "insert Urunler(UtunAdi, Fiyat, Stok) values(@ad,@fiyat,@stok)";
            //komut.Parameters.AddWithValue("@ad", txturunadi.Text);
            //komut.Parameters.AddWithValue("@fiyat", nudfiyat.Value);
            //komut.Parameters.AddWithValue("@stok", nudfiyat.Value);


            //komut.Connection = baglantiu;
            //baglantiu.Open();
            //int kayit = komut.ExecuteNonQuery();
            //if (kayit>0)
            //{
            //    MessageBox.Show("Kayıt Başarıyla Eklendi.");
            //}
            //else
            //{
            //    MessageBox.Show("Kayıt ekleme sırasında hata oluştu.");
            //}
            
            //baglantiu.Close();
            //UrunListesi();
            

            
        }

        private void btnkategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler kf = new Kategoriler();
            kf.Show();
        }


        //son yöntem prosedür ile ekleme işlemi
        private void btnekle_sp_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", baglantiu);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@urunad", txturunadi.Text);
            komut.Parameters.AddWithValue("@fiyat", nudfiyat.Value);
            komut.Parameters.AddWithValue("@stok", nudfiyat.Value);
            baglantiu.Open();
            komut.ExecuteNonQuery();
            baglantiu.Close();
            UrunListesi();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand komut = new SqlCommand("UrunSil", baglantiu);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@urunid", dataGridView1.CurrentRow.Cells["UrunID"].Value);
                baglantiu.Open();
                komut.ExecuteNonQuery();
                baglantiu.Close();
                UrunListesi();
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

      
    }
}

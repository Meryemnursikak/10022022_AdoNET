using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10022022_AdoNETgİRİS
{
    public partial class Kategoriler : Form
    {
        private object SqlConnection;

        public Kategoriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =
                new SqlConnection("Server = .;Database=KuzeyYeli;Integrated Security=true");

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategoriListesi();

        }

        private void KategoriListesi()
        {
            //Disconnected mimariye örnek:
            //DataAdapter açma kapama işlemlerini otomatik yapıyor fakat sadece selectler için
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler", baglanti);

            DataTable dt = new DataTable();
            adp.Fill(dt);  //adp den dönen bilgiyi datatable e doldur.
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["KategoriID"].Visible = false;
        }



        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format
                ("insert into Kategoriler(KategoriAdi,Tanimi) values('{0}','{1}')", txtad.Text, txttanim.Text);
            komut.Connection = baglanti;
            baglanti.Open();
            

            //
            try
            {
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kategori Eklendi");
                }
                else
                {
                    MessageBox.Show("Kategori Ekleme Sırasında Hata Oluştu");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu."+ex.Message);
            }

            finally
            {
                baglanti.Close();
            }
            KategoriListesi();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand komut = new SqlCommand("KategoriSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@katid", dataGridView1.CurrentRow.Cells["KategoriID"].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KategoriListesi();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand komut = new SqlCommand("KategoriGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["KategoriID"].Value);
            komut.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells["KategoriAdi"].Value);
            komut.Parameters.AddWithValue("@tanim", dataGridView1.CurrentRow.Cells["Tanimi"].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KategoriListesi();
        }
    }
}

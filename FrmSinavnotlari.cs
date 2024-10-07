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
using System.Diagnostics.Eventing.Reader;

namespace BonusOkul
{
    public partial class FrmSinavnotlari : Form
    {
        public FrmSinavnotlari()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private string Durum;
      
        

        #region SINAV NOT LİSTESİ YENİLEME 
        void listele()
        {


            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();

            DataTable zk = new DataTable();
            SqlDataAdapter dk = new SqlDataAdapter("select * from NotListesi", con);
            dk.Fill(zk);
            datgrsinav.DataSource = zk;

            con.Close();


        }
        #endregion

        #region BACK BUTTON TASK
        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgretmenMenu frmOgretmen = new FrmOgretmenMenu();
            frmOgretmen.Show();
            this.Hide();
        }
        #endregion

        #region FORMLOAD OLDUĞUNDA 
        private void FrmSinavnotlari_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(bgl.Adres);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select OgrId,(OgrAd+''+OgrSoyad) as Ad_Soyad,OgrCinsiyet from TblOgrenciler", con1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            datgrogr.DataSource = dt;
            con1.Close();

            con1.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select*from TblDersler", con1);
            da2.Fill(dt2);
            datgrders.DataSource = dt2;
            con1.Close();

            listele();


        }
        #endregion

        #region ÖĞRENCİ DATAGRİDİNDEN VERİ ALMA 
        private void datgrogr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayı = datgrogr.SelectedCells[0].RowIndex;

            txtogrId.Text = datgrogr.Rows[sayı].Cells[0].Value.ToString();
        }
        #endregion

        #region DERS DATAGRİDİNDEN VERİ ALMA 
        private void datgrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayı = datgrders.SelectedCells[0].RowIndex;
            txtdersId.Text = datgrders.Rows[sayı].Cells[0].Value.ToString();
        }
        #endregion

        #region ARA BUTTON TASK
        private void btnAra_Click(object sender, EventArgs e)
        {

            string sorgu = txtSorgula.Text;
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from NotListesi where Ad_Soyad like '%" + sorgu + "%'", con);


            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd1);
            da3.Fill(dt3);
            datgrsinav.DataSource = dt3;
            con.Close();


        }
        #endregion

        #region lIST BUTTON TASK
        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
        #endregion

        #region SINAVNOT DATAGRİDİNDEN VERİ ÇEKME
        private void datgrsinav_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int sayı = datgrsinav.SelectedCells[0].RowIndex;
            string ad = "", ders = "";

            txtnotId.Text = datgrsinav.Rows[sayı].Cells[0].Value.ToString();
            txtsinav1.Text = datgrsinav.Rows[sayı].Cells[3].Value.ToString();
            txtsinav2.Text = datgrsinav.Rows[sayı].Cells[4].Value.ToString();
            txtsinav3.Text = datgrsinav.Rows[sayı].Cells[5].Value.ToString();
            txtproje.Text = datgrsinav.Rows[sayı].Cells[6].Value.ToString();
            ad = datgrsinav.Rows[sayı].Cells[1].Value.ToString();
            ders = datgrsinav.Rows[sayı].Cells[2].Value.ToString();

            SqlConnection con = new SqlConnection(bgl.Adres);

            con.Open();
            SqlCommand cmd = new SqlCommand("select OgrId,(OgrAd+''+OgrSoyad) as Ad_Soyad from TblOgrenciler tog " +
                "where tog.OgrAd+''+OgrSoyad='" + ad + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtogrId.Text = dr[0].ToString();
            }
            con.Close();


            SqlConnection con1 = new SqlConnection(bgl.Adres);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from TblDersler where DersAd = '" + ders + "'", con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtdersId.Text = dr1[0].ToString();
            }
            con1.Close();

        }
        #endregion

        #region INSERT BUTTON TASK
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection(bgl.Adres);
            bag.Open();

            SqlCommand cmd = new SqlCommand("insert into  tblnotlar (DersId,OgrId,Sınav1,Sınav2,Sınav3,Proje) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag);
            cmd.Parameters.AddWithValue("@p1", txtdersId.Text);
            cmd.Parameters.AddWithValue("@p2", txtogrId.Text);
            cmd.Parameters.AddWithValue("@p3", txtsinav1.Text);
            cmd.Parameters.AddWithValue("@p4", txtsinav2.Text);
            cmd.Parameters.AddWithValue("@p5", txtsinav3.Text);
            cmd.Parameters.AddWithValue("@p6", txtproje.Text);
            cmd.ExecuteReader();

            bag.Close();

            MessageBox.Show("Kayıt Başarılı Şekilde Gerçekleştirildi.");
        }




        #endregion

        #region UPDATE BUTTON TASK
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand kom = new SqlCommand("update  tblnotlar set DersId=@p1,OgrId=@p2,Sınav1=@p3,Sınav2=@p4,Sınav3=@p5," +
                "Proje=@p6 where NotId=@p7", con);
            kom.Parameters.AddWithValue("@p1", txtdersId.Text);
            kom.Parameters.AddWithValue("@p2", txtogrId.Text);
            kom.Parameters.AddWithValue("@p3", txtsinav1.Text);
            kom.Parameters.AddWithValue("@p4", txtsinav2.Text);
            kom.Parameters.AddWithValue("@p5", txtsinav3.Text);
            kom.Parameters.AddWithValue("@p6", txtproje.Text);
            kom.Parameters.AddWithValue("@p7", txtnotId.Text);
            kom.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Öğrenci Bilgileri Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion


        #region DELETE BUTTON TASK 
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand kom = new SqlCommand("delete from tblNotlar where NotId=@p1", con);
            kom.Parameters.AddWithValue("@p1", txtnotId.Text);
            kom.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(" Öğrenci Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

    
    
	

	
    }
}

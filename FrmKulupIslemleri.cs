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

namespace BonusOkul
{
    public partial class FrmKulupIslemleri : Form
    {
        public FrmKulupIslemleri()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();



        void list()
        {
            SqlConnection con1 = new SqlConnection(bgl.Adres);
            con1.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tblKulup", con1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con1.Close();
            txtkulupid.Text = "";
            txtkulupad.Text = "";
        }


        private void FrmKulupIslemleri_Load(object sender, EventArgs e)
        {

            list();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgretmenMenu fo = new FrmOgretmenMenu();
            fo.Show();
            this.Hide();
        }


        private void btnlist_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn5 = new SqlConnection(bgl.Adres);
            conn5.Open();
            SqlCommand cmd5 = new SqlCommand("delete tblkulup  where kulupId=@p2", conn5);            
            cmd5.Parameters.AddWithValue("@p2", txtkulupid.Text);
            cmd5.ExecuteNonQuery();
            conn5.Close();
            list();
            MessageBox.Show("Kulup Silindi!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection(bgl.Adres);
                con2.Open();
                SqlCommand komut1 = new SqlCommand("insert into  tblkulup (KulupAd) values (@p1)  ", con2);
                komut1.Parameters.AddWithValue("@p1", txtkulupad.Text);
                komut1.ExecuteNonQuery();
                con2.Close();
                list();
                MessageBox.Show("Kulüp Eklendi!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception msj)
            {

                MessageBox.Show("HATA VAR, GİRDİĞİNİZ DEĞERLERİ KONTROL EDİN!!!"+"\n"+msj.ToString(),"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayac = dataGridView1.SelectedCells[0].RowIndex;

            txtkulupid.Text = dataGridView1.Rows[sayac].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[sayac].Cells[1].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn5 = new SqlConnection(bgl.Adres);
            conn5.Open();
            SqlCommand cmd5 = new SqlCommand("update  tblkulup set kulupAd=@p1 where kulupId=@p2", conn5);
            cmd5.Parameters.AddWithValue("@p1", txtkulupad.Text);
            cmd5.Parameters.AddWithValue("@p2", txtkulupid.Text);
            cmd5.ExecuteNonQuery();
            conn5.Close();
            list();
            MessageBox.Show("Kulup Güncellendi!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

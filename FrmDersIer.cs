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

namespace BonusOkul
{
    public partial class FrmDersIer : Form
    {
        public FrmDersIer()
        {
            InitializeComponent();
        }
        
        Baglanti bgl = new Baglanti();
        FrmOgretmenMenu da=new FrmOgretmenMenu();
        void listele()
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbldersler order by dersId desc", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        private void FrmDersIer_Load(object sender, EventArgs e)
        {
           
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ders = dataGridView1.SelectedCells[0].RowIndex;
            txtdersid.Text = dataGridView1.Rows[ders].Cells[0].Value.ToString();
            txtdersad.Text = dataGridView1.Rows[ders].Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgretmenMenu fr = new FrmOgretmenMenu();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("insert into tbldersler (dersad) values (@p1) ", conn);
            komut1.Parameters.AddWithValue("@p1", txtdersad.Text);
            komut1.ExecuteNonQuery();
            conn.Close();
            listele();

            MessageBox.Show("Ders Eklendi!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection(bgl.Adres);
            conn2.Open();
            SqlCommand komut2 = new SqlCommand("delete from tbldersler where dersId=@p1", conn2);
            komut2.Parameters.AddWithValue("@p1", txtdersid.Text);
            komut2.ExecuteNonQuery();
            conn2.Close();
            listele();
            MessageBox.Show("Ders silindi!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn3 = new SqlConnection(bgl.Adres);
            conn3.Open();
            SqlCommand komut3 = new SqlCommand("update  tbldersler set DersAd=@p2 where dersId=@p1",conn3);       
            komut3.Parameters.AddWithValue("@p1",txtdersid.Text);
            komut3.Parameters.AddWithValue("@p2", txtdersad.Text);
            komut3.ExecuteNonQuery();
            conn3.Close();
            listele();
            MessageBox.Show("Ders Güncellendi!!!","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}

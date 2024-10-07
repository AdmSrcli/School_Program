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
    public partial class FrmOgretmenislemleri : Form
    {
        public FrmOgretmenislemleri()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        #region METHOT LIST
        void list()
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from TblOgretmen", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region BACK BUTTON TASK
        private void btnback_Click(object sender, EventArgs e)
        {
            FrmOgretmenMenu frm = new FrmOgretmenMenu();
            frm.Show();
            this.Hide();
        }

        #endregion

        #region FORMLOAD TASK 
        private void FrmOgretmenislemleri_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand cmd = new SqlCommand("select DersAd from TblDersler", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0]);
            }
            con.Close();
            list();
        }

        #endregion

        #region CMBBRANS SELECTED INDEX TASK
        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbadsoyad.Items.Clear();

            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand cmd = new SqlCommand("select OgrtId,DersAd,OgrtAdSoyad from TblOgretmen tu inner join TblDersler td on tu.OgrtId=td.DersId where dersad=@p1", con);
            cmd.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbadsoyad.Items.Add(dr[2]);

            }
            con.Close();
            list();
        }
        #endregion

        #region DATAGRİDE VERİ ÇEKME 
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayac = dataGridView1.SelectedCells[0].RowIndex;

            txtogretmenId.Text = dataGridView1.Rows[sayac].Cells[0].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[sayac].Cells[1].Value.ToString();
            cmbadsoyad.Text = dataGridView1.Rows[sayac].Cells[2].Value.ToString();

        }

        #endregion

        #region LIST BUTTUN TASK 
        private void btnlist_Click(object sender, EventArgs e)
        {
            list();
        }
        #endregion

        #region DELETE BUTTON TASK 
        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection(bgl.Adres);
            conn2.Open();
            SqlCommand komut2 = new SqlCommand("delete from tblogretmen where ogrtId=@p1", conn2);
            komut2.Parameters.AddWithValue("@p1", txtogretmenId.Text);
            komut2.ExecuteNonQuery();
            conn2.Close();
            list();
            MessageBox.Show("Ders silindi!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region UPDATE BUTON TASK
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand kom = new SqlCommand("update  Tblogretmen set ogrtbrans=@p1,ogrtadsoyad=@p2 where ogrtId=@p3", con);
            kom.Parameters.AddWithValue("@p1", cmbbrans.Text);
            kom.Parameters.AddWithValue("@p2", cmbadsoyad.Text);
            kom.Parameters.AddWithValue("@p3", txtogretmenId.Text);
            kom.ExecuteNonQuery();
            con.Close();
            list();
            MessageBox.Show("Öğretmen Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region INSERT BUTON TASK
        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("insert into tblogretmen (ogrtbrans,ogrtadsoyad) values (@p1,@p2)",con);
            komut.Parameters.AddWithValue("@p1",cmbbrans.Text);
            komut.Parameters.AddWithValue("@p2", cmbadsoyad.Text);
            komut.ExecuteNonQuery();
            con.Close ();
            list();
            MessageBox.Show("Öğretmen Eklendi!","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion
    }
}

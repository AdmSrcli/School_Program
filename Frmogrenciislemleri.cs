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
    public partial class Frmogrenciislemleri : Form
    {
        public Frmogrenciislemleri()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        #region METHOD LISTELE
        void listele()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TblOgrenciler order by ogrId desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        #endregion

        #region FRMLOAD TASK
        private void Frmogrenciislemleri_Load(object sender, EventArgs e)
        {
            listele();

        }
        #endregion

        #region DATAGRİDE VERİLERİ ÇEKME
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int say = dataGridView1.SelectedCells[0].RowIndex;
            txtogrid.Text = dataGridView1.Rows[say].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[say].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[say].Cells[2].Value.ToString();
            cmbkulup.Text = dataGridView1.Rows[say].Cells[3].Value.ToString();
            cmbcinsiyet.Text = dataGridView1.Rows[say].Cells[4].Value.ToString();

        }
        #endregion

        #region INSERT BUTTON TASK
        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblogrenciler (ograd,ogrsoyad,ogrkulup,ogrcinsiyet)" +
                "values (@p1,@p2,@p3,@p4) ", con);
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbkulup.Text);
            cmd.Parameters.AddWithValue("@p4", cmbcinsiyet.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            listele();
            MessageBox.Show("Öğrenci Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        #region LIST BUTTON TASK
        private void btnlist_Click(object sender, EventArgs e)
        {
            listele();
        }
        #endregion

        #region DELETE BUTTON TASK
        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tblogrenciler where ogrId=@p1", con);
            cmd.Parameters.AddWithValue("@p1", txtogrid.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            listele();
            MessageBox.Show("Öğrenci Başarılı Şekilde Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region UPDATE BUTTON TASK 
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand command = new SqlCommand("update  tblogrenciler set Ograd=@p2,ogrsoyad=@p3,ogrkulup=@p4,ogrcinsiyet=@p5 where OgrId=@p1", con);
            command.Parameters.AddWithValue("@p1",txtogrid.Text);
            command.Parameters.AddWithValue("@p2", txtad.Text);
            command.Parameters.AddWithValue("@p3", txtsoyad.Text);
            command.Parameters.AddWithValue("@p4", cmbkulup.Text);
            command.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            command.ExecuteNonQuery();
            con.Close() ;
            listele();
            MessageBox.Show("Öğrenci Güncellendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        #endregion


    }
}

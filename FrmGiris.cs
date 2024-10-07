
 using System.Data.SqlClient;
 using System.Data;


namespace BonusOkul
{

    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();
        public string GirisId;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from tblogrenciler where ogrId=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", txtkullanicino.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrencidetay ogr = new FrmOgrencidetay();
                ogr.id = txtkullanicino.Text;
                ogr.isim = dr[1] + " " + dr[2];
                ogr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerde öğrenci yok,Kontrol edip tekrar deneyiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GirisId = txtkullanicino.Text;
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from tblogretmen where ogrtId=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", GirisId);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmenMenu men=new FrmOgretmenMenu();               
                men.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerde Öğretmen yok, Lütfen Kontrol edip tekrar deneyiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
    }
}

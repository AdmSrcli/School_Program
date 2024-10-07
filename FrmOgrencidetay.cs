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
    public partial class FrmOgrencidetay : Form
    {
        public FrmOgrencidetay()
        {
            InitializeComponent();
        }
        FrmGiris fd=new FrmGiris();        
        Baglanti bgl=new Baglanti();  
        
        public string isim;
        public string id;
      

        private void FrmOgrencidetay_Load(object sender, EventArgs e)
        {
           
            this.Text= isim;
           

            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select (OgrAd+''+OgrSoyad) as OgrenciAdSoyad,DersAd,Sınav1,Sınav2,Sınav3,Proje,Ortalama,Durum from TblNotlar tn " +
                "inner join TblDersler td on tn.DersId=td.DersId " +
                "inner join TblOgrenciler tg on tn.OgrId=tg.OgrId " +
                "where tn.ogrId=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", id.ToString());

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
    }
}

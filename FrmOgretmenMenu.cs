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
    public partial class FrmOgretmenMenu : Form
    {
        public FrmOgretmenMenu()
        {
            InitializeComponent();
        }



        private void FrmOgretmenMenu_Load(object sender, EventArgs e)
        {



        }

        private void btndersislemleri_Click(object sender, EventArgs e)
        {
            FrmDersIer frd = new FrmDersIer();
            frd.Show();
            this.Hide();

        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Blue;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnklup_Click(object sender, EventArgs e)
        {
            FrmKulupIslemleri fk = new FrmKulupIslemleri();
            fk.Show();
            this.Hide();
        }

        private void btnogretmenislemleri_Click(object sender, EventArgs e)
        {
            FrmOgretmenislemleri fri = new FrmOgretmenislemleri();
            fri.Show();
            this.Hide();
        }

        private void btnogrenciislemleri_Click(object sender, EventArgs e)
        {
            Frmogrenciislemleri fr = new Frmogrenciislemleri();
            fr.Show();
            this.Hide();
        }

        private void btnsinavnotları_Click(object sender, EventArgs e)
        {
            FrmSinavnotlari frd=new FrmSinavnotlari();
            frd.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Resepsiyon_Otomasyonu
{
    public partial class Formgiris : Form
    {
       
        SqlDataReader dr;
        SqlCommand komut;
        public Formgiris()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        private void Formgiris_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureKucult_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PictureKucult, "Simge Durumuna Küçült");
        }

        private void PictureKapat_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PictureKapat, "Kapat");
        }

        private void PictureKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBoxKullanici.Text;
            string password = textBoxSifre.Text; 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");
            komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "Select*From KullaniciGiris where kullaniciadi = '" + textBoxKullanici.Text + "'And sifre = '" + textBoxSifre.Text + "'";
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                
                FormMainMenu gecis = new FormMainMenu();
                gecis.Show();
                this.Hide();
                
            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre.");
            }
            con.Close();
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Şifreyi Göster");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Şifreyi Gizle");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide ();
            textBoxSifre.UseSystemPasswordChar = false;
            pictureBoxHide.Show ();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide ();
            textBoxSifre.UseSystemPasswordChar = true;
            pictureBoxShow.Show ();
        }

        private void KytOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterSayfasi frm = new FormRegisterSayfasi();
            frm.Show();
        }

        private void kullanıcı_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

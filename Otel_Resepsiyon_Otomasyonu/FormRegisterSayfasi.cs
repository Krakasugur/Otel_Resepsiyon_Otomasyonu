using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Otel_Resepsiyon_Otomasyonu
{
    public partial class FormRegisterSayfasi : Form
    {
        public FormRegisterSayfasi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");
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
            pictureBoxShow.Hide();
            textBoxSifre.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxSifre.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void PictureKucult_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PictureKucult, "Simge Durumuna Küçült");
        }

        private void PictureKapat_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PictureKapat, "Kapat");
        }

        private void PictureKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBoxKullanici.Text;
            string sifre = textBoxSifre.Text;

            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                return;
            }

            string sorgu = "INSERT INTO KullaniciGiris(kullaniciadi, sifre) VALUES (@kul, @sifre)";
            SqlCommand komut = new SqlCommand(sorgu, connect);
            komut.Parameters.AddWithValue("@kul", kullaniciadi);
            komut.Parameters.AddWithValue("@sifre", sifre);

            try
            {
                connect.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı.");
                textBoxKullanici.Clear();
                textBoxSifre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Geri Dön");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

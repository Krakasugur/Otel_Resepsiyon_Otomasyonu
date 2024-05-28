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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_Resepsiyon_Otomasyonu
{
    public partial class FormParola : Form
    {
        public FormParola()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();

            if (string.IsNullOrWhiteSpace(textBoxKullanici.Text) || string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
            else
            {
                
                SqlCommand komut10 = new SqlCommand("update KullaniciGiris set kullaniciadi=@kullaniciadi, sifre=@sifre", connect);
                komut10.Parameters.AddWithValue("@kullaniciadi", textBoxKullanici.Text);
                komut10.Parameters.AddWithValue("@sifre", textBoxSifre.Text);

               
                int affectedRows = komut10.ExecuteNonQuery();

                connect.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Parolanız başarıyla güncellendi.");
                }
            }

            connect.Close();
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

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Şifreyi Göster");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Şifreyi Gizle");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Geri Dön");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Kapat");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormMainMenu geridon = new FormMainMenu();
            geridon.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string kullaniciadi = textBoxKullanici.Text;
            string sifre = textBoxSifre.Text;

            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                return;
            }

            
            bool kayitVarMi = KayitKontrolEt(kullaniciadi, sifre);

            if (!kayitVarMi)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
                return;
            }

            
            SilVeritabaniVerileri(kullaniciadi, sifre);

            
            Formgiris gec = new Formgiris();
            gec.Show();
            this.Hide();
        }

        private bool KayitKontrolEt(string kullaniciadi, string sifre)
        {
            bool kayitVarMi = false;

            try
            {
                
                connect.Open();

                
                string query = "SELECT COUNT(*) FROM KullaniciGiris WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre";
                SqlCommand command = new SqlCommand(query, connect);

                command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                command.Parameters.AddWithValue("@sifre", sifre);

                
                int kayitSayisi = (int)command.ExecuteScalar();

               
                if (kayitSayisi > 0)
                {
                    kayitVarMi = true;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Veritabanında kayıt kontrol edilirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                
                connect.Close();
            }

            return kayitVarMi;
        }

        private void SilVeritabaniVerileri(string kullaniciadi, string sifre)
        {
            try
            {
                
                connect.Open();

                string query = "DELETE FROM KullaniciGiris WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                command.Parameters.AddWithValue("@sifre", sifre);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Veritabanından veri silinirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
               
                connect.Close();
            }
        }

    }
}

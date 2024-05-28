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
    public partial class FormKayıt : Form
    {



        public FormKayıt()
        {

            InitializeComponent();

        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");

        

        private void odabuton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Tüm alanları girdikten sonra Oda Numarasını seçin.");
                return;
            }

            TxtOdaNo.Text = "1";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda1 (Adi,Soyadi) values (@Ad, @Soyad)", connect);
            com.Parameters.AddWithValue("@Ad", TxtAd.Text);
            com.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);


            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }

            TxtOdaNo.Text = "2";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda2 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "3";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda3 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "4";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda4 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "5";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda5 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "6";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda6 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "7";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda7 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "8";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda8 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "9";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda9 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }
        private void odabuton10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "10";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda10 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "11";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda11 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "12";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda12 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "13";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda13 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "14";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda14 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton15_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "15";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda15 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "16";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda16 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "17";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda17 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "18";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda18 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "19";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda19 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "20";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda20 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }
        private void odabuton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "21";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda21 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "22";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda22 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }


        private void bosbuton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Boş odalar bu renkte gözükür.");
        }

        private void dolubuton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu odalar bu renkte gözükür.");

        }

        private void DtpCikis_ValueChanged(object sender, EventArgs e)
        {
            DateTime ktarih = Convert.ToDateTime(DtpGiris.Text);
            DateTime btarih = Convert.ToDateTime(DtpCikis.Text);

            TimeSpan Sonuc = btarih - ktarih;
            label11.Text = Sonuc.TotalDays.ToString();

            int ucretMiktari = 0;
            if (int.TryParse(UcretHesaplama.Text, out ucretMiktari))
            {
                int toplamUcret = Convert.ToInt32(label11.Text) * ucretMiktari;
                TxtUcret.Text = toplamUcret.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        
        private void butonkaydet_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(TxtAd.Text) ||
        string.IsNullOrWhiteSpace(TxtSoyad.Text) ||
        string.IsNullOrWhiteSpace(comboBox1.Text) ||
        string.IsNullOrWhiteSpace(TxtTel.Text) ||
        string.IsNullOrWhiteSpace(TxtMail.Text) ||
        string.IsNullOrWhiteSpace(TxtTc.Text) ||
        string.IsNullOrWhiteSpace(TxtOdaNo.Text) ||
        string.IsNullOrWhiteSpace(TxtUcret.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            connect.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriKayit (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + comboBox1.Text + "','" + TxtTel.Text + "','" + TxtMail.Text + "','" + TxtTc.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGiris.Value.ToString("yyyy-MM-dd") + "','" + DtpCikis.Value.ToString("yyyy-MM-dd") + "')", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti.");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Simge Durumuna Küçült");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Kapat");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormMainMenu geridon = new FormMainMenu();
            geridon.Show();
            this.Close();
        }

        private void odabuton23_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "23";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda23 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton24_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "24";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda24 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton25_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "25";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda25 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton26_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "26";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda26 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton27_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "27";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda27 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton28_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "28";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda28 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton29_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "29";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda29 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton30_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "30";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda30 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton31_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "31";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda31 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton32_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "32";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda32 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton33_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "33";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda33 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton34_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "34";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda34 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton35_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "35";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda35 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton36_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "36";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda36 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton37_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "37";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda37 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton38_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "38";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda38 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton39_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "39";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda39 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton40_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "40";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda40 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton41_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "41";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda41 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton42_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "42";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda42 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton43_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "43";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda43 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton44_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "44";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda44 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton45_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "45";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda45 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton46_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "46";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda46 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton47_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "47";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda47 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton48_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "48";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda48 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton49_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "49";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda49 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton50_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "50";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda50 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton51_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "51";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda51 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton52_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "52";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda52 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton53_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "53";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda53 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton54_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "54";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda54 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton55_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "55";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda55 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton56_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "56";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda56 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton57_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "57";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda57 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton58_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "58";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda58 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton59_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "59";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda59 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton60_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "60";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda60 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton61_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "61";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda61 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton62_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "62";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda62 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton63_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "63";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda63 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton64_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "64";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda64 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton65_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "65";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda65 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton66_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "66";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda66 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton67_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "67";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda67 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton68_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "68";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda68 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton69_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "69";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda69 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton70_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "70";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda70 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton71_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "71";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda71 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton72_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "72";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda72 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton73_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "73";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda73 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton74_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "74";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda74 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton75_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "75";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda75 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton76_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "76";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda76 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton77_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "77";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda77 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton78_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "78";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda78 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton79_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "79";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda79 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton80_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "80";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda80 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton81_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "81";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda81 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton82_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "82";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda82 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton83_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "83";

            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda83 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton84_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "84";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda84 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton85_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "85";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda85 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton86_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "86";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda86 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton87_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "87";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda87 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton88_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "88";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda88 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton89_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "89";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda89 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton90_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "90";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda90 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton91_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "91";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda91 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton92_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "92";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda92 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton93_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "93";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda93 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton94_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "94";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda94 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton95_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "95";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda95 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton96_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "96";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda96 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton97_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "97";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda97 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton98_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "98";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda98 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton99_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "99";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda99 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton100_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "100";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda100 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton101_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "101";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda101 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton102_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "102";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda102 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton103_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "103";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda103 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton104_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "104";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda104 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton105_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "105";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda105 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton106_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "106";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda106 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton107_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "107";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda107 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton108_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "108";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda108 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton109_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "109";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda109connect.Open();\r\n            SqlCommand com= new SqlCommand(\"insert into oda1 (Adi,Soyadi)values('\"+TxtAd.Text+\"','\"+TxtSoyad.Text+\"')\",connect);\r\n            com.ExecuteNonQuery();\r\n            connect.Close(); (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton110_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "110";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda110 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton111_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "111";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda111 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton112_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "112";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda112 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton113_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "113";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda113 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        private void odabuton114_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "114";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda114 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton115_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "115";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda115 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton116_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "116";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda116 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton117_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "117";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda117 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton118_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "118";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda118 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton119_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "119";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda119 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void odabuton120_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadı girdikten sonra Oda Numarasını seçin.");
                return;
            }
            TxtOdaNo.Text = "120";
            connect.Open();
            SqlCommand com = new SqlCommand("insert into oda120 (Adi,Soyadi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        private void FormKayıt_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from oda1", connect);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                odabuton1.BackColor = Color.Coral;
                odabuton1.Enabled = false;
            }

            connect.Close();






            connect.Open();
            SqlCommand komut1 = new SqlCommand("select*from oda2", connect);
            SqlDataReader read2 = komut1.ExecuteReader();

            while (read2.Read())
            {
               odabuton2.BackColor = Color.Coral;
                odabuton2.Enabled = false; 
            }
            connect.Close();
            







            connect.Open();
            SqlCommand komut2 = new SqlCommand("select*from oda3", connect);
            SqlDataReader read3 = komut2.ExecuteReader();

            while (read3.Read())
            {
                odabuton3.BackColor = Color.Coral;
                odabuton3.Enabled = false;
            }
            connect.Close();
            









            connect.Open();
            SqlCommand komut3 = new SqlCommand("select*from oda4", connect);
            SqlDataReader read4 = komut3.ExecuteReader();

            while (read4.Read())
            {
                odabuton4.BackColor = Color.Coral;
                odabuton4.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut4 = new SqlCommand("select*from oda5", connect);
            SqlDataReader read5 = komut4.ExecuteReader();

            while (read5.Read())
            {
                odabuton5.BackColor = Color.Coral;
                odabuton5.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut5 = new SqlCommand("select*from oda6", connect);
            SqlDataReader read6 = komut5.ExecuteReader();

            while (read6.Read())
            {
                odabuton6.BackColor = Color.Coral;
                odabuton6.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut6 = new SqlCommand("select*from oda7", connect);
            SqlDataReader read7 = komut6.ExecuteReader();

            while (read7.Read())
            {
                odabuton7.BackColor = Color.Coral;
                odabuton7.Enabled = false;
            }
            connect.Close();
           


            connect.Open();
            SqlCommand komut7 = new SqlCommand("select*from oda8", connect);
            SqlDataReader read8 = komut7.ExecuteReader();

            while (read8.Read())
            {
                odabuton8.BackColor = Color.Coral;
                odabuton7.Enabled = false;
            }
            connect.Close();
          




            connect.Open();
            SqlCommand komut8 = new SqlCommand("select*from oda9", connect);
            SqlDataReader read9 = komut8.ExecuteReader();

            while (read9.Read())
            {
                odabuton9.BackColor = Color.Coral;
                odabuton9.Enabled = false;
            }
            connect.Close();
            





            connect.Open();
            SqlCommand komut9 = new SqlCommand("select*from oda10", connect);
            SqlDataReader read10 = komut9.ExecuteReader();

            while (read10.Read())
            {
                odabuton10.BackColor = Color.Coral;
                odabuton10.Enabled = false;
            }
            connect.Close();
           





            connect.Open();
            SqlCommand komut10 = new SqlCommand("select*from oda11", connect);
            SqlDataReader read11 = komut10.ExecuteReader();

            while (read11.Read())
            {
                odabuton111.BackColor = Color.Coral;
                odabuton111.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut11 = new SqlCommand("select*from oda12", connect);
            SqlDataReader read12 = komut11.ExecuteReader();

            while (read12.Read())
            {
                odabuton12.BackColor = Color.Coral;
                odabuton12.Enabled = false;
            }
            connect.Close();
            





            connect.Open();
            SqlCommand komut12 = new SqlCommand("select*from oda13", connect);
            SqlDataReader read13 = komut12.ExecuteReader();

            while (read13.Read())
            {
                odabuton13.BackColor = Color.Coral;
                odabuton13.Enabled = false;
            }
            connect.Close();
            





            connect.Open();
            SqlCommand komut13 = new SqlCommand("select*from oda14", connect);
            SqlDataReader read14 = komut13.ExecuteReader();

            while (read14.Read())
            {
                odabuton14.BackColor = Color.Coral;
                odabuton14.Enabled = false;
            }
            connect.Close();
            





            connect.Open();
            SqlCommand komut14 = new SqlCommand("select*from oda15", connect);
            SqlDataReader read15 = komut14.ExecuteReader();

            while (read15.Read())
            {
                odabuton15.BackColor = Color.Coral;
                odabuton15.Enabled = false;
            }
            connect.Close();
           




            connect.Open();
            SqlCommand komut15 = new SqlCommand("select*from oda16", connect);
            SqlDataReader read16 = komut15.ExecuteReader();

            while (read16.Read())
            {
                odabuton16.BackColor = Color.Coral;
                odabuton16.Enabled = false;
            }
            connect.Close();
            





            connect.Open();
            SqlCommand komut16 = new SqlCommand("select*from oda17", connect);
            SqlDataReader read17 = komut16.ExecuteReader();

            while (read17.Read())
            {
                odabuton17.BackColor = Color.Coral;
                odabuton17.Enabled = false;
            }
            connect.Close();
            




            connect.Open();
            SqlCommand komut17 = new SqlCommand("select*from oda18", connect);
            SqlDataReader read18 = komut17.ExecuteReader();

            while (read18.Read())
            {
                odabuton18.BackColor = Color.Coral;
                odabuton18.Enabled = false;
            }
            connect.Close();
        

            connect.Open();
            SqlCommand komut18 = new SqlCommand("select*from oda19", connect);
            SqlDataReader read19 = komut18.ExecuteReader();

            while (read19.Read())
            {
                odabuton19.BackColor = Color.Coral;
                odabuton19.Enabled = false;
            }
            connect.Close();
           





            connect.Open();
            SqlCommand komut19 = new SqlCommand("select*from oda20", connect);
            SqlDataReader read20 = komut19.ExecuteReader();

            while (read20.Read())
            {
                odabuton20.BackColor = Color.Coral;
                odabuton20.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut20 = new SqlCommand("select*from oda21", connect);
            SqlDataReader read21 = komut20.ExecuteReader();

            while (read21.Read())
            {
                odabuton21.BackColor = Color.Coral;
                odabuton21.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut21 = new SqlCommand("select*from oda22", connect);
            SqlDataReader read22 = komut21.ExecuteReader();

            while (read22.Read())
            {
                odabuton22.BackColor = Color.Coral;
                odabuton22.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut22 = new SqlCommand("select*from oda23", connect);
            SqlDataReader read23 = komut22.ExecuteReader();

            while (read23.Read())
            {
                odabuton23.BackColor = Color.Coral;
                odabuton23.Enabled = false;
            }
            connect.Close();
          



            connect.Open();
            SqlCommand komut23 = new SqlCommand("select*from oda24", connect);
            SqlDataReader read24 = komut23.ExecuteReader();

            while (read24.Read())
            {
                odabuton24.BackColor = Color.Coral;
                odabuton24.Enabled = false;
            }
            connect.Close();
            
            connect.Open();
            SqlCommand komut24 = new SqlCommand("select*from oda25", connect);
            SqlDataReader read25 = komut24.ExecuteReader();

            while (read25.Read())
            {
                odabuton25.BackColor = Color.Coral;
                odabuton25.Enabled = false;
            }
            connect.Close();
            
            connect.Open();
            SqlCommand komut25 = new SqlCommand("select*from oda26", connect);
            SqlDataReader read26 = komut25.ExecuteReader();

            while (read26.Read())
            {
                odabuton26.BackColor = Color.Coral;
                odabuton26.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut26 = new SqlCommand("select*from oda27", connect);
            SqlDataReader read27 = komut26.ExecuteReader();

            while (read27.Read())
            {
                odabuton27.BackColor = Color.Coral;
                odabuton27.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut27 = new SqlCommand("select*from oda28", connect);
            SqlDataReader read28 = komut27.ExecuteReader();

            while (read28.Read())
            {
                odabuton28.BackColor = Color.Coral;
                odabuton28.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut28 = new SqlCommand("select*from oda29", connect);
            SqlDataReader read29 = komut28.ExecuteReader();

            while (read29.Read())
            {
                odabuton29.BackColor = Color.Coral;
                odabuton29.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut29 = new SqlCommand("select*from oda30", connect);
            SqlDataReader read30 = komut29.ExecuteReader();

            while (read30.Read())
            {
                odabuton30.BackColor = Color.Coral;
                odabuton30.Enabled = false; ;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut30 = new SqlCommand("select*from oda31", connect);
            SqlDataReader read31 = komut30.ExecuteReader();

            while (read31.Read())
            {
                odabuton31.BackColor = Color.Coral;
                odabuton31.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut31 = new SqlCommand("select*from oda32", connect);
            SqlDataReader read32 = komut31.ExecuteReader();

            while (read32.Read())
            {
                odabuton32.BackColor = Color.Coral;
                odabuton32.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut32 = new SqlCommand("select*from oda33", connect);
            SqlDataReader read33 = komut32.ExecuteReader();

            while (read33.Read())
            {
                odabuton33.BackColor = Color.Coral;
                odabuton33.Enabled = false;
            }
            connect.Close();
            




            connect.Open();
            SqlCommand komut33 = new SqlCommand("select*from oda34", connect);
            SqlDataReader read34 = komut33.ExecuteReader();

            while (read34.Read())
            {
                odabuton34.BackColor = Color.Coral;
                odabuton34.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut34 = new SqlCommand("select*from oda35", connect);
            SqlDataReader read35 = komut34.ExecuteReader();

            while (read35.Read())
            {
                odabuton35.BackColor = Color.Coral;
                odabuton35.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut35 = new SqlCommand("select*from oda36", connect);
            SqlDataReader read36 = komut35.ExecuteReader();

            while (read36.Read())
            {
                odabuton36.BackColor = Color.Coral;
                odabuton36.Enabled = false;
            }
            connect.Close();
            




            connect.Open();
            SqlCommand komut36 = new SqlCommand("select*from oda37", connect);
            SqlDataReader read37 = komut36.ExecuteReader();

            while (read37.Read())
            {
                odabuton37.BackColor = Color.Coral;
                odabuton37.Enabled = false;
            }
            connect.Close();
            




            connect.Open();
            SqlCommand komut37 = new SqlCommand("select*from oda38", connect);
            SqlDataReader read38 = komut37.ExecuteReader();

            while (read38.Read())
            {
                odabuton38.BackColor = Color.Coral;
                odabuton38.Enabled = false;
            }
            connect.Close();
           




            connect.Open();
            SqlCommand komut38 = new SqlCommand("select*from oda39", connect);
            SqlDataReader read39 = komut38.ExecuteReader();

            while (read39.Read())
            {
                odabuton39.BackColor = Color.Coral;
                odabuton39.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut39 = new SqlCommand("select*from oda40", connect);
            SqlDataReader read40 = komut39.ExecuteReader();

            while (read40.Read())
            {
                odabuton40.BackColor = Color.Coral;
                odabuton40.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut40 = new SqlCommand("select*from oda41", connect);
            SqlDataReader read41 = komut40.ExecuteReader();

            while (read41.Read())
            {
                odabuton41.BackColor = Color.Coral;
                odabuton41.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut41 = new SqlCommand("select*from oda42", connect);
            SqlDataReader read42 = komut41.ExecuteReader();

            while (read42.Read())
            {
                odabuton42.BackColor = Color.Coral;
                odabuton42.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut42 = new SqlCommand("select*from oda43", connect);
            SqlDataReader read43 = komut42.ExecuteReader();

            while (read43.Read())
            {
                odabuton43.BackColor = Color.Coral;
                odabuton43.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut43 = new SqlCommand("select*from oda44", connect);
            SqlDataReader read44 = komut43.ExecuteReader();

            while (read44.Read())
            {
                odabuton44.BackColor = Color.Coral;
                odabuton44.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut44 = new SqlCommand("select*from oda45", connect);
            SqlDataReader read45 = komut44.ExecuteReader();

            while (read45.Read())
            {
                odabuton45.BackColor = Color.Coral;
                odabuton45.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut45 = new SqlCommand("select*from oda46", connect);
            SqlDataReader read46 = komut45.ExecuteReader();

            while (read46.Read())
            {
                odabuton46.BackColor = Color.Coral;
                odabuton46.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut46 = new SqlCommand("select*from oda47", connect);
            SqlDataReader read47 = komut46.ExecuteReader();

            while (read47.Read())
            {
                odabuton47.BackColor = Color.Coral;
                odabuton47.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut47 = new SqlCommand("select*from oda48", connect);
            SqlDataReader read48 = komut47.ExecuteReader();

            while (read48.Read())
            {
                odabuton48.BackColor = Color.Coral;
                odabuton48.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut48 = new SqlCommand("select*from oda49", connect);
            SqlDataReader read49 = komut48.ExecuteReader();

            while (read49.Read())
            {
                odabuton49.BackColor = Color.Coral;
                odabuton49.Enabled = false;
            }
            connect.Close();
          



            connect.Open();
            SqlCommand komut49 = new SqlCommand("select*from oda50", connect);
            SqlDataReader read50 = komut49.ExecuteReader();

            while (read50.Read())
            {
                odabuton50.BackColor = Color.Coral;
                odabuton50.Enabled = false;
            }
            connect.Close();
           

            connect.Open();
            SqlCommand komut50 = new SqlCommand("select*from oda51", connect);
            SqlDataReader read51 = komut50.ExecuteReader();

            while (read51.Read())
            {
                odabuton51.BackColor = Color.Coral;
                odabuton51.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut51 = new SqlCommand("select*from oda52", connect);
            SqlDataReader read52 = komut51.ExecuteReader();

            while (read52.Read())
            {
                odabuton52.BackColor = Color.Coral;
                odabuton52.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut52 = new SqlCommand("select*from oda53", connect);
            SqlDataReader read53 = komut52.ExecuteReader();

            while (read53.Read())
            {
                odabuton53.BackColor = Color.Coral;
                odabuton53.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut53 = new SqlCommand("select*from oda54", connect);
            SqlDataReader read54 = komut53.ExecuteReader();

            while (read54.Read())
            {
                odabuton54.BackColor = Color.Coral;
                odabuton54.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut54 = new SqlCommand("select*from oda55", connect);
            SqlDataReader read55 = komut54.ExecuteReader();

            while (read55.Read())
            {
                odabuton55.BackColor = Color.Coral;
                odabuton55.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut55 = new SqlCommand("select*from oda56", connect);
            SqlDataReader read56 = komut55.ExecuteReader();

            while (read56.Read())
            {
                odabuton56.BackColor = Color.Coral;
                odabuton56.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut56 = new SqlCommand("select*from oda57", connect);
            SqlDataReader read57 = komut56.ExecuteReader();

            while (read57.Read())
            {
                odabuton57.BackColor = Color.Coral;
                odabuton57.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut57 = new SqlCommand("select*from oda58", connect);
            SqlDataReader read58 = komut57.ExecuteReader();

            while (read58.Read())
            {
                odabuton58.BackColor = Color.Coral;
                odabuton58.Enabled = false;
            }
            connect.Close();
           


            connect.Open();
            SqlCommand komut58 = new SqlCommand("select*from oda59", connect);
            SqlDataReader read59 = komut58.ExecuteReader();

            while (read59.Read())
            {
                odabuton59.BackColor = Color.Coral;
                odabuton59.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut59 = new SqlCommand("select*from oda60", connect);
            SqlDataReader read60 = komut59.ExecuteReader();

            while (read60.Read())
            {
                odabuton60.BackColor = Color.Coral;
                odabuton60.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut60 = new SqlCommand("select*from oda61", connect);
            SqlDataReader read61 = komut60.ExecuteReader();

            while (read61.Read())
            {
                odabuton61.BackColor = Color.Coral;
                odabuton61.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut61 = new SqlCommand("select*from oda62", connect);
            SqlDataReader read62 = komut61.ExecuteReader();

            while (read62.Read())
            {
                odabuton62.BackColor = Color.Coral;
                odabuton62.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut62 = new SqlCommand("select*from oda63", connect);
            SqlDataReader read63 = komut62.ExecuteReader();

            while (read63.Read())
            {
                odabuton63.BackColor = Color.Coral;
                odabuton63.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut63 = new SqlCommand("select*from oda64", connect);
            SqlDataReader read64 = komut63.ExecuteReader();

            while (read64.Read())
            {
                odabuton64.BackColor = Color.Coral;
                odabuton64.Enabled = false;
            }
            connect.Close();
         


            connect.Open();
            SqlCommand komut64 = new SqlCommand("select*from oda65", connect);
            SqlDataReader read65 = komut64.ExecuteReader();

            while (read65.Read())
            {
                odabuton65.BackColor = Color.Coral;
                odabuton65.Enabled = false;
            }
            connect.Close();
           


            connect.Open();
            SqlCommand komut65 = new SqlCommand("select*from oda66", connect);
            SqlDataReader read66 = komut65.ExecuteReader();

            while (read66.Read())
            {
                odabuton66.BackColor = Color.Coral;
                odabuton66.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut66 = new SqlCommand("select*from oda67", connect);
            SqlDataReader read67 = komut66.ExecuteReader();

            while (read67.Read())
            {
                odabuton67.BackColor = Color.Coral;
                odabuton67.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut67 = new SqlCommand("select*from oda68", connect);
            SqlDataReader read68 = komut67.ExecuteReader();

            while (read68.Read())
            {
                odabuton68.BackColor = Color.Coral;
                odabuton68.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut68 = new SqlCommand("select*from oda69", connect);
            SqlDataReader read69 = komut68.ExecuteReader();

            while (read69.Read())
            {
                odabuton69.BackColor = Color.Coral;
                odabuton69.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut69 = new SqlCommand("select*from oda70", connect);
            SqlDataReader read70 = komut69.ExecuteReader();

            while (read70.Read())
            {
                odabuton70.BackColor = Color.Coral;
                odabuton70.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut70 = new SqlCommand("select*from oda71", connect);
            SqlDataReader read71 = komut70.ExecuteReader();

            while (read71.Read())
            {
                odabuton71.BackColor = Color.Coral;
                odabuton71.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut71 = new SqlCommand("select*from oda72", connect);
            SqlDataReader read72 = komut71.ExecuteReader();

            while (read72.Read())
            {
                odabuton72.BackColor = Color.Coral;
                odabuton72.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut72 = new SqlCommand("select*from oda73", connect);
            SqlDataReader read73 = komut72.ExecuteReader();

            while (read73.Read())
            {
                odabuton73.BackColor = Color.Coral;
                odabuton73.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut73 = new SqlCommand("select*from oda74", connect);
            SqlDataReader read74 = komut73.ExecuteReader();

            while (read74.Read())
            {
                odabuton74.BackColor = Color.Coral;
                odabuton74.Enabled = false;
            }
            connect.Close();
           



            connect.Open();
            SqlCommand komut74 = new SqlCommand("select*from oda75", connect);
            SqlDataReader read75 = komut74.ExecuteReader();

            while (read75.Read())
            {
                odabuton75.BackColor = Color.Coral;
                odabuton75.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut75 = new SqlCommand("select*from oda76", connect);
            SqlDataReader read76 = komut75.ExecuteReader();

            while (read76.Read())
            {
                odabuton76.BackColor = Color.Coral;
                odabuton76.Enabled = false;
            }
            connect.Close();
          



            connect.Open();
            SqlCommand komut76 = new SqlCommand("select*from oda77", connect);
            SqlDataReader read77 = komut76.ExecuteReader();

            while (read77.Read())
            {
                odabuton77.BackColor = Color.Coral;
                odabuton77.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut77 = new SqlCommand("select*from oda78", connect);
            SqlDataReader read78 = komut77.ExecuteReader();

            while (read78.Read())
            {
                odabuton78.BackColor = Color.Coral;
                odabuton78.Enabled = false;
            }
            connect.Close();
            


            connect.Open();
            SqlCommand komut78 = new SqlCommand("select*from oda79", connect);
            SqlDataReader read79 = komut78.ExecuteReader();

            while (read79.Read())
            {
                odabuton79.BackColor = Color.Coral;
                odabuton79.Enabled = false;
            }
            connect.Close();
            



            connect.Open();
            SqlCommand komut79 = new SqlCommand("select*from oda80", connect);
            SqlDataReader read80 = komut79.ExecuteReader();

            while (read80.Read())
            {
                odabuton80.BackColor = Color.Coral;
                odabuton80.Enabled = false;
            }
            connect.Close();
          



            connect.Open();
            SqlCommand komut80 = new SqlCommand("select*from oda81", connect);
            SqlDataReader read81 = komut80.ExecuteReader();

            while (read81.Read())
            {
                odabuton81.BackColor = Color.Coral;
                odabuton81.Enabled = false;
            }
            connect.Close();
           


            connect.Open();
            SqlCommand komut81 = new SqlCommand("select*from oda82", connect);
            SqlDataReader read82 = komut81.ExecuteReader();

            while (read82.Read())
            {
                odabuton82.BackColor = Color.Coral;
                odabuton82.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut82 = new SqlCommand("select*from oda83", connect);
            SqlDataReader read83 = komut82.ExecuteReader();

            while (read83.Read())
            {
                odabuton83.BackColor = Color.Coral;
                odabuton83.Enabled = false;
            }
            connect.Close();
            

            connect.Open();
            SqlCommand komut83 = new SqlCommand("select*from oda84", connect);
            SqlDataReader read84 = komut83.ExecuteReader();

            while (read84.Read())
            {
                odabuton84.BackColor = Color.Coral;
                odabuton84.Enabled = false;
            }
            connect.Close();
            



                connect.Open();
                SqlCommand komut84 = new SqlCommand("select*from oda85", connect);
                SqlDataReader read85 = komut84.ExecuteReader();

                while (read85.Read())
                {
                odabuton85.BackColor = Color.Coral;
                odabuton85.Enabled = false;
            }
                connect.Close();
               

                connect.Open();
                SqlCommand komut85 = new SqlCommand("select*from oda86", connect);
                SqlDataReader read86 = komut85.ExecuteReader();

                while (read86.Read())
                {
                odabuton86.BackColor = Color.Coral;
                odabuton86.Enabled = false;
            }
                connect.Close();
              


                connect.Open();
                SqlCommand komut86 = new SqlCommand("select*from oda63", connect);
                SqlDataReader read87 = komut86.ExecuteReader();

                while (read87.Read())
                {
                odabuton87.BackColor = Color.Coral;
                odabuton87.Enabled = false;
            }
                connect.Close();
               


                connect.Open();
                SqlCommand komut87 = new SqlCommand("select*from oda88", connect);
                SqlDataReader read88 = komut87.ExecuteReader();

                while (read88.Read())
                {
                odabuton88.BackColor = Color.Coral;
                odabuton88.Enabled = false;
            }
                connect.Close();
               


                connect.Open();
                SqlCommand komut88 = new SqlCommand("select*from oda89", connect);
                SqlDataReader read89 = komut88.ExecuteReader();

                while (read89.Read())
                {
                odabuton89.BackColor = Color.Coral;
                odabuton89.Enabled = false;
            }
                connect.Close();
               


                connect.Open();
                SqlCommand komut89 = new SqlCommand("select*from oda90", connect);
                SqlDataReader read90 = komut89.ExecuteReader();

                while (read90.Read())
                {
                odabuton90.BackColor = Color.Coral;
                odabuton90.Enabled = false;
            }
                connect.Close();
                

                connect.Open();
                SqlCommand komut90 = new SqlCommand("select*from oda91", connect);
                SqlDataReader read91 = komut90.ExecuteReader();

                while (read91.Read())
                {
                odabuton91.BackColor = Color.Coral;
                odabuton91.Enabled = false;
            }
                connect.Close();
                

                connect.Open();
                SqlCommand komut91 = new SqlCommand("select*from oda92", connect);
                SqlDataReader read92 = komut91.ExecuteReader();

                while (read92.Read())
                {
                odabuton92.BackColor = Color.Coral;
                odabuton92.Enabled = false;
            }
                connect.Close();
              

                connect.Open();
                SqlCommand komut92 = new SqlCommand("select*from oda93", connect);
                SqlDataReader read93 = komut92.ExecuteReader();

                while (read93.Read())
                {
                odabuton93.BackColor = Color.Coral;
                odabuton93.Enabled = false;
            }
                connect.Close();
               

                connect.Open();
                SqlCommand komut93 = new SqlCommand("select*from oda94", connect);
                SqlDataReader read94 = komut93.ExecuteReader();

                while (read94.Read())
                {
                odabuton94.BackColor = Color.Coral;
                odabuton94.Enabled = false;
            }
                connect.Close();
               

                connect.Open();
                SqlCommand komut94 = new SqlCommand("select*from oda95", connect);
                SqlDataReader read95 = komut94.ExecuteReader();

                while (read95.Read())
                {
                odabuton95.BackColor = Color.Coral;
                odabuton95.Enabled = false;
            }
                connect.Close();
                

                connect.Open();
                SqlCommand komut95 = new SqlCommand("select*from oda96", connect);
                SqlDataReader read96 = komut95.ExecuteReader();

                while (read96.Read())
                {
                odabuton96.BackColor = Color.Coral;
                odabuton96.Enabled = false;
            }
                connect.Close();
                


                connect.Open();
                SqlCommand komut96 = new SqlCommand("select*from oda97", connect);
                SqlDataReader read97 = komut96.ExecuteReader();

                while (read97.Read())
                {
                odabuton97.BackColor = Color.Coral;
                odabuton97.Enabled = false;
            }
                connect.Close();
               

                connect.Open();
                SqlCommand komut97 = new SqlCommand("select*from oda98", connect);
                SqlDataReader read98 = komut97.ExecuteReader();

                while (read98.Read())
                {
                odabuton98.BackColor = Color.Coral;
                odabuton98.Enabled = false;
            }
                connect.Close();
                
                connect.Open();
                SqlCommand komut98 = new SqlCommand("select*from oda99", connect);
                SqlDataReader read99 = komut98.ExecuteReader();

                while (read99.Read())
                {
                odabuton99.BackColor = Color.Coral;
                odabuton99.Enabled = false;
            }
                connect.Close();
              

                connect.Open();
                SqlCommand komut99 = new SqlCommand("select*from oda100", connect);
                SqlDataReader read100 = komut99.ExecuteReader();

                while (read100.Read())
                {
                odabuton100.BackColor = Color.Coral;
                odabuton100.Enabled = false;
            }
                connect.Close();
               

                connect.Open();
                SqlCommand komut100 = new SqlCommand("select*from oda101", connect);
                SqlDataReader read101 = komut100.ExecuteReader();

                while (read101.Read())
                {
                odabuton101.BackColor = Color.Coral;
                odabuton101.Enabled = false;
            }
                connect.Close();
               


                connect.Open();
                SqlCommand komut101 = new SqlCommand("select*from oda102", connect);
                SqlDataReader read102 = komut101.ExecuteReader();

                while (read102.Read())
                {
                odabuton102.BackColor = Color.Coral;
                odabuton102.Enabled = false;
            }
                connect.Close();
               

                connect.Open();
                SqlCommand komut102 = new SqlCommand("select*from oda103", connect);
                SqlDataReader read103 = komut102.ExecuteReader();

                while (read103.Read())
                {
                odabuton103.BackColor = Color.Coral;
                odabuton103.Enabled = false;
            }
                connect.Close();
               


                    connect.Open();
                    SqlCommand komut103 = new SqlCommand("select*from oda104", connect);
                    SqlDataReader read104 = komut103.ExecuteReader();

                    while (read104.Read())
                    {
                odabuton104.BackColor = Color.Coral;
                odabuton104.Enabled = false;
            }
                    connect.Close();
                   

                    connect.Open();
                    SqlCommand komut104 = new SqlCommand("select*from oda105", connect);
                    SqlDataReader read105 = komut104.ExecuteReader();

                    while (read105.Read())
                    {
                odabuton105.BackColor = Color.Coral;
                odabuton105.Enabled = false;
            }
                    connect.Close();
                   

                    connect.Open();
                    SqlCommand komut105 = new SqlCommand("select*from oda106", connect);
                    SqlDataReader read106 = komut105.ExecuteReader();

                    while (read106.Read())
                    {
                odabuton106.BackColor = Color.Coral;
                odabuton106.Enabled = false;
            }
                    connect.Close();
                    


                    connect.Open();
                    SqlCommand komut106 = new SqlCommand("select*from oda107", connect);
                    SqlDataReader read107 = komut106.ExecuteReader();

                    while (read107.Read())
                    {
                odabuton107.BackColor = Color.Coral;
                odabuton107.Enabled = false;
            }
                    connect.Close();
                   


                    connect.Open();
                    SqlCommand komut107 = new SqlCommand("select*from oda108", connect);
                    SqlDataReader read108 = komut107.ExecuteReader();

                    while (read108.Read())
                    {
                odabuton108.BackColor = Color.Coral;
                odabuton108.Enabled = false;
            }
                    connect.Close();
                   


                    connect.Open();
                    SqlCommand komut108 = new SqlCommand("select*from oda109", connect);
                    SqlDataReader read109 = komut108.ExecuteReader();

                    while (read109.Read())
                    {
                odabuton109.BackColor = Color.Coral;
                odabuton109.Enabled = false;
            }
                    connect.Close();
                   


                    connect.Open();
                    SqlCommand komut109 = new SqlCommand("select*from oda110", connect);
                    SqlDataReader read110 = komut109.ExecuteReader();

                    while (read110.Read())
                    {
                odabuton110.BackColor = Color.Coral;
                odabuton110.Enabled = false;
            }
                    connect.Close();
                    

                    connect.Open();
                    SqlCommand komut110 = new SqlCommand("select*from oda111", connect);
                    SqlDataReader read111 = komut110.ExecuteReader();

                    while (read111.Read())
                    {
                odabuton111.BackColor = Color.Coral;
                odabuton111.Enabled = false;
            }
                    connect.Close();
                    
                    connect.Open();
                    SqlCommand komut111 = new SqlCommand("select*from oda112", connect);
                    SqlDataReader read112 = komut111.ExecuteReader();

                    while (read112.Read())
                    {
                odabuton112.BackColor = Color.Coral;
                odabuton112.Enabled = false;
            }
                    connect.Close();
                    

                    connect.Open();
                    SqlCommand komut112 = new SqlCommand("select*from oda113", connect);
                    SqlDataReader read113 = komut112.ExecuteReader();

                    while (read113.Read())
                    {
                odabuton113.BackColor = Color.Coral;
                odabuton113.Enabled = false;
            }
                    connect.Close();
                    

                    connect.Open();
                    SqlCommand komut113 = new SqlCommand("select*from oda114", connect);
                    SqlDataReader read114 = komut113.ExecuteReader();

                    while (read114.Read())
                    {
                        odabuton114.BackColor = Color.Coral;
                        odabuton114.Enabled = false;
                    }
                    connect.Close();
                   

                    connect.Open();
                    SqlCommand komut114 = new SqlCommand("select*from oda115", connect);
                    SqlDataReader read115 = komut114.ExecuteReader();

                    while (read115.Read())
                    {
                        odabuton115.BackColor = Color.Coral;
                        odabuton115.Enabled = false;
                    }
                    connect.Close();
                   
                    connect.Open();
                    SqlCommand komut115 = new SqlCommand("select*from oda116", connect);
                    SqlDataReader read116 = komut115.ExecuteReader();

                    while (read116.Read())
                    {
                        odabuton116.BackColor = Color.Coral;
                        odabuton116.Enabled = false;
                    }
                    connect.Close();
                    

                    connect.Open();
                    SqlCommand komut116 = new SqlCommand("select*from oda117", connect);
                    SqlDataReader read117 = komut116.ExecuteReader();

                    while (read117.Read())
                    {
                        odabuton117.BackColor = Color.Coral;
                        odabuton117.Enabled = false;
                    }
                    connect.Close();
                   

                    connect.Open();
                    SqlCommand komut117 = new SqlCommand("select*from oda118", connect);
                    SqlDataReader read118 = komut117.ExecuteReader();

                    while (read118.Read())
                    {
                        odabuton118.BackColor = Color.Coral;
                        odabuton118.Enabled = false;
                    }
                    connect.Close();
                    

                    connect.Open();
                    SqlCommand komut118 = new SqlCommand("select*from oda119", connect);
                    SqlDataReader read119 = komut118.ExecuteReader();

                    while (read119.Read())
                    {
                        odabuton119.BackColor = Color.Coral;
                        odabuton119.Enabled = false;
                    }
                    connect.Close();
                    

                    connect.Open();
                    SqlCommand komut119 = new SqlCommand("select*from oda120", connect);
                    SqlDataReader read120 = komut119.ExecuteReader();

                    while (read120.Read())
                    {
                        odabuton120.BackColor = Color.Coral;
                        odabuton120.Enabled = false;
                    }
                    connect.Close();
                    

                }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Geri Dön");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKayıt gecis7 = new FormKayıt();
            gecis7.Show();
            this.Hide();
        }
    }
        }
    

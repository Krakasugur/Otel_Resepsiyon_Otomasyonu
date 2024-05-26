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
    public partial class FormGelirGider : Form
    {
        public FormGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtcalisansayi.Text))
            {
                MessageBox.Show("Lütfen çalışan sayısını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            connect.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriKayit ", connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                labelkasa.Text = read["toplam"].ToString();
            }
            connect.Close();


            int calisanMaas;
            if (int.TryParse(txtcalisanmaas.Text, out calisanMaas))
            {
                
                int calisanSayisi = Convert.ToInt32(txtcalisansayi.Text);
                int maas = calisanSayisi * calisanMaas;
                labelmaas.Text = maas.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir maaş miktarı girin.");
            }


            try
            {
                int kasa, maas, fatura1, fatura2, fatura3, fatura4;

                if (int.TryParse(labelkasa.Text, out kasa) &&
                    int.TryParse(labelmaas.Text, out maas) &&
                    int.TryParse(labelfatura.Text, out fatura1) &&
                    int.TryParse(labelfatura2.Text, out fatura2) &&
                    int.TryParse(labelfatura3.Text, out fatura3) &&
                    int.TryParse(labelfatura4.Text, out fatura4))
                {
                    int sonuc = kasa - (maas + fatura1 + fatura2 + fatura3 + fatura4);
                    labelsonuc.Text = sonuc.ToString();
                }
                else
                {
                    MessageBox.Show("Müşteri Kaydı yapılmadığı için hesaplanamıyor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Geri Dön");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Simge Durumuna Küçült");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Kapat");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormMainMenu geridon = new FormMainMenu();
            geridon.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data1()
        {
            listView1.Items.Clear();
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from Fatura", connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["Elektrik"].ToString();
                ekle.SubItems.Add(read["Su"].ToString());
                ekle.SubItems.Add(read["İnternet"].ToString());
                ekle.SubItems.Add(read["Dogalgaz"].ToString());
                listView1.Items.Add(ekle);
            }
            connect.Close();
        }

        private void FormGelirGider_Load(object sender, EventArgs e)
        {
            data1();




            connect.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam5 from Fatura ", connect);
            SqlDataReader read5 = komut5.ExecuteReader();
            while (read5.Read())
            {
                labelfatura.Text = read5["toplam5"].ToString();
            }
            connect.Close();


            connect.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam6 from Fatura ", connect);
            SqlDataReader read6 = komut6.ExecuteReader();
            while (read6.Read())
            {
                labelfatura2.Text = read6["toplam6"].ToString();
            }
            connect.Close();



            connect.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(İnternet) as toplam7 from Fatura ", connect);
            SqlDataReader read7 = komut7.ExecuteReader();
            while (read7.Read())
            {
                labelfatura3.Text = read7["toplam7"].ToString();
            }
            connect.Close();


            connect.Open();
            SqlCommand komut8 = new SqlCommand("Select sum(DogalGaz) as toplam8 from Fatura ", connect);
            SqlDataReader read8 = komut8.ExecuteReader();
            while (read8.Read())
            {
                labelfatura4.Text = read8["toplam8"].ToString();
            }
            connect.Close();


            



        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            listView1.Items.Clear();
            connect.Open();
            SqlCommand com = new SqlCommand("insert into Fatura(Elektrik,Su,İnternet,DogalGaz)values('" + txtelektrik.Text + "','" + txtsu.Text + "','" + txtinternet.Text + "','" + txtdogalgaz.Text + "')", connect);
            com.ExecuteNonQuery();
            connect.Close();
            data1();
        }

        private void butonsil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm verileri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand com1 = new SqlCommand("TRUNCATE TABLE Fatura", connect);
                    com1.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Veriler başarıyla silindi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGelirGider gecis8 = new FormGelirGider();
            gecis8.Show();
            this.Hide();
        }
    }
}

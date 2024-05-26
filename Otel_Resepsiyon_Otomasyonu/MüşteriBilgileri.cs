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
    public partial class MüşteriBilgileri : Form
    {
        public MüşteriBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");


        private void datagoster()
        {
            listView1.Items.Clear();    
            connect.Open();
            SqlCommand komut = new SqlCommand("select*from MusteriKayit",connect);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["Musteriid"].ToString();
                ekle.SubItems.Add(read["Adi"].ToString());
                ekle.SubItems.Add(read["Soyadi"].ToString());
                ekle.SubItems.Add(read["Cinsiyet"].ToString());
                ekle.SubItems.Add(read["Telefon"].ToString());
                ekle.SubItems.Add(read["Mail"].ToString());
                ekle.SubItems.Add(read["TC"].ToString());
                ekle.SubItems.Add(read["OdaNo"].ToString());
                ekle.SubItems.Add(read["Ucret"].ToString());
                ekle.SubItems.Add(read["GirisTarihi"].ToString());
                ekle.SubItems.Add(read["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            connect.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            datagoster();

        }
        
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikis.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void ButonSil_Click(object sender, EventArgs e)
        {
            if(TxtOdaNo.Text=="1")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda1", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "2")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda2", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "3")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda3", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "4")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda4", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "5")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda5", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "6")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda6", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "7")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda7", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "8")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda8", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "9")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda9", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "10")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda10", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "11")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda11", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "12")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda112", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "13")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda13", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "14")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda14", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "15")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda15", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "16")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda16", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "17")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda17", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "18")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda18", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "19")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda19", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "20")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda20", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "21")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda21", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "22")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda22", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "23")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda23", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "24")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda24", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "25")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda25", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "26")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda26", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "27")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda27", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "28")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda28", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "29")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda29", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "30")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda30", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }


            if (TxtOdaNo.Text == "31")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda31", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "32")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda32", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "33")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda33", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "34")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda34", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "35")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda35", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "36")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda36", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "37")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda37", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "38")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda38", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "39")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda39", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "40")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda40", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "41")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda41", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "42")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda42", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "43")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda43", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "44")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda44", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "45")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda45", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "46")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda46", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "47")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda47", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "48")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda48", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "49")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda49", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "50")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda50", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "51")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda51", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "52")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda52", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "53")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda53", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "54")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda54", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "55")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda55", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "56")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda56", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "57")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda57", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "58")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda58", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "59")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda59", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "60")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda60", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "61")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda61", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "62")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda62", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "63")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda63", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "64")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda64", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "65")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda65", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "66")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda66", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "67")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda67", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "68")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda68", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "69")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda69", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "70")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda70", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "71")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda71", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "72")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda72", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "74")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda74", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "75")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda75", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "76")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda76", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "77")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda77", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "78")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda78", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "79")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda79", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "80")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda80", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "81")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda81", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "82")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda82", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "83")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda83", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "84")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda84", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "85")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda85", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "86")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda86", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "87")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda87", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "88")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda88", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "89")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda89", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "90")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda90", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "91")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda91", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "92")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda92", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "93")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda93", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "94")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda94", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "95")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda95", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "96")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda96", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "97")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda97", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "98")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda98", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "99")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda99", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "100")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda100", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "101")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda101", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda102", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda103", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda104", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda105", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda106", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "107")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda107", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda108", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda109", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "110")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda110", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "111")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda111", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "112")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda112", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "113")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda113", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "114")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda114", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "115")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda115", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "116")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda116", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "117")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda117", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "118")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda118", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }
            if (TxtOdaNo.Text == "119")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda119", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }

            if (TxtOdaNo.Text == "120")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from oda120", connect);
                command.ExecuteNonQuery();
                connect.Close();
                datagoster();
            }









            connect.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriKayit where Musteriid=(" + id + ")", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            datagoster();
        }

        private void ButonTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            comboBox1.Text = "";
            TxtTel.Clear();
            TxtMail.Text = "";
            TxtTc.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGiris.Text ="";
            DtpCikis.Text = "";

        }

        private void butonGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut10 = new SqlCommand("update MusteriKayit set Adi='" + TxtAd.Text + "',Soyadi='" + TxtSoyad.Text + "', Cinsiyet='" + comboBox1.Text + "', Telefon='" + TxtTel.Text + "', Mail='" + TxtMail.Text + "' ,TC='" + TxtTc.Text + "', OdaNo='" + TxtOdaNo.Text + "', Ucret='" + TxtUcret.Text + "', GirisTarihi='" + DtpGiris.Value.ToString("yyyy-MM-dd") + "', CikisTarihi='" + DtpCikis.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", connect);
            komut10.ExecuteNonQuery();
            connect.Close();
            datagoster();





        }

        private void ButonAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connect.Open();
            SqlCommand komut = new SqlCommand("select*from MusteriKayit where Adi like '%"+ textBox1.Text+"%'", connect);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["Musteriid"].ToString();
                ekle.SubItems.Add(read["Adi"].ToString());
                ekle.SubItems.Add(read["Soyadi"].ToString());
                ekle.SubItems.Add(read["Cinsiyet"].ToString());
                ekle.SubItems.Add(read["Telefon"].ToString());
                ekle.SubItems.Add(read["Mail"].ToString());
                ekle.SubItems.Add(read["TC"].ToString());
                ekle.SubItems.Add(read["OdaNo"].ToString());
                ekle.SubItems.Add(read["Ucret"].ToString());
                ekle.SubItems.Add(read["GirisTarihi"].ToString());
                ekle.SubItems.Add(read["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            connect.Close();
        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Geri Dön");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormMainMenu geridon = new FormMainMenu();
            geridon.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MüşteriBilgileri gecis10 = new MüşteriBilgileri();
            gecis10.Show();
            this.Hide();
        }
    }
}

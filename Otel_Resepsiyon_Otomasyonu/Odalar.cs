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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-8FUJMRT;Initial Catalog=OtelResepsiyon;Integrated Security=True;Encrypt=False");
        private void Odalar_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select*from oda1", connect);
            SqlDataReader read1 = komut.ExecuteReader();

            while (read1.Read())
            {
                odabuton1.Text = read1["Adi"].ToString() + " " + read1["Soyadi"].ToString();
            }
            connect.Close();    
            if(odabuton1.Text != "1")
            {
                odabuton1.BackColor = Color.Coral;
                odabuton1.Enabled = false;
            }






            connect.Open();
            SqlCommand komut1 = new SqlCommand("select*from oda2", connect);
            SqlDataReader read2 = komut1.ExecuteReader();

            while (read2.Read())
            {
                odabuton2.Text = read2["Adi"].ToString() + " " + read2["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton2.Text != "2")
            {
                odabuton2.BackColor = Color.Coral;
                odabuton2.Enabled = false;
            }







            connect.Open();
            SqlCommand komut2 = new SqlCommand("select*from oda3", connect);
            SqlDataReader read3 = komut2.ExecuteReader();

            while (read3.Read())
            {
                odabuton3.Text = read3["Adi"].ToString() + " " + read3["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton3.Text != "3")
            {
                odabuton3.BackColor = Color.Coral;
                odabuton3.Enabled = false;
            }









            connect.Open();
            SqlCommand komut3 = new SqlCommand("select*from oda4", connect);
            SqlDataReader read4 = komut3.ExecuteReader();

            while (read4.Read())
            {
                odabuton4.Text = read4["Adi"].ToString() + " " + read4["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton4.Text != "4")
            {
                odabuton4.BackColor = Color.Coral;
                odabuton4.Enabled = false;
            }







            connect.Open();
            SqlCommand komut4 = new SqlCommand("select*from oda5", connect);
            SqlDataReader read5 = komut4.ExecuteReader();

            while (read5.Read())
            {
                odabuton5.Text = read5["Adi"].ToString() + " " + read5["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton5.Text != "5")
            {
                odabuton5.BackColor = Color.Coral;
                odabuton5.Enabled = false;
            }







            connect.Open();
            SqlCommand komut5 = new SqlCommand("select*from oda6", connect);
            SqlDataReader read6 = komut5.ExecuteReader();

            while (read6.Read())
            {
                odabuton6.Text = read6["Adi"].ToString() + " " + read6["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton6.Text != "6")
            {
                odabuton6.BackColor = Color.Coral;
                odabuton6.Enabled = false;
            }







            connect.Open();
            SqlCommand komut6 = new SqlCommand("select*from oda7", connect);
            SqlDataReader read7 = komut6.ExecuteReader();

            while (read7.Read())
            {
                odabuton7.Text = read7["Adi"].ToString() + " " + read7["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton7.Text != "7")
            {
                odabuton7.BackColor = Color.Coral;
                odabuton7.Enabled = false;
            }







            connect.Open();
            SqlCommand komut7 = new SqlCommand("select*from oda8", connect);
            SqlDataReader read8 = komut7.ExecuteReader();

            while (read8.Read())
            {
                odabuton8.Text = read8["Adi"].ToString() + " " + read8["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton8.Text != "8")
            {
                odabuton8.BackColor = Color.Coral;
                odabuton7.Enabled = false;
            }






            connect.Open();
            SqlCommand komut8 = new SqlCommand("select*from oda9", connect);
            SqlDataReader read9 = komut8.ExecuteReader();

            while (read9.Read())
            {
                odabuton9.Text = read9["Adi"].ToString() + " " + read9["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton9.Text != "9")
            {
                odabuton9.BackColor = Color.Coral;
                odabuton9.Enabled = false;
            }





            connect.Open();
            SqlCommand komut9 = new SqlCommand("select*from oda10", connect);
            SqlDataReader read10 = komut9.ExecuteReader();

            while (read10.Read())
            {
                odabuton10.Text = read10["Adi"].ToString() + " " + read10["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton10.Text != "10")
            {
                odabuton10.BackColor = Color.Coral;
                odabuton10.Enabled = false;
            }






            connect.Open();
            SqlCommand komut10 = new SqlCommand("select*from oda11", connect);
            SqlDataReader read11 = komut10.ExecuteReader();

            while (read11.Read())
            {
                odabuton11.Text = read11["Adi"].ToString() + " " + read11["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton11.Text != "11")
            {
                odabuton111.BackColor = Color.Coral;
                odabuton111.Enabled = false;
            }





            connect.Open();
            SqlCommand komut11 = new SqlCommand("select*from oda12", connect);
            SqlDataReader read12 = komut11.ExecuteReader();

            while (read12.Read())
            {
                odabuton12.Text = read12["Adi"].ToString() + " " + read12["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton12.Text != "12")
            {
                odabuton12.BackColor = Color.Coral;
                odabuton12.Enabled = false;
            }





            connect.Open();
            SqlCommand komut12 = new SqlCommand("select*from oda13", connect);
            SqlDataReader read13 = komut12.ExecuteReader();

            while (read13.Read())
            {
                odabuton13.Text = read13["Adi"].ToString() + " " + read13["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton13.Text != "13")
            {
                odabuton13.BackColor = Color.Coral;
                odabuton13.Enabled = false;
            }





            connect.Open();
            SqlCommand komut13 = new SqlCommand("select*from oda14", connect);
            SqlDataReader read14 = komut13.ExecuteReader();

            while (read14.Read())
            {
                odabuton14.Text = read14["Adi"].ToString() + " " + read14["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton14.Text != "14")
            {
                odabuton14.BackColor = Color.Coral;
                odabuton14.Enabled = false;
            }





            connect.Open();
            SqlCommand komut14 = new SqlCommand("select*from oda15", connect);
            SqlDataReader read15 = komut14.ExecuteReader();

            while (read15.Read())
            {
                odabuton15.Text = read15["Adi"].ToString() + " " + read15["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton15.Text != "15")
            {
                odabuton15.BackColor = Color.Coral;
                odabuton15.Enabled = false;
            }





            connect.Open();
            SqlCommand komut15 = new SqlCommand("select*from oda16", connect);
            SqlDataReader read16 = komut15.ExecuteReader();

            while (read16.Read())
            {
                odabuton16.Text = read16["Adi"].ToString() + " " + read16["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton16.Text != "16")
            {
                odabuton16.BackColor = Color.Coral;
                odabuton16.Enabled = false;
            }





            connect.Open();
            SqlCommand komut16 = new SqlCommand("select*from oda17", connect);
            SqlDataReader read17 = komut16.ExecuteReader();

            while (read17.Read())
            {
                odabuton17.Text = read17["Adi"].ToString() + " " + read17["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton17.Text != "17")
            {
                odabuton17.BackColor = Color.Coral;
                odabuton17.Enabled = false;
            }




            connect.Open();
            SqlCommand komut17 = new SqlCommand("select*from oda18", connect);
            SqlDataReader read18 = komut17.ExecuteReader();

            while (read18.Read())
            {
                odabuton18.Text = read18["Adi"].ToString() + " " + read18["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton18.Text != "18")
            {
                odabuton18.BackColor = Color.Coral;
                odabuton18.Enabled = false;
            }





            connect.Open();
            SqlCommand komut18 = new SqlCommand("select*from oda19", connect);
            SqlDataReader read19 = komut18.ExecuteReader();

            while (read19.Read())
            {
                odabuton19.Text = read19["Adi"].ToString() + " " + read19["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton19.Text != "19")
            {
                odabuton19.BackColor = Color.Coral;
                odabuton19.Enabled = false;
            }





            connect.Open();
            SqlCommand komut19 = new SqlCommand("select*from oda20", connect);
            SqlDataReader read20 = komut19.ExecuteReader();

            while (read20.Read())
            {
                odabuton20.Text = read20["Adi"].ToString() + " " + read20["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton20.Text != "20")
            {
                odabuton20.BackColor = Color.Coral;
                odabuton20.Enabled = false;
            }



            connect.Open();
            SqlCommand komut20 = new SqlCommand("select*from oda21", connect);
            SqlDataReader read21 = komut20.ExecuteReader();

            while (read21.Read())
            {
                odabuton21.Text = read21["Adi"].ToString() + " " + read21["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton21.Text != "21")
            {
                odabuton21.BackColor = Color.Coral;
                odabuton21.Enabled = false;
            }




            connect.Open();
            SqlCommand komut21 = new SqlCommand("select*from oda22", connect);
            SqlDataReader read22 = komut21.ExecuteReader();

            while (read22.Read())
            {
                odabuton22.Text = read22["Adi"].ToString() + " " + read22["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton22.Text != "22")
            {
                odabuton22.BackColor = Color.Coral;
                odabuton22.Enabled = false;
            }



            connect.Open();
            SqlCommand komut22 = new SqlCommand("select*from oda23", connect);
            SqlDataReader read23 = komut22.ExecuteReader();

            while (read23.Read())
            {
                odabuton23.Text = read23["Adi"].ToString() + " " + read23["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton23.Text != "23")
            {
                odabuton23.BackColor = Color.Coral;
                odabuton23.Enabled = false;
            }



            connect.Open();
            SqlCommand komut23 = new SqlCommand("select*from oda24", connect);
            SqlDataReader read24 = komut23.ExecuteReader();

            while (read24.Read())
            {
                odabuton24.Text = read24["Adi"].ToString() + " " + read24["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton24.Text != "24")
            {
                odabuton24.BackColor = Color.Coral;
                odabuton24.Enabled = false;
            }




            connect.Open();
            SqlCommand komut24 = new SqlCommand("select*from oda25", connect);
            SqlDataReader read25 = komut24.ExecuteReader();

            while (read25.Read())
            {
                odabuton25.Text = read25["Adi"].ToString() + " " + read25["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton25.Text != "25")
            {
                odabuton25.BackColor = Color.Coral;
                odabuton25.Enabled = false;
            }




            connect.Open();
            SqlCommand komut25 = new SqlCommand("select*from oda26", connect);
            SqlDataReader read26 = komut25.ExecuteReader();

            while (read26.Read())
            {
                odabuton26.Text = read21["Adi"].ToString() + " " + read21["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton26.Text != "26")
            {
                odabuton26.BackColor = Color.Coral;
                odabuton26.Enabled = false;
            }



            connect.Open();
            SqlCommand komut26 = new SqlCommand("select*from oda27", connect);
            SqlDataReader read27 = komut26.ExecuteReader();

            while (read27.Read())
            {
                odabuton27.Text = read27["Adi"].ToString() + " " + read27["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton27.Text != "27")
            {
                odabuton27.BackColor = Color.Coral;
                odabuton27.Enabled = false;
            }




            connect.Open();
            SqlCommand komut27 = new SqlCommand("select*from oda28", connect);
            SqlDataReader read28 = komut27.ExecuteReader();

            while (read28.Read())
            {
                odabuton28.Text = read28["Adi"].ToString() + " " + read28["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton28.Text != "28")
            {
                odabuton28.BackColor = Color.Coral;
                odabuton28.Enabled = false;
            }




            connect.Open();
            SqlCommand komut28 = new SqlCommand("select*from oda29", connect);
            SqlDataReader read29 = komut28.ExecuteReader();

            while (read29.Read())
            {
                odabuton29.Text = read29["Adi"].ToString() + " " + read29["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton29.Text != "29")
            {
                odabuton29.BackColor = Color.Coral;
                odabuton29.Enabled = false;
            }



            connect.Open();
            SqlCommand komut29 = new SqlCommand("select*from oda30", connect);
            SqlDataReader read30 = komut29.ExecuteReader();

            while (read30.Read())
            {
                odabuton30.Text = read30["Adi"].ToString() + " " + read30["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton30.Text != "30")
                
            {
                odabuton30.BackColor = Color.Coral;
                odabuton30.Enabled = false;
            }



            connect.Open();
            SqlCommand komut30 = new SqlCommand("select*from oda31", connect);
            SqlDataReader read31 = komut30.ExecuteReader();

            while (read31.Read())
            {
                odabuton31.Text = read31["Adi"].ToString() + " " + read31["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton31.Text != "31")
            {
                odabuton31.BackColor = Color.Coral;
                odabuton31.Enabled = false;
            }




            connect.Open();
            SqlCommand komut31 = new SqlCommand("select*from oda32", connect);
            SqlDataReader read32 = komut31.ExecuteReader();

            while (read32.Read())
            {
                odabuton32.Text = read32["Adi"].ToString() + " " + read32["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton32.Text != "32")
            {
                odabuton32.BackColor = Color.Coral;
                odabuton32.Enabled = false;
            }




            connect.Open();
            SqlCommand komut32 = new SqlCommand("select*from oda33", connect);
            SqlDataReader read33 = komut32.ExecuteReader();

            while (read33.Read())
            {
                odabuton33.Text = read33["Adi"].ToString() + " " + read33["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton33.Text != "33")
            {
                odabuton33.BackColor = Color.Coral;
                odabuton33.Enabled = false;
            }




            connect.Open();
            SqlCommand komut33 = new SqlCommand("select*from oda34", connect);
            SqlDataReader read34 = komut33.ExecuteReader();

            while (read34.Read())
            {
                odabuton34.Text = read34["Adi"].ToString() + " " + read34["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton34.Text != "34")
            {
                odabuton34.BackColor = Color.Coral;
                odabuton34.Enabled = false;
            }



            connect.Open();
            SqlCommand komut34 = new SqlCommand("select*from oda35", connect);
            SqlDataReader read35 = komut34.ExecuteReader();

            while (read35.Read())
            {
                odabuton35.Text = read35["Adi"].ToString() + " " + read35["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton35.Text != "35")
            {
                odabuton35.BackColor = Color.Coral;
                odabuton35.Enabled = false;
            }



            connect.Open();
            SqlCommand komut35 = new SqlCommand("select*from oda36", connect);
            SqlDataReader read36 = komut35.ExecuteReader();

            while (read36.Read())
            {
                odabuton36.Text = read36["Adi"].ToString() + " " + read36["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton36.Text != "36")
            {
                odabuton36.BackColor = Color.Coral;
                odabuton36.Enabled = false;
            }




            connect.Open();
            SqlCommand komut36 = new SqlCommand("select*from oda37", connect);
            SqlDataReader read37 = komut36.ExecuteReader();

            while (read37.Read())
            {
                odabuton37.Text = read37["Adi"].ToString() + " " + read37["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton37.Text != "37")
            {
                odabuton37.BackColor = Color.Coral;
                odabuton37.Enabled = false;
            }




            connect.Open();
            SqlCommand komut37 = new SqlCommand("select*from oda38", connect);
            SqlDataReader read38 = komut37.ExecuteReader();

            while (read38.Read())
            {
                odabuton38.Text = read38["Adi"].ToString() + " " + read38["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton38.Text != "38")
                
            {
                odabuton38.BackColor = Color.Coral;
                odabuton38.Enabled = false;
            }




            connect.Open();
            SqlCommand komut38 = new SqlCommand("select*from oda39", connect);
            SqlDataReader read39 = komut38.ExecuteReader();

            while (read39.Read())
            {
                odabuton39.Text = read39["Adi"].ToString() + " " + read39["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton39.Text != "39")
            {
                odabuton39.BackColor = Color.Coral;
                odabuton39.Enabled = false;
            }

            connect.Open();
            SqlCommand komut39 = new SqlCommand("select*from oda40", connect);
            SqlDataReader read40 = komut39.ExecuteReader();

            while (read40.Read())
            {
                odabuton40.Text = read40["Adi"].ToString() + " " + read40["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton40.Text != "40")
            {
                odabuton40.BackColor = Color.Coral;
                odabuton40.Enabled = false;
            }


            connect.Open();
            SqlCommand komut40 = new SqlCommand("select*from oda41", connect);
            SqlDataReader read41 = komut40.ExecuteReader();

            while (read41.Read())
            {
                odabuton41.Text = read41["Adi"].ToString() + " " + read41["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton41.Text != "41")
            {
                odabuton41.BackColor = Color.Coral;
                odabuton41.Enabled = false;
            }



            connect.Open();
            SqlCommand komut41 = new SqlCommand("select*from oda42", connect);
            SqlDataReader read42 = komut41.ExecuteReader();

            while (read42.Read())
            {
                odabuton42.Text = read42["Adi"].ToString() + " " + read42["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton42.Text != "42")
            {
                odabuton42.BackColor = Color.Coral;
                odabuton42.Enabled = false;
            }



            connect.Open();
            SqlCommand komut42 = new SqlCommand("select*from oda43", connect);
            SqlDataReader read43 = komut42.ExecuteReader();

            while (read43.Read())
            {
                odabuton43.Text = read43["Adi"].ToString() + " " + read43["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton43.Text != "43")
            {
                odabuton43.BackColor = Color.Coral;
                odabuton43.Enabled = false;
            }



            connect.Open();
            SqlCommand komut43 = new SqlCommand("select*from oda44", connect);
            SqlDataReader read44 = komut43.ExecuteReader();

            while (read44.Read())
            {
                odabuton44.Text = read44["Adi"].ToString() + " " + read44["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton44.Text != "44")
            {
                odabuton44.BackColor = Color.Coral;
                odabuton44.Enabled = false;
            }



            connect.Open();
            SqlCommand komut44 = new SqlCommand("select*from oda45", connect);
            SqlDataReader read45 = komut44.ExecuteReader();

            while (read45.Read())
            {
                odabuton45.Text = read45["Adi"].ToString() + " " + read45["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton45.Text != "45")
            {
                odabuton45.BackColor = Color.Coral;
                odabuton45.Enabled = false;
            }



            connect.Open();
            SqlCommand komut45 = new SqlCommand("select*from oda46", connect);
            SqlDataReader read46 = komut45.ExecuteReader();

            while (read46.Read())
            {
                odabuton46.Text = read38["Adi"].ToString() + " " + read38["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton46.Text != "46")
            {
                odabuton46.BackColor = Color.Coral;
                odabuton46.Enabled = false;
            }



            connect.Open();
            SqlCommand komut46 = new SqlCommand("select*from oda47", connect);
            SqlDataReader read47 = komut46.ExecuteReader();

            while (read47.Read())
            {
                odabuton47.Text = read47["Adi"].ToString() + " " + read47["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton47.Text != "47")
            {
                odabuton47.BackColor = Color.Coral;
                odabuton47.Enabled = false;
            }



            connect.Open();
            SqlCommand komut47 = new SqlCommand("select*from oda48", connect);
            SqlDataReader read48 = komut47.ExecuteReader();

            while (read48.Read())
            {
                odabuton48.Text = read48["Adi"].ToString() + " " + read48["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton48.Text != "48")
            {
                odabuton48.BackColor = Color.Coral;
                odabuton48.Enabled = false;
            }



            connect.Open();
            SqlCommand komut48 = new SqlCommand("select*from oda49", connect);
            SqlDataReader read49 = komut48.ExecuteReader();

            while (read49.Read())
            {
                odabuton49.Text = read49["Adi"].ToString() + " " + read49["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton49.Text != "49")
            {
                odabuton49.BackColor = Color.Coral;
                odabuton49.Enabled = false;
            }



            connect.Open();
            SqlCommand komut49 = new SqlCommand("select*from oda50", connect);
            SqlDataReader read50 = komut49.ExecuteReader();

            while (read50.Read())
            {
                odabuton50.Text = read50["Adi"].ToString() + " " + read50["Soyadi"].ToString();

            }
            connect.Close();
            if (odabuton50.Text != "50")
            {
                odabuton50.BackColor = Color.Coral;
                odabuton50.Enabled = false;
            }



            connect.Open();
            SqlCommand komut50 = new SqlCommand("select*from oda51", connect);
            SqlDataReader read51 = komut50.ExecuteReader();

            while (read51.Read())
            {
                odabuton51.Text = read51["Adi"].ToString() + " " + read51["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton51.Text != "51")
            {
                odabuton51.BackColor = Color.Coral;
                odabuton51.Enabled = false;
            }



            connect.Open();
            SqlCommand komut51 = new SqlCommand("select*from oda52", connect);
            SqlDataReader read52 = komut51.ExecuteReader();

            while (read52.Read())
            {
                odabuton52.Text = read52["Adi"].ToString() + " " + read52["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton52.Text != "52")
            {
                odabuton52.BackColor = Color.Coral;
                odabuton52.Enabled = false;
            }



            connect.Open();
            SqlCommand komut52 = new SqlCommand("select*from oda53", connect);
            SqlDataReader read53 = komut52.ExecuteReader();

            while (read53.Read())
            {
                odabuton53.Text = read53["Adi"].ToString() + " " + read53["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton53.Text != "53")
            {
                odabuton53.BackColor = Color.Coral;
                odabuton53.Enabled = false;
            }



            connect.Open();
            SqlCommand komut53 = new SqlCommand("select*from oda54", connect);
            SqlDataReader read54 = komut53.ExecuteReader();

            while (read54.Read())
            {
                odabuton54.Text = read54["Adi"].ToString() + " " + read54["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton54.Text != "54")
            {
                odabuton54.BackColor = Color.Coral;
                odabuton54.Enabled = false;
            }




            connect.Open();
            SqlCommand komut54 = new SqlCommand("select*from oda55", connect);
            SqlDataReader read55 = komut54.ExecuteReader();

            while (read55.Read())
            {
                odabuton55.Text = read55["Adi"].ToString() + " " + read55["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton55.Text != "55")
            {
                odabuton55.BackColor = Color.Coral;
                odabuton55.Enabled = false;
            }



            connect.Open();
            SqlCommand komut55 = new SqlCommand("select*from oda56", connect);
            SqlDataReader read56 = komut55.ExecuteReader();

            while (read56.Read())
            {
                odabuton56.Text = read56["Adi"].ToString() + " " + read56["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton56.Text != "56")
            {
                odabuton56.BackColor = Color.Coral;
                odabuton56.Enabled = false;
            }

            connect.Open();
            SqlCommand komut56 = new SqlCommand("select*from oda57", connect);
            SqlDataReader read57 = komut56.ExecuteReader();

            while (read57.Read())
            {
                odabuton57.Text = read38["Adi"].ToString() + " " + read57["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton57.Text != "57")
            {
                odabuton57.BackColor = Color.Coral;
                odabuton57.Enabled = false;
            }



            connect.Open();
            SqlCommand komut57 = new SqlCommand("select*from oda58", connect);
            SqlDataReader read58 = komut57.ExecuteReader();

            while (read58.Read())
            {
                odabuton59.Text = read58["Adi"].ToString() + " " + read58["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton58.Text != "58")
            {
                odabuton58.BackColor = Color.Coral;
                odabuton58.Enabled = false;
            }



            connect.Open();
            SqlCommand komut58 = new SqlCommand("select*from oda59", connect);
            SqlDataReader read59 = komut58.ExecuteReader();

            while (read59.Read())
            {
                odabuton59.Text = read59["Adi"].ToString() + " " + read59["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton59.Text != "59")
            {
                odabuton59.BackColor = Color.Coral;
                odabuton59.Enabled = false;
            }



            connect.Open();
            SqlCommand komut59 = new SqlCommand("select*from oda60", connect);
            SqlDataReader read60 = komut59.ExecuteReader();

            while (read60.Read())
            {
                odabuton60.Text = read60["Adi"].ToString() + " " + read60["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton60.Text != "60")
            {
                odabuton60.BackColor = Color.Coral;
                odabuton60.Enabled = false;
            }



            connect.Open();
            SqlCommand komut60 = new SqlCommand("select*from oda61", connect);
            SqlDataReader read61 = komut60.ExecuteReader();

            while (read61.Read())
            {
                odabuton61.Text = read61["Adi"].ToString() + " " + read61["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton61.Text != "61")
            {
                odabuton61.BackColor = Color.Coral;
                odabuton61.Enabled = false;
            }



            connect.Open();
            SqlCommand komut61 = new SqlCommand("select*from oda62", connect);
            SqlDataReader read62 = komut61.ExecuteReader();

            while (read62.Read())
            {
                odabuton62.Text = read62["Adi"].ToString() + " " + read62["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton62.Text != "62")
            {
                odabuton62.BackColor = Color.Coral;
                odabuton62.Enabled = false;
            }



            connect.Open();
            SqlCommand komut62 = new SqlCommand("select*from oda63", connect);
            SqlDataReader read63 = komut62.ExecuteReader();

            while (read63.Read())
            {
                odabuton63.Text = read63["Adi"].ToString() + " " + read63["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton63.Text != "63")
            {
                odabuton63.BackColor = Color.Coral;
                odabuton63.Enabled = false;
            }


            connect.Open();
            SqlCommand komut63 = new SqlCommand("select*from oda64", connect);
            SqlDataReader read64 = komut63.ExecuteReader();

            while (read64.Read())
            {
                odabuton64.Text = read64["Adi"].ToString() + " " + read64["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton64.Text != "64")
            {
                odabuton64.BackColor = Color.Coral;
                odabuton64.Enabled = false;
            }


            connect.Open();
            SqlCommand komut64 = new SqlCommand("select*from oda65", connect);
            SqlDataReader read65 = komut64.ExecuteReader();

            while (read65.Read())
            {
                odabuton65.Text = read65["Adi"].ToString() + " " + read65["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton65.Text != "65")
            {
                odabuton65.BackColor = Color.Coral;
                odabuton65.Enabled = false;
            }


            connect.Open();
            SqlCommand komut65 = new SqlCommand("select*from oda66", connect);
            SqlDataReader read66 = komut65.ExecuteReader();

            while (read66.Read())
            {
                odabuton66.Text = read66["Adi"].ToString() + " " + read66["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton66.Text != "66")
            {
                odabuton66.BackColor = Color.Coral;
                odabuton66.Enabled = false;
            }



            connect.Open();
            SqlCommand komut66 = new SqlCommand("select*from oda67", connect);
            SqlDataReader read67 = komut66.ExecuteReader();

            while (read67.Read())
            {
                odabuton67.Text = read67["Adi"].ToString() + " " + read67["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton67.Text != "67")
            {
                odabuton67.BackColor = Color.Coral;
                odabuton67.Enabled = false;
            }



            connect.Open();
            SqlCommand komut67 = new SqlCommand("select*from oda68", connect);
            SqlDataReader read68 = komut67.ExecuteReader();

            while (read68.Read())
            {
                odabuton68.Text = read68["Adi"].ToString() + " " + read68["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton68.Text != "68")
            {
                odabuton68.BackColor = Color.Coral;
                odabuton68.Enabled = false;
            }



            connect.Open();
            SqlCommand komut68 = new SqlCommand("select*from oda69", connect);
            SqlDataReader read69= komut68.ExecuteReader();

            while (read69.Read())
            {
                odabuton69.Text = read69["Adi"].ToString() + " " + read69["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton69.Text != "69")
            {
                odabuton69.BackColor = Color.Coral;
                odabuton69.Enabled = false;
            }



            connect.Open();
            SqlCommand komut69 = new SqlCommand("select*from oda70", connect);
            SqlDataReader read70 = komut69.ExecuteReader();

            while (read70.Read())
            {
                odabuton70.Text = read70["Adi"].ToString() + " " + read70["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton70.Text != "70")
            {
                odabuton70.BackColor = Color.Coral;
                odabuton70.Enabled = false;
            }



            connect.Open();
            SqlCommand komut70 = new SqlCommand("select*from oda71", connect);
            SqlDataReader read71 = komut70.ExecuteReader();

            while (read71.Read())
            {
                odabuton71.Text = read71["Adi"].ToString() + " " + read71["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton71.Text != "71")
            {
                odabuton71.BackColor = Color.Coral;
                odabuton71.Enabled = false;
            }



            connect.Open();
            SqlCommand komut71 = new SqlCommand("select*from oda72", connect);
            SqlDataReader read72 = komut71.ExecuteReader();

            while (read72.Read())
            {
                odabuton72.Text = read72["Adi"].ToString() + " " + read72["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton72.Text != "72")
            {
                odabuton72.BackColor = Color.Coral;
                odabuton72.Enabled = false;
            }



            connect.Open();
            SqlCommand komut72 = new SqlCommand("select*from oda73", connect);
            SqlDataReader read73 = komut72.ExecuteReader();

            while (read73.Read())
            {
                odabuton73.Text = read73["Adi"].ToString() + " " + read73["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton73.Text != "73")
            {
                odabuton73.BackColor = Color.Coral;
                odabuton73.Enabled = false;
            }



            connect.Open();
            SqlCommand komut73 = new SqlCommand("select*from oda74", connect);
            SqlDataReader read74 = komut73.ExecuteReader();

            while (read74.Read())
            {
                odabuton74.Text = read74["Adi"].ToString() + " " + read74["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton74.Text != "74")
            {
                odabuton74.BackColor = Color.Coral;
                odabuton74.Enabled = false;
            }



            connect.Open();
            SqlCommand komut74 = new SqlCommand("select*from oda75", connect);
            SqlDataReader read75 = komut74.ExecuteReader();

            while (read75.Read())
            {
                odabuton75.Text = read75["Adi"].ToString() + " " + read75["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton75.Text != "75")
            {
                odabuton75.BackColor = Color.Coral;
                odabuton75.Enabled = false;
            }



            connect.Open();
            SqlCommand komut75 = new SqlCommand("select*from oda76", connect);
            SqlDataReader read76 = komut75.ExecuteReader();

            while (read76.Read())
            {
                odabuton76.Text = read76["Adi"].ToString() + " " + read76["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton76.Text != "76")
            {
                odabuton76.BackColor = Color.Coral;
                odabuton76.Enabled = false;
            }



            connect.Open();
            SqlCommand komut76 = new SqlCommand("select*from oda77", connect);
            SqlDataReader read77 = komut76.ExecuteReader();

            while (read77.Read())
            {
                odabuton77.Text = read77["Adi"].ToString() + " " + read77["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton77.Text != "77")
            {
                odabuton77.BackColor = Color.Coral;
                odabuton77.Enabled = false;
            }



            connect.Open();
            SqlCommand komut77 = new SqlCommand("select*from oda78", connect);
            SqlDataReader read78 = komut77.ExecuteReader();

            while (read78.Read())
            {
                odabuton78.Text = read78["Adi"].ToString() + " " + read78["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton78.Text != "78")
            {
                odabuton78.BackColor = Color.Coral;
                odabuton78.Enabled = false;
            }



            connect.Open();
            SqlCommand komut78 = new SqlCommand("select*from oda79", connect);
            SqlDataReader read79 = komut78.ExecuteReader();

            while (read79.Read())
            {
                odabuton79.Text = read79["Adi"].ToString() + " " + read79["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton79.Text != "79")
            {
                odabuton79.BackColor = Color.Coral;
                odabuton79.Enabled = false;
            }



            connect.Open();
            SqlCommand komut79 = new SqlCommand("select*from oda80", connect);
            SqlDataReader read80 = komut79.ExecuteReader();

            while (read80.Read())
            {
                odabuton80.Text = read80["Adi"].ToString() + " " + read80["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton80.Text != "80")
            {
                odabuton80.BackColor = Color.Coral;
                odabuton80.Enabled = false;
            }



            connect.Open();
            SqlCommand komut80 = new SqlCommand("select*from oda81", connect);
            SqlDataReader read81 = komut80.ExecuteReader();

            while (read81.Read())
            {
                odabuton81.Text = read81["Adi"].ToString() + " " + read81["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton81.Text != "81")
            {
                odabuton81.BackColor = Color.Coral;
                odabuton81.Enabled = false;
            }



            connect.Open();
            SqlCommand komut81 = new SqlCommand("select*from oda82", connect);
            SqlDataReader read82 = komut81.ExecuteReader();

            while (read82.Read())
            {
                odabuton82.Text = read82["Adi"].ToString() + " " + read82["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton82.Text != "82")
            {
                odabuton82.BackColor = Color.Coral;
                odabuton82.Enabled = false;

            }


            connect.Open();
            SqlCommand komut82 = new SqlCommand("select*from oda83", connect);
            SqlDataReader read83 = komut82.ExecuteReader();

            while (read83.Read())
            {
                odabuton83.Text = read83["Adi"].ToString() + " " + read83["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton83.Text != "83")
            {
                odabuton83.BackColor = Color.Coral;
                odabuton83.Enabled = false;
            }


            connect.Open();
            SqlCommand komut83 = new SqlCommand("select*from oda84", connect);
            SqlDataReader read84 = komut83.ExecuteReader();

            while (read84.Read())
            {
                odabuton84.Text = read84["Adi"].ToString() + " " + read84["Soyadi"].ToString();
            }
            connect.Close();
            if (odabuton84.Text != "84")
            {
                odabuton84.BackColor = Color.Coral;
                odabuton84.Enabled = false;




                connect.Open();
                SqlCommand komut84 = new SqlCommand("select*from oda85", connect);
                SqlDataReader read85 = komut84.ExecuteReader();

                while (read85.Read())
                {
                    odabuton85.Text = read85["Adi"].ToString() + " " + read85["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton85.Text != "85")
                {
                    odabuton85.BackColor = Color.Coral;
                    odabuton85.Enabled = false;
                }



                connect.Open();
                SqlCommand komut85 = new SqlCommand("select*from oda86", connect);
                SqlDataReader read86 = komut85.ExecuteReader();

                while (read86.Read())
                {
                    odabuton86.Text = read86["Adi"].ToString() + " " + read86["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton86.Text != "86")
                {
                    odabuton86.BackColor = Color.Coral;
                    odabuton86.Enabled = false;
                }


                connect.Open();
                SqlCommand komut86 = new SqlCommand("select*from oda63", connect);
                SqlDataReader read87 = komut86.ExecuteReader();

                while (read87.Read())
                {
                    odabuton87.Text = read87["Adi"].ToString() + " " + read87["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton87.Text != "87")
                {
                    odabuton87.BackColor = Color.Coral;
                    odabuton87.Enabled = false;
                }


                connect.Open();
                SqlCommand komut87 = new SqlCommand("select*from oda88", connect);
                SqlDataReader read88 = komut87.ExecuteReader();

                while (read88.Read())
                {
                    odabuton88.Text = read88["Adi"].ToString() + " " + read88["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton88.Text != "88")
                {
                    odabuton88.BackColor = Color.Coral;
                    odabuton88.Enabled = false;
                }


                connect.Open();
                SqlCommand komut88 = new SqlCommand("select*from oda89", connect);
                SqlDataReader read89 = komut88.ExecuteReader();

                while (read89.Read())
                {
                    odabuton89.Text = read89["Adi"].ToString() + " " + read89["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton89.Text != "89")
                {
                    odabuton89.BackColor = Color.Coral;
                    odabuton89.Enabled = false;
                }


                connect.Open();
                SqlCommand komut89 = new SqlCommand("select*from oda90", connect);
                SqlDataReader read90 = komut89.ExecuteReader();

                while (read90.Read())
                {
                    odabuton90.Text = read90["Adi"].ToString() + " " + read90["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton90.Text != "90")
                {
                    odabuton90.BackColor = Color.Coral;
                    odabuton90.Enabled = false;
                }

                connect.Open();
                SqlCommand komut90 = new SqlCommand("select*from oda91", connect);
                SqlDataReader read91 = komut90.ExecuteReader();

                while (read91.Read())
                {
                    odabuton91.Text = read91["Adi"].ToString() + " " + read91["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton91.Text != "91")
                {
                    odabuton91.BackColor = Color.Coral;
                    odabuton91.Enabled = false;
                }


                connect.Open();
                SqlCommand komut91 = new SqlCommand("select*from oda92", connect);
                SqlDataReader read92 = komut91.ExecuteReader();

                while (read92.Read())
                {
                    odabuton92.Text = read92["Adi"].ToString() + " " + read92["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton92.Text != "92")
                {
                    odabuton92.BackColor = Color.Coral;
                    odabuton92.Enabled = false;
                }

                connect.Open();
                SqlCommand komut92 = new SqlCommand("select*from oda93", connect);
                SqlDataReader read93 = komut92.ExecuteReader();

                while (read93.Read())
                {
                    odabuton93.Text = read93["Adi"].ToString() + " " + read93["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton93.Text != "93")
                {
                    odabuton93.BackColor = Color.Coral;
                    odabuton93.Enabled = false;
                }


                connect.Open();
                SqlCommand komut93 = new SqlCommand("select*from oda94", connect);
                SqlDataReader read94 = komut93.ExecuteReader();

                while (read94.Read())
                {
                    odabuton94.Text = read94["Adi"].ToString() + " " + read94["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton94.Text != "94")
                {
                    odabuton94.BackColor = Color.Coral;
                    odabuton94.Enabled = false;
                }


                connect.Open();
                SqlCommand komut94 = new SqlCommand("select*from oda95", connect);
                SqlDataReader read95 = komut94.ExecuteReader();

                while (read95.Read())
                {
                    odabuton95.Text = read95["Adi"].ToString() + " " + read95["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton95.Text != "95")
                {
                    odabuton95.BackColor = Color.Coral;
                    odabuton95.Enabled = false;
                }


                connect.Open();
                SqlCommand komut95 = new SqlCommand("select*from oda96", connect);
                SqlDataReader read96 = komut95.ExecuteReader();

                while (read96.Read())
                {
                    odabuton96.Text = read96["Adi"].ToString() + " " + read96["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton96.Text != "96")
                {
                    odabuton96.BackColor = Color.Coral;
                    odabuton96.Enabled = false;
                }


                connect.Open();
                SqlCommand komut96 = new SqlCommand("select*from oda97", connect);
                SqlDataReader read97 = komut96.ExecuteReader();

                while (read97.Read())
                {
                    odabuton97.Text = read97["Adi"].ToString() + " " + read97["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton97.Text != "97")
                {
                    odabuton97.BackColor = Color.Coral;
                    odabuton97.Enabled = false;
                }


                connect.Open();
                SqlCommand komut97 = new SqlCommand("select*from oda98", connect);
                SqlDataReader read98 = komut97.ExecuteReader();

                while (read98.Read())
                {
                    odabuton98.Text = read98["Adi"].ToString() + " " + read98["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton98.Text != "98")
                {
                    odabuton98.BackColor = Color.Coral;
                    odabuton98.Enabled = false;
                }


                connect.Open();
                SqlCommand komut98 = new SqlCommand("select*from oda99", connect);
                SqlDataReader read99 = komut98.ExecuteReader();

                while (read99.Read())
                {
                    odabuton99.Text = read99["Adi"].ToString() + " " + read99["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton99.Text != "99")
                {
                    odabuton99.BackColor = Color.Coral;
                    odabuton99.Enabled = false;
                }


                connect.Open();
                SqlCommand komut99 = new SqlCommand("select*from oda100", connect);
                SqlDataReader read100 = komut99.ExecuteReader();

                while (read100.Read())
                {
                    odabuton100.Text = read100["Adi"].ToString() + " " + read100["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton100.Text != "100")
                {
                    odabuton100.BackColor = Color.Coral;
                    odabuton100.Enabled = false;
                }


                connect.Open();
                SqlCommand komut100 = new SqlCommand("select*from oda101", connect);
                SqlDataReader read101 = komut100.ExecuteReader();

                while (read101.Read())
                {
                    odabuton101.Text = read101["Adi"].ToString() + " " + read101["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton101.Text != "101")
                {
                    odabuton101.BackColor = Color.Coral;
                    odabuton101.Enabled = false;
                }


                connect.Open();
                SqlCommand komut101 = new SqlCommand("select*from oda102", connect);
                SqlDataReader read102 = komut101.ExecuteReader();

                while (read102.Read())
                {
                    odabuton102.Text = read102["Adi"].ToString() + " " + read102["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton102.Text != "102")
                {
                    odabuton102.BackColor = Color.Coral;
                    odabuton102.Enabled = false;
                }


                connect.Open();
                SqlCommand komut102 = new SqlCommand("select*from oda103", connect);
                SqlDataReader read103 = komut102.ExecuteReader();

                while (read103.Read())
                {
                    odabuton103.Text = read103["Adi"].ToString() + " " + read103["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton103.Text != "103")
                {
                    odabuton103.BackColor = Color.Coral;
                    odabuton103.Enabled = false;


                    connect.Open();
                SqlCommand komut103 = new SqlCommand("select*from oda104", connect);
                SqlDataReader read104 = komut103.ExecuteReader();

                while (read104.Read())
                {
                    odabuton104.Text = read104["Adi"].ToString() + " " + read104["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton104.Text != "104")
                {
                    odabuton104.BackColor = Color.Coral;
                    odabuton104.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut104 = new SqlCommand("select*from oda105", connect);
                SqlDataReader read105 = komut104.ExecuteReader();

                while (read105.Read())
                {
                    odabuton105.Text = read105["Adi"].ToString() + " " + read105["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton105.Text != "105")
                {
                    odabuton105.BackColor = Color.Coral;
                    odabuton105.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut105 = new SqlCommand("select*from oda106", connect);
                SqlDataReader read106 = komut105.ExecuteReader();

                while (read106.Read())
                {
                    odabuton106.Text = read106["Adi"].ToString() + " " + read106["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton106.Text != "106")
                {
                    odabuton106.BackColor = Color.Coral;
                    odabuton106.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut106 = new SqlCommand("select*from oda107", connect);
                SqlDataReader read107 = komut106.ExecuteReader();

                while (read107.Read())
                {
                    odabuton107.Text = read107["Adi"].ToString() + " " + read107["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton107.Text != "107")
                {
                    odabuton107.BackColor = Color.Coral;
                    odabuton107.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut107 = new SqlCommand("select*from oda108", connect);
                SqlDataReader read108 = komut107.ExecuteReader();

                while (read108.Read())
                {
                    odabuton108.Text = read108["Adi"].ToString() + " " + read108["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton108.Text != "108")
                {
                    odabuton108.BackColor = Color.Coral;
                    odabuton108.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut108 = new SqlCommand("select*from oda109", connect);
                SqlDataReader read109 = komut108.ExecuteReader();

                while (read109.Read())
                {
                    odabuton109.Text = read109["Adi"].ToString() + " " + read109["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton109.Text != "109")
                {
                    odabuton109.BackColor = Color.Coral;
                    odabuton109.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut109 = new SqlCommand("select*from oda110", connect);
                SqlDataReader read110 = komut109.ExecuteReader();

                while (read110.Read())
                {
                    odabuton110.Text = read110["Adi"].ToString() + " " + read110["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton110.Text != "110")
                {
                    odabuton110.BackColor = Color.Coral;
                    odabuton110.Enabled = false;
                    }

                connect.Open();
                SqlCommand komut110 = new SqlCommand("select*from oda111", connect);
                SqlDataReader read111 = komut110.ExecuteReader();

                while (read111.Read())
                {
                    odabuton111.Text = read111["Adi"].ToString() + " " + read111["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton111.Text != "111")
                {
                    odabuton111.BackColor = Color.Coral;
                    odabuton111.Enabled = false;
                    }

                connect.Open();
                SqlCommand komut111 = new SqlCommand("select*from oda112", connect);
                SqlDataReader read112 = komut111.ExecuteReader();

                while (read112.Read())
                {
                    odabuton112.Text = read112["Adi"].ToString() + " " + read112["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton112.Text != "112")
                {
                    odabuton112.BackColor = Color.Coral;
                    odabuton112.Enabled = false;
                    }

                connect.Open();
                SqlCommand komut112 = new SqlCommand("select*from oda113", connect);
                SqlDataReader read113 = komut112.ExecuteReader();

                while (read113.Read())
                {
                    odabuton113.Text = read113["Adi"].ToString() + " " + read113["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton113.Text != "113")
                {
                    odabuton113.BackColor = Color.Coral;
                    odabuton113.Enabled = false;
                    }

                connect.Open();
                SqlCommand komut113 = new SqlCommand("select*from oda114", connect);
                SqlDataReader read114 = komut113.ExecuteReader();

                while (read114.Read())
                {
                    odabuton114.Text = read114["Adi"].ToString() + " " + read114["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton114.Text != "114")
                {
                    odabuton114.BackColor = Color.Coral;
                    odabuton114.Enabled = false;


                    }

                connect.Open();
                SqlCommand komut114 = new SqlCommand("select*from oda115", connect);
                SqlDataReader read115 = komut114.ExecuteReader();

                while (read115.Read())
                {
                    odabuton115.Text = read115["Adi"].ToString() + " " + read115["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton115.Text != "115")
                {
                    odabuton115.BackColor = Color.Coral;
                    odabuton115.Enabled = false;
                    }


                connect.Open();
                SqlCommand komut115 = new SqlCommand("select*from oda116", connect);
                SqlDataReader read116= komut115.ExecuteReader();

                while (read116.Read())
                {
                    odabuton116.Text = read116["Adi"].ToString() + " " + read116["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton116.Text != "116")
                {
                    odabuton116.BackColor = Color.Coral;
                    odabuton116.Enabled = false;
                    }

                connect.Open();
                SqlCommand komut116 = new SqlCommand("select*from oda117", connect);
                SqlDataReader read117 = komut116.ExecuteReader();

                while (read117.Read())
                {
                    odabuton117.Text = read117["Adi"].ToString() + " " + read117["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton117.Text != "117")
                {
                    odabuton117.BackColor = Color.Coral;
                    odabuton117.Enabled = false;
                    }

                connect.Open();
                SqlCommand komut117 = new SqlCommand("select*from oda118", connect);
                SqlDataReader read118 = komut117.ExecuteReader();

                while (read118.Read())
                {
                    odabuton118.Text = read118["Adi"].ToString() + " " + read118["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton118.Text != "109")
                {
                    odabuton118.BackColor = Color.Coral;
                    odabuton118.Enabled = false;
                }

                connect.Open();
                SqlCommand komut118 = new SqlCommand("select*from oda119", connect);
                SqlDataReader read119 = komut118.ExecuteReader();

                while (read119.Read())
                {
                    odabuton119.Text = read119["Adi"].ToString() + " " + read119["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton119.Text != "119")
                {
                    odabuton119.BackColor = Color.Coral;
                    odabuton119.Enabled = false;
                  }

                connect.Open();
                SqlCommand komut119 = new SqlCommand("select*from oda120", connect);
                SqlDataReader read120 = komut119.ExecuteReader();

                while (read120.Read())
                {
                    odabuton120.Text = read120["Adi"].ToString() + " " + read120["Soyadi"].ToString();
                }
                connect.Close();
                if (odabuton120.Text != "120")
                {   
                    odabuton120.BackColor = Color.Coral;
                    odabuton120.Enabled = false;
                    }



               }
            }

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Simge Durumuna Küçült");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Kapat");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odalar gecis9 = new Odalar();
            gecis9.Show();
            this.Hide();
        }
    }
}

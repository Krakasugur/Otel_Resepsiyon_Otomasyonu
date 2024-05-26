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

namespace Otel_Resepsiyon_Otomasyonu
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        private void PictureKucult_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Simge Durumuna Küçült");
        }

        private void PictureKapat_MouseHover(object sender, EventArgs e)
        {
                toolTip1.SetToolTip(pictureBox1, "Kapat");
        }

        private void PictureKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonkaydet_Click(object sender, EventArgs e)
        {
            FormKayıt gecis = new FormKayıt();
            gecis.Show();
            this.Hide();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MüşteriBilgileri gecis2 = new MüşteriBilgileri();
            gecis2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odalar gecis3 = new Odalar();
            gecis3.Show();
            this.Hide();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formgiris gecis4 = new Formgiris();
            gecis4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGelirGider gecis5 = new FormGelirGider();
            gecis5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormParola gecis6 = new FormParola();
            gecis6.Show();
            this.Hide();
        }
    }
}

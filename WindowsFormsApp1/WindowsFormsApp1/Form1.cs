using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FlappyBird : Form
    {
        int cubukHizi = 5;//Çubukların konumlarının ötelenme miktarını belirlediğimiz değişken.
        int yerCekimi = 5;//Kuşa etki edecek yer çekiminin değeri.
        int score = 0;//Her cubuğu geçtiğimizde artacak olan score değişkenimiz.İlk değeri 0.

        public FlappyBird()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)//timer fonksiyonu içindeki işlemleri ayarlanan milisaniye cinsinden süreyle çalıştırır.  
        {
            kus.Top += yerCekimi;//Kuş picturebox ının tepe değerini yer çekimi değişkeniyle toplayarak kuşun aşşağı doğru hareketini sağlıyoruz.
            //Form sayfamızın y kordinatları yukardan aşşağı doğru artan şekildedir.
            //Burada ise cubuklarımızın hareketini sağlıyoruz.Çubuğun solunun x kordinatını alıp bunu cubukhızı kadar öteliyoruz.
            altBoru.Left -= cubukHizi;
            ustBoru.Left -= cubukHizi;
            //Labelimıza score değişkenini yazdırıyoruz.
            label1.Text = "SCORE: " + score;

            //if sorgularında ise çubuklar ekrandan çıktıktan sonra çubuk spawn etme kodunu yazıyoruz.
            if (altBoru.Left < -110)
            {
                altBoru.Left = 600;
                score++;
            }
            if (ustBoru.Left < -110)
            {
                ustBoru.Left = 590;
                
            }
            //İf sorgusunun içine kuşumuzun sınırları ile çubuklarımızın, zeminimizin veya sayfamızın en üst sınırları kesişirse oyunumuzunsonlanmasını sağlayan kodumuz var. 
            if(kus.Bounds.IntersectsWith(ustBoru.Bounds)
                ||kus.Bounds.IntersectsWith(altBoru.Bounds)
                || kus.Bounds.IntersectsWith(zemin.Bounds) 
                || kus.Top < 0)
            {
                timer1.Stop();//oyunumuzun durması için timer nesnemizin durması gerekiyor.
                label1.Text="OYUN BİTTİ";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Zıplama için space tuşunun atanmasını yapıyoruz ve tuşa basıldığında yer çekimini eksi yaparak zıplamasını sağlıyoruz.
        private void tusBas(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = -10;
            }
        }
        //Space tuşunu bıraktığımızda yerçekiminin değrini eski haline getiriyoruz.
        private void tusCek(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 5;
            }


        }
    }
}

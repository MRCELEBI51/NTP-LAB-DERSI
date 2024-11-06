using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void XOClick(object sender, EventArgs e)
        {

            Button bt = sender as Button;
            //Label text içerisinde yazan karakter X ise buton texti X ile değiştiriyoruz ve tekrar basılamaması için etkin durumunu false yapıyoruz.Label texti ise O ile değiştiriyoruz.
            if (label1.Text == "X")
            {
                bt.Text = "X";
                bt.Enabled = false;
                label1.Text = "O";
            }
            else//Label text X değilse diğer ihtimal olan O için yukardaki işlemlerin aynısını yapıyoruz.
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text = "X";
            }


            // X karakterinin kazanma ihtimalllerini sorguluyoruz.
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X KAZANDI."); 
                finish();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X KAZANDI.");
                finish();
            }



            // O karakteri kazanma ihtimallerini sorguluyoruz.

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
               MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O KAZANDI.");
                finish();
            }
            //Bütün butonların texti dolu olduğunda oyun berabere kalmış olacaktır.Bu if sorgusunda da bunu sorguluyoruz.
            if(button1.Text!="" 
                && button2.Text != "" 
                && button3.Text != "" 
                && button4.Text != "" 
                && button5.Text != ""
                && button6.Text != "" 
                && button7.Text != "" 
                && button8.Text != "" 
                && button9.Text != "")
            {
                MessageBox.Show("BERABERE");
                finish();
            }

        }
        //Finish addlı fonksiyonumuz ile oyunumuzu başlangıçdaki değerlerine getiriyoruz.
        private void finish()
        {
            label1.Text = "X";
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}

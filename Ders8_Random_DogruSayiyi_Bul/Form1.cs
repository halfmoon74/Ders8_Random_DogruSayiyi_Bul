using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders8_Random_DogruSayiyi_Bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rasgele,sayac;
        private void btn_start_Click(object sender, EventArgs e)
        {
            
            btn_control.Enabled = true;
            Random random = new Random();
            rasgele = random.Next(0,100);
            sayac = 10;
            lbl_sayac.Text = sayac.ToString() + "Hakkınız var";
            lbl_durum.Text = "";
            txt_sayi.Text = "";


        }

        private void btn_control_Click(object sender, EventArgs e)
        {
            if (txt_sayi.Text=="")
            {
                lbl_durum.Text = "Sayı giriniz!";
            }
            else
            {
                int girilensayi = Convert.ToInt32(txt_sayi.Text);
                if (girilensayi < rasgele)
                {
                    lbl_durum.Text = "Sayıyı Arttır!";
                    sayac--;
                    
                }
                else if (girilensayi > rasgele)
                {
                    lbl_durum.Text = "Sayıyı Azalt";
                    sayac--;
                    
                }
                else
                {
                    lbl_durum.Text = "TEBRİKLER KAZANDINIZ!";
                    btn_control.Enabled =false;
                }

                lbl_sayac.Text = sayac.ToString() + "hakkınız kaldı";
            }
            if (sayac==0)
            {
                lbl_sayac.Text = "Hakkınız bitti";
                lbl_durum.Text = "Kazanamadınız. Tekrar deneyiniz";
                btn_control.Enabled=false;
                    

            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_control.Enabled = false;
            lbl_sayac.Text = "10 hakkınız var";
        }
    }
}

/********************************************************************************************************************************************************
**                                                                                                                                                     **
**                                                                                                                                                     **
**                                                                          SAKARYA ÜNİVERSİTESİ                                                       **
**                                                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                            ** 
**                                                                      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                 ** 
**                                                                     NESNEYE DAYALI PROGRAMLAMA DERSİ                                                **
**                                                                          2019-2020 BAHAR DÖNEMİ                                                     **
**                                                                                                                                                     ** 
**                                                                ÖDEV NUMARASI...........:4-PROJE ÖDEVİ                                               ** 
**                                                                ÖĞRENCİ ADI.............:SEVDET IŞIK                                                 **                 
**                                                                ÖĞRENCİ NUMARASI........:G191210082                                                  **
**                                                                DERSİN ALINDIĞI GRUP....:2.ÖĞRETİM B GRUBU                                           **
**                                                                                                                                                     **
**                                                                                                                                                     **
**                                                                                                                                                     **
********************************************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProje
{
    public partial class formAtikOyun : Form
    {
        
        Atik camSise = new Atik("cam",600,"Cam Şişe(600)");
        Atik bardak = new Atik("cam",250,"Bardak(250)");
        Atik gazete = new Atik("kagit",250,"Gazete(250)");
        Atik dergi = new Atik("kagit",200,"Dergi(200)");
        Atik domates = new Atik("org",150,"Domates(150)");
        Atik salatalik = new Atik("org",120,"Salatalık(120)");
        Atik kolaKutusu = new Atik("metal",350,"Kola Kutusu(350)");
        Atik salcaKutusu = new Atik("metal",550,"Salça Kutusu(550)");

        atikKutusu organik = new atikKutusu(0,700);
        atikKutusu cam = new atikKutusu(600,2200);
        atikKutusu kagit = new atikKutusu(1000, 1200);
        atikKutusu metal = new atikKutusu(800,2300);

        Atik[] atiklar = new Atik[8];

        Random rastgele = new Random();
        int sayi = 0;

        int puan = 0;
        
        int time = 0;

        public formAtikOyun()
        {
            InitializeComponent();
            camSise.Image = Image.FromFile(".../Image/camsise.png");
            bardak.Image = Image.FromFile(".../Image/bardak.png");
            gazete.Image = Image.FromFile(".../Image/gazete.jpg");
            dergi.Image = Image.FromFile(".../Image/dergi.jpg");
            domates.Image = Image.FromFile(".../Image/domates.jpg");
            salatalik.Image = Image.FromFile(".../Image/salatalik.jpg");
            kolaKutusu.Image = Image.FromFile(".../Image/kutukola.jpg");
            salcaKutusu.Image = Image.FromFile(".../Image/konservekutusu.jpg");
            atiklar[0] = camSise;
            atiklar[1] = bardak;
            atiklar[2] = gazete;
            atiklar[3] = dergi;
            atiklar[4] = domates;
            atiklar[5] = salatalik;
            atiklar[6] = kolaKutusu;
            atiklar[7] = salcaKutusu;
            btnCam.Enabled = false;
            btnKagit.Enabled = false;
            btnMetal.Enabled = false;
            btnOrganik.Enabled = false;
            btnOrganikBosalt.Enabled = false;
            btnMetalBosalt.Enabled = false;
            btnCamBosalt.Enabled = false;
            btnKagitBosalt.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Eğer atık türü metalse ve kutuda boş yer varsa atık kutuya ekleniyor.
            if (atiklar[sayi].atikTuru == "metal")
            {
                if (metal.Ekle(atiklar[sayi]))
                {
                    
                    puan += atiklar[sayi].Hacim;
                    lblPuan.Text = Convert.ToString(puan);
                    listboxMetal.Items.Add(atiklar[sayi].atikIsmi);
                    resimCikar();
                    pgBarMetal.Value = metal.DolulukOrani;                                      
                }
                
            }
        }

        

        private void btnOrganik_Click(object sender, EventArgs e)
        {
            // Eğer atık türü organikse ve kutuda boş yer varsa atık kutuya ekleniyor.
            if (atiklar[sayi].atikTuru == "org")
            {
                if (organik.Ekle(atiklar[sayi]))
                {            
                    puan += atiklar[sayi].Hacim;
                    lblPuan.Text = Convert.ToString(puan);
                    listboxOrganik.Items.Add(atiklar[sayi].atikIsmi);
                    resimCikar();
                    pgBarOrganik.Value = organik.DolulukOrani;
                }
                
            }
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            // Eğer atık türü kağıtsa ve kutuda boş yer varsa atık kutuya ekleniyor.
            if (atiklar[sayi].atikTuru == "kagit")
            {
                if (kagit.Ekle(atiklar[sayi]))
                {                    
                    puan += atiklar[sayi].Hacim;
                    lblPuan.Text = Convert.ToString(puan);
                    listboxKagit.Items.Add(atiklar[sayi].atikIsmi);
                    resimCikar();
                    pgBarKagit.Value = kagit.DolulukOrani;
                }
                
            }
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            // Eğer atık türü camsa ve kutuda boş yer varsa atık kutuya ekleniyor.
            if (atiklar[sayi].atikTuru == "cam")
            {
                if(cam.Ekle(atiklar[sayi]))
                {                    
                    puan += atiklar[sayi].Hacim;
                    lblPuan.Text = Convert.ToString(puan);
                    listboxCam.Items.Add(atiklar[sayi].atikIsmi);
                    resimCikar();
                    pgBarCam.Value = cam.DolulukOrani;
                }                           
            }
        }

        private void resimCikar()
        {
            int oncekiSayi = sayi;
            sayi = rastgele.Next(8);
            // Random fonksiyonunun çok sayıda aynı atığı getirmesini engellemek için kurulan while döngüsü.
            // Eğer random alınan sayı bir öncekiyle aynıysa, aynı olmayana kadar random sayı alınmaya devam ediliyor.
            while (sayi == oncekiSayi)
            {
                sayi = rastgele.Next(8);
            }
            picAtik.Image = atiklar[sayi].Image;
            picAtik.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Yeni oyun butonuna tıklandığında puan ve süre label'larının arka plan rengi değişiyor,yeni oyun butonu işlevsiz hale geliyor
        // Listbox'larda item varsa siliniyor,Puanlar ve doluluk oranları 0'a eşitleniyor.
        // Disabled olan oyun  butonları enabled hale getiriliyor.
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            lblPuan.BackColor = Color.Aqua;
            lblSureSayac.BackColor = Color.Aqua;
            listboxCam.Items.Clear();
            listboxKagit.Items.Clear();
            listboxMetal.Items.Clear();
            listboxOrganik.Items.Clear();
            lblPuan.Text = "0";
            pgBarCam.Value = 0;
            pgBarKagit.Value = 0;
            pgBarMetal.Value = 0;
            pgBarOrganik.Value = 0;
                
            time = 60;
            btnCam.Enabled = true;
            btnKagit.Enabled = true;
            btnMetal.Enabled = true;
            btnOrganik.Enabled = true;
            btnOrganikBosalt.Enabled = true;
            btnMetalBosalt.Enabled = true;
            btnCamBosalt.Enabled = true;
            btnKagitBosalt.Enabled = true;
            listboxCam.Enabled = true;
            listboxMetal.Enabled = true;
            listboxKagit.Enabled = true;
            listboxOrganik.Enabled = true;

            resimCikar();
            timer1.Interval = 1000;
            timer1.Start();
            btnYeniOyun.Enabled = false; 
           
        }

        // Çıkış butonuna basıldığında form ekranı kapatılıyor.
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrganikBosalt_Click(object sender, EventArgs e)
        {
            // Eğer organik kutusu boşaltma metodu true döndürürse puana boşaltma puanı ekleniyor,puan güncelleniyor,doluluk oranı 0'lanıyor
            // Süreye 3 saniye eklenip listbox boşaltılıyor.
            if (organik.Bosalt())
            {               
                puan += organik.BosaltmaPuani;
                lblPuan.Text = Convert.ToString(puan);
                pgBarOrganik.Value = organik.DolulukOrani;
                listboxOrganik.Items.Clear();
                time += 3;
            }
            
        }

        private void btnKagitBosalt_Click(object sender, EventArgs e)
        {

            // Eğer kağıt kutusu boşaltma metodu true döndürürse puana boşaltma puanı ekleniyor,puan güncelleniyor,doluluk oranı 0'lanıyor
            // Süreye 3 saniye eklenip listbox boşaltılıyor.
            if (kagit.Bosalt())
            {               
                puan += kagit.BosaltmaPuani;
                lblPuan.Text = Convert.ToString(puan);
                listboxKagit.Items.Clear();
                pgBarKagit.Value = kagit.DolulukOrani;
                time += 3;
            }           
        }

        private void btnCamBosalt_Click(object sender, EventArgs e)
        {

            // Eğer cam kutusu boşaltma metodu true döndürürse puana boşaltma puanı ekleniyor,puan güncelleniyor,doluluk oranı 0'lanıyor
            // Süreye 3 saniye eklenip listbox boşaltılıyor.
            if (cam.Bosalt())
            {               
                puan += cam.BosaltmaPuani;
                lblPuan.Text = Convert.ToString(puan);
                listboxCam.Items.Clear();
                pgBarCam.Value = cam.DolulukOrani;
                time += 3;
            }            
        }


        private void btnMetalBosalt_Click(object sender, EventArgs e)
        {

            // Eğer metal kutu boşaltma metodu true döndürürse puana boşaltma puanı ekleniyor,puan güncelleniyor,doluluk oranı 0'lanıyor
            // Süreye 3 saniye eklenip listbox boşaltılıyor.
            if (metal.Bosalt())
            {                
                puan += metal.BosaltmaPuani;
                lblPuan.Text = Convert.ToString(puan);
                listboxMetal.Items.Clear();
                pgBarMetal.Value = metal.DolulukOrani;
                time += 3;
            }            
        }

        private void picAtik_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Eğer zamanı tutan değişken 0'dan farklıysa süre azalıyor.
            if (time != 0)
            {
                time--;
                lblSureSayac.Text = time.ToString();
            }

            // Eğer zaman 0'lanırsa oyun sonlanıyor ve gerekli işlemler yapılıyor.
            else
            {
                lblPuan.BackColor = Color.White;
                lblSureSayac.BackColor = Color.White;
                timer1.Stop();
                time = 0;
                cam.DoluHacim = 0;
                cam.DolulukOrani = 0;
                metal.DoluHacim = 0;
                metal.DolulukOrani = 0;
                kagit.DoluHacim = 0;
                kagit.DolulukOrani = 0;
                organik.DoluHacim = 0;
                organik.DolulukOrani = 0;
                puan = 0;
                btnCam.Enabled = false;
                btnKagit.Enabled = false;
                btnMetal.Enabled = false;
                btnOrganik.Enabled = false;
                btnOrganikBosalt.Enabled = false;
                btnMetalBosalt.Enabled = false;
                btnCamBosalt.Enabled = false;
                btnKagitBosalt.Enabled = false;
                btnYeniOyun.Enabled = true;
                listboxCam.Enabled = false;
                listboxKagit.Enabled = false;
                listboxMetal.Enabled = false;
                listboxOrganik.Enabled = false;
            }
        }
    }

    public interface IAtik
    {
        int Hacim { get; set; }
        System.Drawing.Image Image { get; set; }
    }

    public interface IAtikKutusu : IDolabilen
    {
        /// <summary>
        /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
        /// </summary>
        int BosaltmaPuani { get; }
        /// <summary>
        /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.
        /// </summary>
        /// <param name="atik">Eklenecek Atık</param>
        /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>
        bool Ekle(Atik atik);

        /// <summary>
        /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
        /// </summary>
        /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>
        bool Bosalt();
    }


    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }



    public class Atik:IAtik
    {
        public int Hacim { get; set; } = 100;
        public string atikTuru { get; set; }
        public System.Drawing.Image Image { get; set; }
        public string atikIsmi { get; set; }

        // Atik class'ının kurucu fonksiyonunda değer atamaları yapılıyor.
        public Atik(string tur , int hacim,string isim)
        {
            atikTuru = tur;
            Hacim = hacim;
            atikIsmi = isim;
        }

    }

    
    class atikKutusu : IDolabilen
    {
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; } = 0;
        public int DolulukOrani { get; set; } = 0;
        public int BosaltmaPuani { get; set; }

        // atikKutusu class'ının kurucu fonksiyonunda değer atamaları yapılıyor.
        public atikKutusu(int puan,int kapasite)
        {
            BosaltmaPuani = puan;
            Kapasite = kapasite;
        }

        // Kutuya atık ekleme metodu.
        public bool Ekle(Atik atik)
        {

            // Eğer DoluHacim+atik.Hacim değeri kapasiteye eşit veya küçükse atık kutuya ekleniyor.
            if (DoluHacim + atik.Hacim <= Kapasite)
            {
                DoluHacim = DoluHacim + atik.Hacim;
                DolulukOrani = ((DoluHacim) * 100) / Kapasite;
                return true;
            }

            return false;
        }

        // Kutuyu boşaltma metodu
        public bool Bosalt()
        {

            // Eğer DolulukOrani değişkeninin değeri 75'ten büyük veya eşitse Bosalt() metodu kutuyu boşaltıp,doluluk oranı ve dolu hacmi 0'a eşitliyor.
            if (DolulukOrani >= 75)
            {
                DolulukOrani = 0;
                DoluHacim = 0;
                
                return true;
            }
            return false;
        }
    }
    

}

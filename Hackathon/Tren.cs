using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon
{
    public class Tren
    {
        public int max_hiz { get; set; }
        public int genel_bakim_km { get; set; }
        public int genel_bakimsure { get; set; }
        public int seferarasi_bakimsure { get; set; }
        public int kazanc { get; set; }
        public int durak_süresi { get; set; }
        public int toplamgidilen_mesafe { get; set; }
        public float toplam_süre { get; set; }
        public String tren_adi { get; set; }
        public int sefer_uzunlugu { get; set; }
        public bool bakimdaMi { get; set; }
        public float gün_dakika { get; set; }
        public float cikis_dk { get; set; }
        public float varis_dk { get; set; }
        public int tren_adet { get;set; }
        public int toplam_kazanc { get; set; }

        public float ortHiz()
        {
            float toplam_süreH = this.toplam_süre / 60;
            return this.toplamgidilen_mesafe / toplam_süreH;
        }
        public void Kesisme(int []gidis ,int[]donus, char[]durak_isim,char[]durak_donus,int[]kacinci_km,DataGridView dgv)
        {
            float yol=0f;
            int sayac = 0;
            while (this.toplam_süre <= this.gün_dakika)
            {
                if (bakimdaMi == false)
                {
                    for (int i = 0; i < gidis.Length; i++)
                    {
                        
                        dgv.Rows.Add(this.tren_adi, durak_isim[i], yol, this.toplamgidilen_mesafe, (this.toplam_süre/60), this.toplam_kazanc,this.ortHiz(),this.durak_süresi,(this.genel_bakimsure/60));
                        //MessageBox.Show(this.tren_adi + " Adlı tren " + durak_isim[i] + " Durakta Duraklar Arası Kat edilen yol " + yol + " Toplam Alınan Yol " + this.toplamgidilen_mesafe + " Geçen süre " + this.toplam_süre+" Kazanç miktarı "+this.toplam_kazanc);
                        yol = gidis[i];
                        kacinci_km[i] = this.toplamgidilen_mesafe;
                        this.toplamgidilen_mesafe += gidis[i];
                        this.toplam_süre += (yol / this.max_hiz) * 60;

                        if (i != gidis.Length - 1 && i != 0)
                        {
                            this.toplam_süre += this.durak_süresi;
                        }
                        if (i == gidis.Length - 1)
                        {
                            MessageBox.Show(""+this.tren_adi+" Sefer sonrası bakım süresine girdi");
                            this.toplam_süre += this.seferarasi_bakimsure;
                            this.toplam_kazanc += this.kazanc;
                            

                            // MessageBox.Show("Sefer bitti toplam geçen süre: " + this.toplam_süre.ToString() + "Toplam yol:" + this.toplamgidilen_mesafe.ToString());
                        }
                    }
                    this.varis_dk += this.toplam_süre;
                    if (this.toplamgidilen_mesafe >= this.genel_bakim_km)
                    {
                        MessageBox.Show("" + this.tren_adi + " Genel Bakıma Girdi");
                        this.bakimdaMi = true;
                        this.toplamgidilen_mesafe -= this.genel_bakim_km;
                        this.toplam_süre += this.genel_bakimsure;
                    }
                }
                while (this.toplam_süre <= this.gün_dakika)
                {
                    this.durakDonusMesafeHesapla(donus, durak_donus, kacinci_km,dgv);
                    break;
                }
                    
            }
            
        }
        public void durakDonusMesafeHesapla(int[] donus, char[]durak_isim,int[]kacinci_km,DataGridView dgv)
        {
            float yol=0f;
            if (bakimdaMi == false)
            {
                for (int i=0; i <donus.Length; i++)
                {
                    dgv.Rows.Add(this.tren_adi, durak_isim[i], yol, this.toplamgidilen_mesafe, (this.toplam_süre/60), this.toplam_kazanc, this.ortHiz(), this.durak_süresi, (this.genel_bakimsure/60));
                    //MessageBox.Show(this.tren_adi + " Adlı tren " + durak_isim[i] + " Durakta Duraklar Arası Kat edilen yol " + donus[i] + " Toplam Alınan Yol " + this.toplamgidilen_mesafe + " Geçen süre " + this.toplam_süre+" Kazanç miktarı "+this.toplam_kazanc);
                    yol = donus[i];
                    kacinci_km[i] = this.toplamgidilen_mesafe;
                    this.toplamgidilen_mesafe += donus[i];
                    this.toplam_süre += (yol / this.max_hiz) * 60;
                    if (i != donus.Length - 1 && i != 0)
                    {
                        this.toplam_süre += this.durak_süresi;
                    }
                    if (i == donus.Length-1)
                    {
                        this.toplam_süre += this.seferarasi_bakimsure;
                        this.toplam_kazanc +=this.kazanc;
                    }
                }
            }
            if (this.toplamgidilen_mesafe >= this.genel_bakim_km)
            {
                this.bakimdaMi = true;
                this.toplamgidilen_mesafe -= this.genel_bakim_km;
                this.toplam_süre += this.genel_bakimsure;
            }

        }
    }
}

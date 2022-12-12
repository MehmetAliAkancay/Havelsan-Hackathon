using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    public class AnahatTreni:Tren
    {
        public Char[] durak_isim = { 'N', 'K', 'P', 'R', 'D', 'S', 'P' };
        public int[] durak_mesafe = { 100, 100, 75, 50, 50, 75,0 };
        public char[] durak_donus = { 'P', 'S', 'D', 'R', 'P', 'K', 'N' };
        public int[] durak_mesafe_donus = { 0, 75, 50, 50, 75, 100, 100 };
        public int[] kacinci_km = new int[7];

        public AnahatTreni()
        {
            this.max_hiz = 100;
            this.genel_bakim_km = 2500;
            this.genel_bakimsure = 1440;
            this.seferarasi_bakimsure = 240;
            this.kazanc = 45000;
            this.durak_süresi = 20;
            this.tren_adi = "Anahat Treni";
            this.sefer_uzunlugu = 450;
            this.bakimdaMi = false;
            this.cikis_dk = 25;
        }
    }
}

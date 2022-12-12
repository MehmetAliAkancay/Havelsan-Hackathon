using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    public class HizTreni : Tren
    {
        public char[] durak_isim = { 'A', 'B', 'C', 'D', 'E', 'F', 'O' };
        public int[] durak_mesafe = { 100, 75, 100, 75, 75, 25,0 };
        public char[] durak_donus = { 'O', 'F', 'E', 'D', 'C', 'B', 'A' };
        public int[] durak_mesafe_donus = { 0, 25, 75, 75, 100, 75, 100 };
        public int[] kacinci_km = new int[7];
        public HizTreni()
        {
            this.max_hiz = 200;
            this.genel_bakim_km = 6000;
            this.genel_bakimsure = 720;
            this.seferarasi_bakimsure = 120;
            this.kazanc = 60000;
            this.durak_süresi = 15;
            this.tren_adi = "Hız Treni";
            this.sefer_uzunlugu = 450;
            this.bakimdaMi = false;
            this.cikis_dk = 25;
            this.gün_dakika = 0f;
        }
    }
}

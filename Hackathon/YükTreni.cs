using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    public class YükTreni:Tren
    {
        public Char[] durak_isim = { 'G', 'H', 'I', 'F', 'J', 'K', 'L' };
        public int[] durak_mesafe = { 77, 82, 50, 97, 100, 112, 100 };
        public char[] durak_donus = { 'L', 'K', 'J', 'F', 'I', 'H', 'G' };
        public int[] durak_mesafe_donus = { 100, 112, 100, 97, 50, 82, 77 };
        public int[] kacinci_km = new int[7];
        public YükTreni()
        {
            this.max_hiz = 75;
            this.genel_bakim_km = 3000;
            this.genel_bakimsure = 2160;
            this.seferarasi_bakimsure = 180;
            this.kazanc = 50000;
            this.durak_süresi = 0;
            this.tren_adi = "Yük Treni";
            this.sefer_uzunlugu = 618;
            this.bakimdaMi = false;
            this.cikis_dk = 5;
        }
    }
}

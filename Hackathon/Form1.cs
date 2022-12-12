using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon
{
    public partial class Form1 : Form
    {
        DataTable tablo = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTrenOzellik_Click(object sender, EventArgs e)
        {
            TrenOzellik tren = new TrenOzellik();
            tren.Show();
        }

        private void btnTrenRota_Click(object sender, EventArgs e)
        {
            TrenlerinRotaEkrani trenRota = new TrenlerinRotaEkrani();
            trenRota.Show();
        }

        private void btnSefer_Click(object sender, EventArgs e)
        {
            YükTreni[] yuk = new YükTreni[Convert.ToInt16(txtYuk.Text)];
            AnahatTreni[] anahat = new AnahatTreni[Convert.ToInt16(txtAnahat.Text)];
            HizTreni[] hiz = new HizTreni[Convert.ToInt16(txtHiz.Text)];
            if (Convert.ToInt16(txtHiz.Text)<2)
            {
                MessageBox.Show("Lütfen 2 veya 2'den büyük bir değer giriniz.");
            }
            else if(Convert.ToInt16(txtYuk.Text) < 1||Convert.ToInt16(txtAnahat.Text) < 1)
            {
                MessageBox.Show("Lütfen 1 veya 1 den büyük bir değer giriniz.");
            }
            else
            {

                for (int i = 0; i < Convert.ToInt16(txtHiz.Text); i++)

                {
                    hiz[i] = new HizTreni()
                    {
                        tren_adi = "HT-0" + (i + 1),
                        gün_dakika = Convert.ToInt16(txtGun.Text) * 24 * 60,
                        toplam_süre = 0f
                    };
                    hiz[i].Kesisme(hiz[i].durak_mesafe, hiz[i].durak_mesafe_donus, hiz[i].durak_isim, hiz[i].durak_donus, hiz[i].kacinci_km, dgvSefer);
                }

                for (int i = 0; i < Convert.ToInt16(txtYuk.Text); i++)
                {
                    yuk[i] = new YükTreni()
                    {
                        tren_adi = "YT-0" + (i + 1),
                        gün_dakika = Convert.ToInt16(txtGun.Text) * 24 * 60,
                        toplam_süre = 0f
                    };
                    yuk[i].Kesisme(yuk[i].durak_mesafe, yuk[i].durak_mesafe_donus, yuk[i].durak_isim, yuk[i].durak_donus, yuk[i].kacinci_km, dgvSefer);
                }

                for (int i = 0; i < Convert.ToInt16(txtAnahat.Text); i++)
                {
                    anahat[i] = new AnahatTreni()
                    {
                        tren_adi = "AT-0" + (i + 1),
                        gün_dakika = Convert.ToInt16(txtGun.Text) * 24 * 60,
                        toplam_süre = 0f
                    };
                    anahat[i].Kesisme(anahat[i].durak_mesafe, anahat[i].durak_mesafe_donus, anahat[i].durak_isim, anahat[i].durak_donus, anahat[i].kacinci_km, dgvSefer);
                }
            } 
        }
    }
}

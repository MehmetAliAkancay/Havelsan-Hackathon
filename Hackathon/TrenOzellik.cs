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
    public partial class TrenOzellik : Form
    {
        DataTable tablo = new DataTable();
        HizTreni hiz=new HizTreni();
        YükTreni yuk=new YükTreni();
        AnahatTreni anahat=new AnahatTreni();
        public TrenOzellik()
        {
            InitializeComponent();
        }

        private void TrenOzellik_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Tren Tipi", typeof(string));
            tablo.Columns.Add("Maksimum Hız", typeof(int));
            tablo.Columns.Add("Genel Bakım KM", typeof(int));
            tablo.Columns.Add("Genel Bakım Süresi(dk)", typeof(int));
            tablo.Columns.Add("Seferler Arası Minumum Bakım Aralığı(dk)", typeof(int));
            tablo.Columns.Add("Sefer Başına Kazanç", typeof(int));
            tablo.Rows.Add(yuk.tren_adi,yuk.max_hiz,yuk.genel_bakim_km,yuk.genel_bakimsure,yuk.seferarasi_bakimsure,yuk.kazanc);
            tablo.Rows.Add(anahat.tren_adi, anahat.max_hiz, anahat.genel_bakim_km, anahat.genel_bakimsure, anahat.seferarasi_bakimsure, anahat.kazanc);
            tablo.Rows.Add(hiz.tren_adi, hiz.max_hiz, hiz.genel_bakim_km, hiz.genel_bakimsure, hiz.seferarasi_bakimsure, hiz.kazanc);
            dgvTren.DataSource = tablo;
        }
    }
}

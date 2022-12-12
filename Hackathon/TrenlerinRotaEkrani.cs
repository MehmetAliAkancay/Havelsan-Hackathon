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
    public partial class TrenlerinRotaEkrani : Form
    {
        DataTable tablo = new DataTable();
        
        HizTreni hiz = new HizTreni();
        YükTreni yuk = new YükTreni();
        AnahatTreni anahat = new AnahatTreni();
        public TrenlerinRotaEkrani()
        {
            InitializeComponent();
        }

        private void TrenlerinRotaEkrani_Load(object sender, EventArgs e)
        {
            DataRow row = tablo.NewRow();
            tablo.Columns.Add("Rota-1 " + hiz.tren_adi);
            tablo.Columns.Add("Rota-2 " + yuk.tren_adi);
            tablo.Columns.Add("Rota-3 " + anahat.tren_adi);
            
            
            dgvTrenRota.DataSource = tablo;
            for(int i=0;i<hiz.durak_isim.Length;i++)
                tablo.Rows.Add(hiz.durak_isim[i]+"-"+hiz.durak_mesafe[i]);
            dgvTrenRota.DataSource = tablo;
            for (int i = 0; i < yuk.durak_isim.Length ; i++)
                dgvTrenRota.Rows[i].Cells[1].Value = yuk.durak_isim[i]+"-"+yuk.durak_mesafe[i];
            dgvTrenRota.DataSource = tablo;
            for (int i = 0; i < anahat.durak_isim.Length ; i++)
                dgvTrenRota.Rows[i].Cells[2].Value = anahat.durak_isim[i]+"-"+anahat.durak_mesafe[i];
            dgvTrenRota.DataSource = tablo;


        }
    }
}

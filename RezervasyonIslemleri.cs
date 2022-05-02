using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace hotelOasis
{
    public class RezervasyonIslemleri
    {
        Sql bgl = new Sql();
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int MusteriID { get; set; }
        public int RezervasyonTipID { get; set; }
        public double Ucret { get; set; }
        public void RezervasyonKayit()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Rezervasyonlar (GirisTarihi,CikisTarihi,MusteriID,RezervasyonTipID,Ucret) Values ('" + GirisTarihi + "','" + CikisTarihi + "','" + MusteriID + "','" + RezervasyonTipID + "','" + Ucret + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rezervasyon Yapılmıştır.");
        }
    }
}

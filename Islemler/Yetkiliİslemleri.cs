using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace hotelOasis
{
    class Yetkiliİslemleri
    {
        Sql bgl = new Sql();

        public string KullaniciAdi { get; set; }
        public string AdSoyadi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }



        public void Giris()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Y.Kullanici_Adi,Y.Sifre,A.Yetki From Tbl_Yetkililer Y inner join Tbl_Yetkiler A on Y.YetkiID = A.ID  where Kullanici_Adi=@adi AND Sifre=@sifresi AND A.Yetki=@Yetki", bgl.baglanti());
                SqlParameter prm1 = new SqlParameter("adi", KullaniciAdi.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", Sifre.Trim());
                SqlParameter prm3 = new SqlParameter("Yetki", Yetki.Trim());
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                komut.Parameters.Add(prm3);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmYonetici frmYonetici = new FrmYonetici();
                    frmYonetici.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FrmYetkiliGiris frmYetkiliGiris = new FrmYetkiliGiris();
                    frmYetkiliGiris.Show();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Boş Geçmeyin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmYetkiliGiris frmYetkiliGiris = new FrmYetkiliGiris();
                frmYetkiliGiris.Show();
            }
        }
    }
}

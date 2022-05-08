using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelOasis
{
    class OdemeSistemi
    {
        private IOdemeYontem odemeYontem;
        public OdemeSistemi(IOdemeYontem odemeYontem)
        {
            this.odemeYontem = odemeYontem;
        }
        public void OnOdemeliOdemeYap()
        {
            this.odemeYontem.OnOdemeliOdemeYap();
        }
        public void _60GunOnceOdemeYap()
        {
            this.odemeYontem._60GunOnceOdemeYap();
        }
        public void StandarOdemeYap()
        {
            this.odemeYontem.StandarOdemeYap();
        }
        public void _60GunOnceKartKaydet()
        {
            this.odemeYontem._60GunOnceKartKaydet();
        }
    }
}

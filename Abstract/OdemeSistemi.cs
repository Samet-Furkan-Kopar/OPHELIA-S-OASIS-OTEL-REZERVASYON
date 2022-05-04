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
        public void OdemeYap()
        {
            this.odemeYontem.OdemeYap();
        }
    }
}

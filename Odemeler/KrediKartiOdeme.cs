using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelOasis
{
    class KrediKartiOdeme : IOdemeYontem
    {
        public int OdemeYap()
        {
            FrmOdeme frmOdeme = new FrmOdeme();
            frmOdeme.Show();
            return 0;
        }
    }
}

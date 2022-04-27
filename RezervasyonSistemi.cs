using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelOasis
{
        class RezervasyonSistemi
    {
        private IRezervasyonTipi rezervasyonTipi;

        public RezervasyonSistemi(IRezervasyonTipi rezervasyonTipi)
        {
            this.rezervasyonTipi = rezervasyonTipi;
        }
        public void RezervasyonIslemYap()
        {
            this.rezervasyonTipi.RezervasyonIslemYap();
        }
    }
}

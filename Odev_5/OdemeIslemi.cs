using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_5
{
    public class OdemeIslemi
    {
        public IOdemeTipi iOdemeTipi;

        //constructor injection
        public OdemeIslemi(IOdemeTipi iOdemeTipi)
        {
            this.iOdemeTipi = iOdemeTipi;
        }

        public string OdemeYap(double tutar)
        {
            return iOdemeTipi.ode(tutar);
        }


    }
}

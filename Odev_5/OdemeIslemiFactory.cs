using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Odev_5
{
    public class OdemeIslemiFactory
    {
        public IOdemeTipi NesneOlustur(string className)
        {
            var newInstance = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("Odev_5." + className);
            return (IOdemeTipi)newInstance;
        }
    }
}

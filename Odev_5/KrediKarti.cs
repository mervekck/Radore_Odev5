using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Odev_5
{
public class KrediKarti : IOdemeTipi
{
public string ode(double tutar)
{
return tutar + " KrediKarti ile ödendi";
}
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponStore
{
    internal class Tactical:Pistols,IFeature
    {
        public string Name { get; private set; } = "KM.45 tactical";
        public double Price { get; private set; } = 500;
        public string CountryOfOrigin { get; private set; } = "Germany";
        public string Caliber { get; private set; } = "45 ACP";
        public string Capacity { get; private set; } = "12 Rounds";
      

       
    }
}

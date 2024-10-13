using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponStore
{
    internal class Compact:Pistols,  IFeature
    {
        public string Name { get; private set; } = "228 COMPACT";
        public double Price { get; private set; } = 600;
        public string CountryOfOrigin { get; private set; } = "Switzerland/Germany";
        public string Caliber { get; private set; } = "357 SIG";
        public string Capacity { get; private set; } = "13 Rounds";
       
    }
    
}

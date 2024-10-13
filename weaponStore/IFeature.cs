using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponStore
{
    internal interface IFeature
    {
        public double Price { get; }
        public string CountryOfOrigin { get; }
        public string Caliber { get; }
        public string Capacity { get; } 
        
      
    }
}

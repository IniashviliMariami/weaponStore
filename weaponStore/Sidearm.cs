using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponStore
{
    internal class Sidearm:Pistols,IFeature
    {
        public string Name { get; private set; } = "9*19M SIDEARM";
        public double Price { get; private set; } = 400;
        public string CountryOfOrigin { get; private set; } = "Austria";
        public string Caliber { get; private set; } = "9mm Parabellum";
        public string Capacity { get; private set; } = "20 Rounds";
       
    }
}

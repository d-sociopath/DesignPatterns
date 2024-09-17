using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Example2
{
    internal class ChocolateChipCookie : Cookie
    {
        public int ChocolateChipCount { get; set; }

        public ChocolateChipCookie(string flavor, bool hasNuts, int chocolateChipCount)
        {
            Flavor = flavor;
            HasNuts = hasNuts;
            ChocolateChipCount = chocolateChipCount;
        }
        
        public override Cookie Clone()
        {
            return (Cookie)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Chocolate Chip Cookie - Flavor : {Flavor}, Has Nuts : {HasNuts}, Chocolate Chip Count : {ChocolateChipCount}";
        }
    }
}

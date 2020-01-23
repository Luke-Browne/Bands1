using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public abstract class Band : IComparable<Band>
    {
        public string Name { get; set; }
        public string YearFormed { get; set; }
        public string Members { get; set; }

        public Band()
        {

        }

        public Band(string name, string yearFormed, string members)
        {
            Name = name;
            YearFormed = yearFormed;
            Members = members;
        }

        public int CompareTo(Band other)
        {
            string x = this.Name;
            string y = other.Name;

            return x.CompareTo(y);
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

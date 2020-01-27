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
        public DateTime YearFormed { get; set; }
        public string Members { get; set; }

        public Band() : this("Unknown", new DateTime(0,1,1), "Unknown")
        {

        }

        public Band(string name, DateTime yearFormed, string members)
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
            return Name;
        }
    }

    class RockBand : Band
    {
        public RockBand()
        {

        }
        public RockBand(string name, DateTime yearFormed, string members) : base(name, yearFormed, members)
        {

        }

        public override string ToString()
        {
            return $"{Name}" + " " + "(Rock)";
        }
    }

    class PopBand : Band
    {
        public PopBand()
        {

        }
        public PopBand(string name, DateTime yearFormed, string members) : base(name, yearFormed, members)
        {

        }

        public override string ToString()
        {
            return $"{Name}" + " " + "(Pop)";
        }
    }

    class IndieBand : Band
    {
        public IndieBand()
        {

        }
        public IndieBand(string name, DateTime yearFormed, string members) : base(name, yearFormed, members)
        {

        }

        public override string ToString()
        {
            return $"{Name}" + " " + "(Indie)";
        }
    }
}

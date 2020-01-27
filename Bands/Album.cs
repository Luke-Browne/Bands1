using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public class Album
    {
        public string AlbumName { get; set; }
        public DateTime Released { get; set; }
        public int Sales { get; set; }

        public Album()
        {

        }
        public Album(string albumName, DateTime released, int sales)
        {
            AlbumName = albumName;
            Released = released;
            Sales = sales;
        }

        public override string ToString()
        {
            int years = DateTime.Now.Year - Released.Year;

            return $"{AlbumName}, Year Released: {Released.Year}, Sales: €{Sales}, Years since release: {years}";
        }
    }
}

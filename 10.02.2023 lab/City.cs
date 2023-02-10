using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02._2023_lab
{
    internal class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public override string ToString() => Name;
        public static City operator+ (City c, int p)
        { 
            City res = new City();
            res.Population += p;
            return res;
        }
        public static City operator- (City c, int p)
        {
            City res = new City();
            res.Population -= p;
            return res;
        }
        public static bool operator== (City c1, City c2) => c1.Population == c2.Population;
        public static bool operator!= (City c1, City c2) => c1.Population != c2.Population;
        public static bool operator >(City c1, City c2) => c1.Population > c2.Population;
        public static bool operator <(City c1, City c2) => c1.Population < c2.Population;
    }
}

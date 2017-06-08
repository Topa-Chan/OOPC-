using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassEx170428
{

    //Create a City class
        //Each City has a name, population (integral data), size in square miles (non-integral data)

    public class City
    {
        public string name;
        public int population;
        public double sizeInSqMiles;

        public City(string name, int population, float size)
        {
            this.name = name;
            this.population = population;
            this.sizeInSqMiles = sizeInSqMiles;
        }

        public override string ToString()
        {
            return "City Name: " + name + ", Population: " + population + ", Size In Square Miles: " + sizeInSqMiles + ".";
        }
    }
}

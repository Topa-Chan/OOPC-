using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassEx170428
{

    //Create a CensusManager class
        //This class has a static collection of States, where each State leads to a collection of Counties

    public class CensusManager
    {

        public static Dictionary<States, County> Census = new Dictionary<States, County>();

        public static void takeCensus()
        {
            County county = new County("Salt Lake County", States.UT);
            County county1 = new County("Bell County", States.TX);
            Census.Add(States.UT, county);
            Census.Add(States.TX, county1);
            displayCensus();
        }

        public static void displayCensus()
        {
            Dictionary<States, County>.KeyCollection keys = Census.Keys;
            Dictionary<States, County>.ValueCollection values = Census.Values;
            foreach (States key in keys)
            {
                Console.WriteLine(key);
                foreach (County value in values)
                {
                    Console.WriteLine(value);
                    County.populateCity();
                }
            }
        }

    }
}

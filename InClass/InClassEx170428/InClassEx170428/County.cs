using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassEx170428
{

    //Create a County Class
        //Each County has a name, a state (i.e. UT, CA, NV, etc)
        //Each County has a collection of cities
        //Each City must be stored in a way that makes it instantly accessible by the City's name
            //Pro Tip: Use the right data structure for this

    public class County
    {
        public string name;
        public City city;
        public States state;
        public static Dictionary<string, City> Counties = new Dictionary<string, City>();

        public static void populateCity()
        {
            City salt = new City("Salt Lake City", 190884, 110.4f);
            Counties.Add("Salt Lake County", salt);
            City killeen = new City("Killeen", 5, 110.2f);
            Counties.Add("Killeen", killeen);
            Dictionary<string, City>.KeyCollection keys = Counties.Keys;
            Dictionary<string, City>.ValueCollection values = Counties.Values;
            foreach (string key in keys)
            {
                foreach (City value in values)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public County(string name, States state)
        {
            this.name = name;
            this.state = state;
        }

        public override string ToString()
        {
            return "County: " + name + ".";
            //", State: " + state + 
        }
    }
}

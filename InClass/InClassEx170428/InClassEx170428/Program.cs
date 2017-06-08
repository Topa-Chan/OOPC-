using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassEx170428
{
    public class Program
    {

        //Hard code some Counties and Cities, making sure to 
            //Store the Cities in their respective Counties
        

        //Add Counties to their respective States
        //Sort the States alphabetically, then print each State with its Counties and each County with its Cities

        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            CensusManager.takeCensus();
        }
    }
}

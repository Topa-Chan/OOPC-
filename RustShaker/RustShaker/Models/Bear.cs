using RustShaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustShaker
{
    public class Bear
    {
        //Data Fields
        private string furColour;
        private float weightInKilos;
        private int ageInYears;
        private readonly BearType flavour;
        private string name;


        //Properties
        public string FurColour { get; set; }
        public BearType Flavour { get { return flavour; } }
        public float WeightInKilos { get { return weightInKilos; } }
        public int AgeInYears { get { return ageInYears; } }
        public string Name { get { return name; } }

        //Constructors
        public Bear()
        {
            furColour = "Blue";
            weightInKilos = 150;
            ageInYears = 3;
            flavour = BearType.Gummy;
            name = "Bearisa";
        }
        
        public Bear(string furColour, float weightInKilos, int ageInYears, BearType flavour, string name)
        {
            this.furColour = furColour;
            this.weightInKilos = weightInKilos;
            this.ageInYears = ageInYears;
            this.flavour = flavour;
            this.name = name;
        }

        public override string ToString()
        {
            //return "Given Bear";
            return "Fur Colour: " + furColour + ", Weight: " + weightInKilos + "kg, Age: " + ageInYears + " years-old, Type: " + flavour + ", Name: " + name;
        }

        #region C# Properties
        //C# Properties
        //public string FurColour
        //{
        //    get { return furColour; }
        //    set { furColour = value; }
        //}
        #endregion

        #region Java Properties
        //In Java..
        //public string getFurColour()
        //{
        //    return furColour;
        //}

        //public void setFurColour(string furColour)
        //{
        //    this.furColour = furColour
        //}
        #endregion
    }
}

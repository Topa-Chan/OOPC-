using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel_Sorter
{
    public class Parcel : IComparable<Parcel>
    {

        private readonly int Id;
        private float Weight { get; set; }
        private readonly float Width;
        private readonly float Height;
        private readonly float Depth;
        private static int counter = 1;

        public int CompareTo(Parcel p)
        {
            //less than -1
            //equal to 0
            //More than 1
            double cubicMass = (Weight / (Width * Height * Depth));
            double compareMass3 = (p.Weight / (p.Width * p.Height * p.Depth));
            if (cubicMass < compareMass3)
            {
                return 1;
            }
            if (cubicMass > compareMass3)
            {
                return -1;
            }
            return 0;
        }

        public Parcel(float weight, float width, float height, float depth)
        {
            Weight = weight;
            Width = width;
            Height = height;
            Depth = depth;
            Id = counter++; 
        }

        public override string ToString()
        {
            return $"ID: {Id}\tWeight: {Weight} pounds\tDimensions: {Width}*{Depth}*{Height} inches";
        }
    }
}

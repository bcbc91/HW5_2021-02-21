using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircumferenceAndArea.Abstracts;

namespace CircumferenceAndArea.Concrete
{
    public class RightTriangle:ITriangle
    {
       
        public double Height { get; set; }
        public double BottomEdge { get; set; }
        public double CalculateArea()
        {
            double Result = (BottomEdge * Height) / 2;
             return Result;

        }

        public double CalculateCircumference()
        {
            double Result = Math.Sqrt(Math.Pow(BottomEdge, 2) + Math.Pow(Height, 2)) + BottomEdge + Height;
               return Result;
        }
    }
}

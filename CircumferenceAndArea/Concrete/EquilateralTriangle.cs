using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircumferenceAndArea.Abstracts;

namespace CircumferenceAndArea.Concrete
{
    public class EquilateralTriangle:ITriangle
    {
       
        public double BottomEdge { get; set; }
        public double CalculateArea()
        {
            double Result = (Math.Pow(BottomEdge, 2) * Math.Sqrt(3)) / 4;
            return Result;
        }

        public double CalculateCircumference()
        {
            double Result = BottomEdge * 3;
               return Result;
        }
    }
}

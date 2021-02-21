using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircumferenceAndArea.Abstracts;

namespace CircumferenceAndArea.Concrete
{
    public class Square:IQuadrangle
    {
       
        public double LongEdge { get; set; }
        public double CalculateArea()
        {
            double Result = LongEdge * LongEdge;
            return Result;
        }

        public double CalculateCircumference()
        {
            double Result = LongEdge * 4;
            return Result;
        }
    }
}

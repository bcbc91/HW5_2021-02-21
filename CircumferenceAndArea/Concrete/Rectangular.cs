using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircumferenceAndArea.Abstracts;

namespace CircumferenceAndArea.Concrete
{
    public class Rectangular:IQuadrangle
    {
        public double ShortEdge { get; set; }
        public double LongEdge { get; set; }
        public double CalculateArea()
        {
            double Result = LongEdge * ShortEdge;
            return Result;
        }

        public double CalculateCircumference()
        {
            double Result = 2 * (LongEdge + ShortEdge);
           return Result;
        }
    }
}

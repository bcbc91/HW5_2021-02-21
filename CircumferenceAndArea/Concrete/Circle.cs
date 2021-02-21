using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CircumferenceAndArea.Concrete
{
    public class Circle
    {
        
        
        
        public double Radius { get; set; }
        

        public double CalculateArea()
        {
            double Result = (Math.PI) * Math.Pow(Radius, 2);
            return Result;
        }

        public double CalculateCircumference()
        {
           double Result= 2 * (Math.PI) * Radius;
           return Result;
        }
    }
}

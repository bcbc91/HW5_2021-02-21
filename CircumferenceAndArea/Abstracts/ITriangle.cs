using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircumferenceAndArea.Abstracts
{
    interface ITriangle
    {
      
         double BottomEdge { get; set; }
         double CalculateArea();
         double CalculateCircumference();
    }
}

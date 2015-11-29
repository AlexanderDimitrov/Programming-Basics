using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.Float_Combination
{ 


          public bool NearlyEqual(double a, double b, double epsilon)
 {
    double absA = Math.Abs(a);
    double absB = Math.Abs(b);
    double diff = Math.Abs(a - b);

    if (a == b)
    {
        return true;
    }
    else if (a == 0 || b == 0 || diff < Double.MinValue)
    {

        return diff < (epsilon * Double.MinValue);
    }
    else
    { // use relative error
        return diff / (absA + absB) < epsilon;
    }
 }
}
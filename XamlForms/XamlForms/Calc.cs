using System;
using System.Collections.Generic;
using System.Text;

namespace XamlForms
{
    public class Calc
    {
        public static double GetTax(double d)
        {
            return Math.Floor(d * 1.08);
        }
    }

}

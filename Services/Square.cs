using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Square
    {
        public static string SquareReshenie (double a, double b, double c)
        {
            if (a == 0)
            {
                return "Ne rabotaet bratik";
            }
            var d = (b * b) - 4 * a * c;

            if (d < 0)
            {
                var i = -b / (2 * a);
                return $"Odin koren {i}";
            }
            {
                var x1 = (-b + Math.Sqrt(d)) / (2 * a);
                var x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"x1={x1}, x2={x2}";
            }
        }
            
    }
}

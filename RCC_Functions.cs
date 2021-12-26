using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ush_lib
{
    class RCC_Functions
    {
        public static double Beta1(double fc)
        {
            // fc in psi

            if (fc <= 4000)
            {
                return 0.85;
            }
            else if (fc >= 8000)
            {
                return 0.65;
            }
            else
            {
                return 0.85 - (fc - 4000) / 1000 * 0.05;
            }
        }

        public static double Phi_flexure(double epsilon_t)
        {
            // epsilon_t is the strain in tension fibre

            if (epsilon_t >= 0.005)
            {
                return 0.90;
            }
            else
            {
                return 0.65 + (epsilon_t - 0.002) * (250.0 / 3.0);
            }
        }

        public static double Tcr(double b, double h, double fc)
        {
           // inputs: f'c, b, h (lb, inch)

            double acp = b * h;
            double pcp = 2.0 * (b + h);
            double rootfc = Math.Sqrt(fc);

            return 4.0 * rootfc * acp * acp / pcp;
        }
    }
}

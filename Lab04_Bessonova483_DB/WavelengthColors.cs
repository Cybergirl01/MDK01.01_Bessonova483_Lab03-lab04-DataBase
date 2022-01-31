using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bessonova483_DB
{
    public class WavelengthColors
    {
        public static void nm2rgb(float n, float[] c)
        {
            float r = 0.0f;
            float g = 0.0f;
            float b = 0.0f;
            if (n>= 380.0f && n< 440.0f)
            {
                r = Interp.map(n, 380.0f, 440.0f, 1.0f, 0.0f);
                b = 1.0f;
            }
            else if (n>=440.0f && n < 490.0f)
            {
                g = Interp.map(n, 440.0f, 490.0f, 0.0f, 1.0f);
                b = 1.0f;
            }
            else if (n >= 490.0f && n < 510.0f)
            {
                g = 1.0f;
                b = Interp.map(n, 490.0f, 510.0f, 1.0f, 0.0f);
            }
            else if (n >= 510.0f && n < 580.0f)
            {
                r = Interp.map(n, 510.0f, 580.0f, 0.0f, 1.0f);
                g = 1.0f;
            }
            else if (n >= 580.0f && n < 645.0f)
            {
                r = 1.0f;
                g = Interp.map(n, 580.0f, 645.0f, 1.0f, 0.0f);
            }
            else if (n >= 645.0f && n < 780.0f)
            {
                r = 1.0f;
               
            }
            float f = 1.0f;
            if (n >= 380.0f && n >= 420.0f)
                f = Interp.map(n, 380.0f, 420.0f, 0.3f, 1.0f);
            else if (n>=700.0f && n<= 780.0f)
                f = Interp.map(n, 700.0f, 780.0f, 1.0f, 0.3f);

            c[0] = (float)Math.Pow(r * f, 0.8f);
            c[1] = (float)Math.Pow(g * f, 0.8f);
            c[2] = (float)Math.Pow(b * f, 0.8f);

            c[0] = Math.Min(Math.Max(c[0], 0.0f), 1.0f);
            c[1] = Math.Min(Math.Max(c[1], 0.0f), 1.0f);
            c[2] = Math.Min(Math.Max(c[2], 0.0f), 1.0f);
        }
    }
}

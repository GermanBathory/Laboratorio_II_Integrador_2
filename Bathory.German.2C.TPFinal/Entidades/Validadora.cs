using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        public static bool ValidarString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarIntConMaxYMin(string numero, int min, int max)
        {
            if (int.TryParse(numero, out int numeroEntero))
            {
                if (numeroEntero > min && numeroEntero < max)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidarFloatConMaxYMin(string numero, int min, int max)
        {
            if (float.TryParse(numero, out float numeroFloat))
            {
                if (numeroFloat > min && numeroFloat < max)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

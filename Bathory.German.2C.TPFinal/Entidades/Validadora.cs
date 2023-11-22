using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        /// <summary>
        /// Valida que el valor ingresado sean letras o espacios.
        /// </summary>
        /// <param name="str">Cadena a validar</param>
        /// <returns>Retorna true si se valida correctamente o false si no lo hace.</returns>
        public static bool ValidarString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]) && !char.IsWhiteSpace(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida que el valor ingresado sea un numero entero entre dos valores.
        /// </summary>
        /// <param name="numero">Valor a validar</param>
        /// <param name="min">Valor minimo</param>
        /// <param name="max">Valor maximo</param>
        /// <returns>Retorna true si se valida correctamente o false si no lo hace.</returns>
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

        /// <summary>
        /// Valida que el valor ingresado sea un numero flotante entre dos valores.
        /// </summary>
        /// <param name="numero">Valor a validar</param>
        /// <param name="min">Valor minimo</param>
        /// <param name="max">Valor maximo</param>
        /// <returns>Retorna true si se valida correctamente o false si no lo hace.</returns>
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

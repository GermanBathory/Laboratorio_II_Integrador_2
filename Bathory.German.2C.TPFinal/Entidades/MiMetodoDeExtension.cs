using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiMetodoDeExtension
    {

        public static string FormatoFechaPropio(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy");

        }

        public static string FormatoHoraPropio(this DateTime data)
        {
            return data.ToString("HH:mm");
        }
    }
}

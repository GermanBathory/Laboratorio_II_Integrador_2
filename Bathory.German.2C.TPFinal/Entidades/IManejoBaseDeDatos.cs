using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal interface IManejoBaseDeDatos<T>
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
        int AgregarNuevo(T entidad);
        bool BorrarPorId(int id);
        bool ActualizarPorId(Cliente cliente, int id);
    }
}

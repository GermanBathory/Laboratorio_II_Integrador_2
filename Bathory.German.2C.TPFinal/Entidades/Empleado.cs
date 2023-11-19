using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private int idEmpleado;
        private EEmpresa empresa;

        public Empleado()
        {
        }
        public Empleado(string nombre, string apellido, int id, EEmpresa empresa) 
            : base(nombre, apellido)
        {
            this.idEmpleado = id;
            this.empresa = empresa;
        }

        public int IdEmpleado { get => idEmpleado; }
        public EEmpresa Empresa { get => empresa; }

        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[ID de empleado: {this.IdEmpleado}] [Nombre: {this.Nombre}] " +
                $"[Apellido: {this.Apellido}] [Empresa: {this.Empresa}]");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {

        private int dni;
        private int id_cliente;


        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, int dni)
            : base(nombre, apellido)
        {
            this.dni = dni;
        }


        public int Dni
        {
            get { return GetHashCode(); }
            set
            {
                if (Validadora.ValidarIntConMaxYMin(value.ToString(), 100000, 100000000))
                {
                    dni = value;
                }
                else
                {
                    throw new Exception("DNI invalido");
                }
            }
        }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }

        public override int GetHashCode()
        {
            return this.dni;
        }

        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[Nombre: {this.Nombre}] [Apellido: {this.Apellido}] " +
                $"[DNI: {this.Dni}]");
            return sb.ToString();
        }
    }
}

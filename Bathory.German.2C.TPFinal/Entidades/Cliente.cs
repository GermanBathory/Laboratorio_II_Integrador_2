using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int id;
        private int dni;
        private int cantidadPasajes;

        public Cliente()
        {
            this.cantidadPasajes = 0;
        }

        public Cliente(string nombre, string apellido, int id, int cantidadPasajes)
            : base(nombre, apellido)
        {
            this.id = id;
            this.cantidadPasajes = cantidadPasajes;
        }

        public int Id { get => id; }

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

        public int CantidadPasajes
        {
            get { return cantidadPasajes; }
            set
            {
                if (Validadora.ValidarIntConMaxYMin(value.ToString(), -1, 1000))
                {
                    cantidadPasajes = value;
                }
                else
                {
                    throw new Exception("Cantidad invalida");
                }
            }
        }
        public override int GetHashCode()
        {
            return this.dni;
        }

        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[ID: {this.Id}] [Nombre: {this.Nombre}] [Apellido: {this.Apellido}] " +
                $"[DNI: {this.Dni}] [Cantidad de pasajes: {this.CantidadPasajes}]");
            return sb.ToString();
        }
    }
}

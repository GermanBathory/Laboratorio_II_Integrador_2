using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public abstract class Persona
    {
        private string? nombre;
        private string? apellido;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (Validadora.ValidarString(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("El nombre es invalido");
                }
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (Validadora.ValidarString(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new Exception("El apellido es invalido");
                }

            }
        }
        public abstract string MostrarInformacion();

    }
}
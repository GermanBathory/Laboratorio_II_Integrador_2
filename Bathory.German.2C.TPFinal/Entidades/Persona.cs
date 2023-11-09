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
            Nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (Validadora.ValidarString(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception("El nombre es invalido");
                }

            }
        }
    }
}
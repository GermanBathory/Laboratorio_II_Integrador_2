using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        private EEmpresa empresa;
        private ECiudad origen;
        private ECiudad destino;
        private DateTime fechaPartida;
        private DateTime horaPartida;
        private int idViaje;

        public Viaje()
        {
        }

        public Viaje(EEmpresa empresa, ECiudad origen, ECiudad destino, DateTime fechaPartida,
            DateTime horaPartida)
        {
            this.empresa = empresa;
            this.origen = origen;
            this.destino = destino;
            this.fechaPartida = fechaPartida;
            this.horaPartida = horaPartida;
        }

        public EEmpresa Empresa { get => empresa; set => empresa = value; }
        public ECiudad Origen { get => origen; set => origen = value; }
        public ECiudad Destino { get => destino; set => destino = value; }
        public DateTime FechaPartida { get => fechaPartida; set => fechaPartida = value; }
        public DateTime HoraPartida { get => horaPartida; set => horaPartida = value; }
        public int IdViaje { get => idViaje; set => idViaje = value; }
        

        public string ImprimirPasaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[Empresa: {this.Empresa}] [Origen: {this.Origen}] [Destino: {this.Destino}] " +
                $"[Fecha de Partida: {this.FechaPartida.FormatoFechaPropio()}] [Hora de Partida: {this.HoraPartida.FormatoHoraPropio()}]");
            return sb.ToString();
        }
    }
}

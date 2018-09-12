using System;
namespace Lasallistas.Models
{
    public class Partido
    {
        public long Id_Cancha
        {
            get;
            set;
        }

        public string Deporte
        {
            get;
            set;
        }

        public string Equipo1
        {
            get;
            set;
        }

        public string Equipo2
        {
            get;
            set;
        }

        public string Ganador
        {
            get;
            set;
        }

        public string Rama
        {
            get;
            set;
        }

        public string[] Resultado
        {
            get;
            set;
        }

        public Partido()
        {
        }
    }
}

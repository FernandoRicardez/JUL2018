using System;
namespace Lasallistas.Models
{
    public class Cancha
    {
        static readonly TipoUbicacionEnum TipoUbicacion = TipoUbicacionEnum.Cancha;

        public long Id_Cancha
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
     
        }

        public double Lat
        {
            get;
            set;
        }

        public double Long
        {
            get;
            set;
        }

        public Cancha()
        {
        }
    }
}

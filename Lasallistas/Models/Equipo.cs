using System;
namespace Lasallistas.Models
{
    public class Equipo
    {

        public long Id_Equipo
        {
            get;
            set;
        }

        public Universidad Universidad
        {
            get;
            set;
        }

        public Deporte Deporte
        {
            get;
            set;
        }


        public RamasEnum Rama
        {
            get;
            set;
        }

        public Equipo(long id, Universidad uni, Deporte deporte,RamasEnum rama)
        {
            Id_Equipo = id;
            Universidad = uni;
            Deporte = deporte;
            Rama = rama;

        }

    }
}

using System;
namespace Lasallistas.Models
{
    public class Deporte
    {
        public long Id_Deporte
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public int Tiempos
        {
            get;
            set;
        }

        public Deporte(long id,string nombre,int tiempos)
        {
            Id_Deporte = id;
            Nombre = nombre;
            Tiempos = tiempos;
        }
    }
}

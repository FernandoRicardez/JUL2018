using System;
using System.Collections.Generic;
namespace Lasallistas.Models
{
    public class Partido
    {
        #region Variables

        public delegate void Callback(List<Partido> partidos, string message);
        public delegate void SuccessCallback(bool success, string message);

        #endregion


        public Cancha Cancha
        {
            get;
            set;
        }

        public Deporte Deporte
        {
            get => Equipo1.Deporte==Equipo2.Deporte?Equipo1.Deporte:null;
        }

        public Equipo Equipo1
        {
            get;
            set;
        }

        public Equipo Equipo2
        {
            get;
            set;
        }

        public Equipo Ganador
        {
            get;
            set;
        }

        public RamasEnum Rama
        {
            get => Equipo1.Rama == Equipo2.Rama ? Equipo1.Rama : RamasEnum.NA;
        }

        public string[] Resultado
        {
            get;
            set;
        }

        public Partido(Cancha cancha,Equipo equipo1, Equipo equipo2,Equipo ganador,string[] resultados)
        {
            Cancha = cancha;
            Equipo1 = equipo1;
            Equipo2 = equipo2;
            Ganador = ganador;
            Resultado = resultados;

        }

        /// <summary>
        /// Gets the partidos by the given date.
        /// </summary>
        /// <param name="fechaPartidos">Fecha partidos a obtener.</param>
        /// <param name="callback">Callback.</param>
        /// <param name="localDemo">If set to <c>true</c> use local demo data.</param>
        public static void GetPartidosByDate(DateTime fechaPartidos,Callback callback,bool localDemo)
        {
            List<Partido> partidos = null;
            if (localDemo)
            {
                if (fechaPartidos.CompareTo(DateTime.Now) > 0)
                {
                    callback?.Invoke(null, "No Hay partidos programados");
                    return;
                }
                else
                {
                    var cancha = new Cancha()
                    {
                        Id_Cancha = 1,
                        Nombre = "Cancha Uruguayo",
                        Lat = 21.151705,
                        Long = -101.712811
                    };
                    var cancha2 = new Cancha()
                    {
                        Id_Cancha = 2,
                        Nombre = "Cancha Rapido",
                        Lat = 21.153266,
                        Long = -101.711799
                    };
                    var uni = new Universidad()
                    {
                        Id = 1,
                        Nombre = "Universidad De La Salle Bajio",
                        Siglas = "UDLSB",
                        Abreviatura = "Bajio"
                    };
                    var uni2 = new Universidad()
                    {
                        Id = 2,
                        Nombre = "Universidad La Salle Nezahualcoyotl",
                        Siglas = "ULSA Neza",
                        Abreviatura = "Neza"
                    };
                    var uni3 = new Universidad()
                    {
                        Id = 3,
                        Nombre = "Universidad La Salle Mexico",
                        Siglas = "ULSA Mexico",
                        Abreviatura = "Mexico"
                    };
                    var deporte = new Deporte(1,"Futbol", 2);
                    var deporte2 = new Deporte(2,"Futbol Rapido", 4);
                    var equipo1 = new Equipo(1,uni, deporte,RamasEnum.Femenil);
                    var equipo2 = new Equipo(2, uni2, deporte, RamasEnum.Femenil);
                    var equipo3 = new Equipo(3, uni3, deporte, RamasEnum.Femenil);

                    var equipo4 = new Equipo(4, uni, deporte2, RamasEnum.Varonil);
                    var equipo5 = new Equipo(5, uni2, deporte2, RamasEnum.Varonil);
                    var equipo6 = new Equipo(6, uni3, deporte2, RamasEnum.Varonil);
                    string[] result = { "1-1", "2-1" };
                    string[] result2 = { "0-0", "3-1" };
                    string[] result3 = { "1-1", "2-1","3-1","4-2" };
                    string[] result4 = { "2-1", "2-1", "3-3", "4-3" };

                    partidos = new List<Partido>
                    {
                        new Partido(cancha,equipo1,equipo2,equipo1,result),
                        new Partido(cancha,equipo2,equipo3,equipo2,result),
                        new Partido(cancha,equipo3,equipo1,equipo1,result2),

                        new Partido(cancha,equipo4,equipo5,equipo4,result3),
                        new Partido(cancha,equipo5,equipo6,equipo5,result4),
                        new Partido(cancha,equipo6,equipo4,equipo4,result3)

                    };

                    callback?.Invoke(partidos, "Se obtuvieron partidos");
                    return;
                }

            }
            else
            {
                //TODO: MAKE CALL TO API
                /*EJEMPLO A MODIFICAR
                 * var url = Remote.Shared.ApiDailyMenu.Replace("{canchaId}", canchaId.ToString()) + $"?year={year}&month={month}";
        //        var _ = Remote.Shared.RequestString("GET", url, null, null, (response, error) =>
        //        {
        //            string message = null;
        //            if (error != null)
        //            {
        //                message = error;
        //            }
        //            else
        //            {
        //                try
        //                {
        //                    partidos = JsonConvert.DeserializeObject<List<DailyMenu>>(response);
        //                }
        //                catch (Exception)
        //                {
        //                    message = response;
        //                }
        //            }
        //            callback?.Invoke(list, message);
        //        });
                */
            }

        }
    }
}

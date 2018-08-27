using System;
using System.Collections.Generic;
using Lasallistas.Data;
using Newtonsoft.Json;

namespace Lasallistas.Models
{
    /*
    public delegate void Callback(List<DailyMenu> dailyMenus, string message);

    public class Universidad
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Abreviatura { get; set; }
        public int Students_In_Group { get; set; }

        public static void GetRemoteDataForParent(long parentId, int year, int month, Callback callback)
        {
            if (parentId <= 0)
            {
                callback?.Invoke(null, "El identificador de usuario no es válido.");
                return;
            }

            List<DailyMenu> list = null;
            if (Remote.Shared.UseLocalDemo)
            {
                list = new List<DailyMenu>
                {
                    new DailyMenu
                    {
                        Id = 1,
                        Date = new DateTime(2018, month, 1),
                        Student_Id = 10,
                        Student_Name = "Miguel Hernández Martinez",
                        Students_In_Group = 25,
                        Items = new List<DailyMenuItem>
                        {
                            new DailyMenuItem
                            {
                                Id = 1,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 2,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            },
                            new DailyMenuItem
                            {
                                Id = 3,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 4,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            }
                        }
                    },
                    new DailyMenu
                    {
                        Id = 1,
                        Date = new DateTime(2018, month, 3),
                        Student_Id = 1,
                        Student_Name = "Luis Luna Vallejo",
                        Students_In_Group = 25,
                        Items = new List<DailyMenuItem>
                        {
                            new DailyMenuItem
                            {
                                Id = 1,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 2,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            },
                            new DailyMenuItem
                            {
                                Id = 3,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 4,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            }
                        }
                    },
                    new DailyMenu
                    {
                        Id = 1,
                        Date = new DateTime(2018, month, 18),
                        Student_Id = 2,
                        Student_Name = "Alejandra Luna Vallejo",
                        Students_In_Group = 25,
                        Items = new List<DailyMenuItem>
                        {
                            new DailyMenuItem
                            {
                                Id = 1,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 2,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            },
                            new DailyMenuItem
                            {
                                Id = 3,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 4,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            }
                        }
                    },
                    new DailyMenu
                    {
                        Id = 1,
                        Date = new DateTime(2018, month, 27),
                        Student_Id = 4,
                        Student_Name = "Javier Luna Hernández",
                        Students_In_Group = 25,
                        Items = new List<DailyMenuItem>
                        {
                            new DailyMenuItem
                            {
                                Id = 1,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 2,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            },
                            new DailyMenuItem
                            {
                                Id = 3,
                                Title = "Bollos con jamón",
                                Details = "Bollos con mostaza y mayonesa, jamón y queso amarillo."
                            },
                            new DailyMenuItem
                            {
                                Id = 4,
                                Title = "Fruta picada",
                                Details = "Manzana, melón y mango con un poco de yogurt natural."
                            }
                        }
                    }
                };

                callback?.Invoke(list, null);
            }
            else
            {
                var url = Remote.Shared.ApiDailyMenu.Replace("{parentId}", parentId.ToString()) + $"?year={year}&month={month}";
                var _ = Remote.Shared.RequestString("GET", url, null, null, (response, error) =>
                {
                    string message = null;
                    if (error != null)
                    {
                        message = error;
                    }
                    else
                    {
                        try
                        {
                            list = JsonConvert.DeserializeObject<List<DailyMenu>>(response);
                        }
                        catch (Exception)
                        {
                            message = response;
                        }
                    }
                    callback?.Invoke(list, message);
                });
            }
        }
    }
    */
}

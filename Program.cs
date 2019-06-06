using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sinema> Sinemas = new List<Sinema>
            {
            new Sinema { NameSinema = "Звездные воины", Year = 2000, Style = "Боевик", Producer = "Lucas Taddi", ID = 1 },
            new Sinema { NameSinema = "Иваново детство", Year = 2013, Style = "Драмма", Producer = "Тарковский", ID = 2 },
            new Sinema { NameSinema = "Такси 3", Year = 2015, Style = "Экшен", Producer = "Люк Бессон", ID = 3 },

            };



            //var Query = from Film in Sinemas group Film by Film.NameSinema into f select f;
            //foreach (var NameFilm in Query)
            //{
            //    Console.WriteLine("\nНазвание фильма: {0}", NameFilm.Key);
            //    foreach (var YearFilm in NameFilm)
            //    {
            //        Console.WriteLine("Год фильма:{0}", YearFilm.Year);

            //    }
            //}

           
            List<Theatr> Theatrs = new List<Theatr>
        {
            new Theatr{NameTheatr = "Горе от ума", Author = "Чехов", Style = "Комедия", NuberArtist = 25, ID = 1},
            new Theatr{NameTheatr = "Вишневый сад", Author = "Антон Павлович Чехов", Style = "Драма", NuberArtist = 33, ID = 2},
            new Theatr{NameTheatr = "Лебединое озеро", Author = "Чайковский", Style ="Балет", NuberArtist = 44, ID = 3},

        };

            List<Actors> actors = new List<Actors>
        {
           new Actors{Family = "Башаров", Name = "Игорь", Patronymic = "Игоревич", YearBirth = 1980, Role = "Порно", AccountNumber = 10, ID = 1},
           new Actors{Family = "Панин", Name = "Андрей", Patronymic = "Михайлович", YearBirth = 2000, Role = "Боевики", AccountNumber = 9, ID = 2},
           new Actors{Family = "Стычкин", Name = "Валера", Patronymic = "Игоревич", YearBirth = 1970, Role = "Все", AccountNumber = 8, ID = 3}

        };

            var Query = from Theat in Theatrs
                        join T_Actor in actors on Theat.ID equals T_Actor.ID  from Film  in  Sinemas join A_Film in actors on Film.ID equals A_Film.ID
                        select new
                        {
                           Theat.NameTheatr,
                           Theat.Author,
                           T_Actor.Family, 
                           Film.Producer,
                        };
            foreach(var Result in Query)
            {
                Console.WriteLine("\n{0} - {1} -{2}", Result.NameTheatr, Result.Author, Result.Producer);
                //foreach (var Rez in Query)
                //{
                //    Console.WriteLine("{0}", Rez.Family);
                //}
            }

            //var Query = from Film in Sinemas
            //            join T_Film in Theatrs on Film.ID equals T_Film.ID
            //            select new
            //            {
            //                T_Film.NameTheatr,
            //                T_Film.Style,
            //                Film.Producer,
            //               T_Film.Author
            //            };
            //  foreach(var Resilt_1 in Query)
            //{
            //    Console.WriteLine("\n{0} - {1}", Resilt_1.NameTheatr, Resilt_1.Style);
            //    foreach(var Rezult_2 in Query)
            //    {
            //        Console.WriteLine("{0} - {1}", Rezult_2.Producer, Rezult_2.Author);
            //    }
            //}
           // }

            //var Query = from act in actors group act by act.Role into ac select ac;
            //foreach (var Actor in Query)
            //{
            //    Console.WriteLine("\nРоли актера:{0}", Actor.Key);
            //    foreach (var YearAct in Actor)
            //    {
            //        Console.WriteLine("Год рождения актера:{0}", YearAct.YearBirth);
            //        foreach(var NameAct in Actor)
            //        {
            //            Console.WriteLine("{0} -{1}", NameAct.Name, NameAct.Family);
            // }

            // }

            // }


            Console.ReadLine();
           
        }
      
    }
}

       
      


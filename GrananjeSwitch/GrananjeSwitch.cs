using System;
using System.Globalization;

namespace Vsite.CSharp
{
    class GrananjeSwitch
    {
        static void Main(string[] args)
        {
            CultureInfo kultura = new CultureInfo("hr");
            string formatDatuma = kultura.DateTimeFormat.ShortDatePattern;
            Console.WriteLine("Unesite neki datum u obliku {0}", formatDatuma);
            string unos = Console.ReadLine();
            try
            {
                DateTime datum = DateTime.Parse(unos, kultura);
                DayOfWeek danUTjednu = datum.DayOfWeek;
                Console.WriteLine("Taj datum je {0}", ImeDana(danUTjednu));

                // ovo je jednostavniji način za ispis dana u tjednu!
                Console.WriteLine("Taj datum je {0}", datum.ToString("dddd", kultura));

                Console.WriteLine("Taj dan je {0}", RadniNeradni(danUTjednu));
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos datuma!");
            }
            Console.ReadKey();
        }

        static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                case DayOfWeek.Monday:
                    return "ponedjeljak";

                //Dopisati grane case za svaki dan u tjednu (DayOfWeek.Tuesday = Utorak, itd.)
                case DayOfWeek.Tuesday:
                    return "utorak";
                case DayOfWeek.Wednesday:
                    return "srijeda";
                case DayOfWeek.Thursday:
                    return "četvrtak";
                case DayOfWeek.Friday:
                    return "petak";
                case DayOfWeek.Saturday:
                    return "subota";
                case DayOfWeek.Sunday:
                    return "nedjelja";

                default:
                    return "Neispravan dan u tjednu";
            }
        }

        static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                //Dopisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case DayOfWeek.Monday:
                    return "radni dan";
                case DayOfWeek.Tuesday:
                    return "radni dan";
                case DayOfWeek.Wednesday:
                    return "radni dan";
                case DayOfWeek.Thursday:
                    return "radni dan";
                case DayOfWeek.Friday:
                    return "radni dan";
                case DayOfWeek.Saturday:
                    return "neradni dan";
                case DayOfWeek.Sunday:
                    return "neradni dan";

                default:
                    return "Neispravan dan u tjednu";
            }
        }
    }
}

using System;

namespace Vsite.CSharp
{
    class UvjetnoPridruživanje
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);

                // TODO: Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
                string odgovor = (broj % 2 == 0) ? "paran" : "neparan";

                Console.WriteLine("Broj {0} je {1}", broj, odgovor);

                // TODO: Napisati isto pridruživanje ali korištenjem uvjetnog grananja if
                string odgovor2 = "paran";
                if (broj % 2 == 0)
                    odgovor2 = "paran";
                else
                    odgovor2 = "neparan";

                Console.WriteLine("Broj {0} je {1}", broj, odgovor2);

            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos");
            }
            Console.ReadKey();
        }
    }
}

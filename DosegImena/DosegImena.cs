using System;

namespace Vsite.CSharp
{
    class DosegImena
    {
        static void Main(string[] args)
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();

            Console.ReadKey();
        }

        void IspišiAove()
        {
            string a = "Lokalna varijabla";

            //Ispisati vrijednosti lokalne varijable a
            Console.WriteLine(a);

            //Ispisati vrijednost člana klase a
            Console.WriteLine(this.a);

            {
                //Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                //string a = "varijabla unutar bloka";
                //Console.WriteLine(a);
            }
        }

        string a = "Član klase";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember Sanyi = new Ember();
            Ember Feri = new Ember();
            Ember Kati = new Ember();
            Ember Pista = new Ember();

            Sanyi.magassag = 180;
            Sanyi.hajszin = "Kék";
           string tokmas = Sanyi.adatKiiras();
           Console.WriteLine(tokmas);

            Kati.magassag = 160;
            Kati.hajszin = "Piros";
           Console.WriteLine( Kati.adatKiiras() );


            Console.ReadKey();
        }
    }

    class Ember {
       public int magassag;
       public string hajszin;

        public string adatKiiras(){

           string szoveg = "Magasság: " + magassag.ToString() + "\n" + "Hajszin: " + hajszin;
           return szoveg;


        }

       

    }
}

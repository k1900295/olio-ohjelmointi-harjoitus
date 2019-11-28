using System;
using System.IO;


namespace ConsoleApp1
{
    class Prosentti : InterfaceProsentti //Rajapinta InterfaceProsentti, mikä toteutetaan tässä luokassa.
    {
        //Kenttä
        private double _arvo; //Näkyvyys yksityinen.
       
        // Konstruktori:
        public Prosentti(double numero)
        {

            _arvo = numero;

        }

        // Rajapinnan toteutus:
        public double numero    //Ominaisuus.
        {
            get
            {
                return _arvo;
            }      

            set
            {
                _arvo = value;
            }
        }       
    }

    public class Osuus : Suoritus //Luokasta Suoritus summa1:n perintä eli viittaus olioon "summa1".
    {        
        double osamaara;
        
        public void Jako()
        {
            double.TryParse(summa1, out osamaara); //Muutetaan Muutetaan teksti "string arvo" desimaaliluvuksi  "double luku"  "string summa1" desimaaliluvuksi  "double osamaara" 

            InterfaceProsentti maksu = new Prosentti(osamaara); //Viitataan olioon "osamaara".

           // Avataan tiedost "summa.txt" ja luetaan sen rivit, jotta saadaan jajaksi prosenttiluvulle parametri summaLuku .
            string[] lueSumma = File.ReadAllLines("summat.txt");

            double luku = 0;
            double summaLuku = 0;

            foreach (string arvo in lueSumma) //Viitataan oliokokoelmaan "luesumma".
            {
                double.TryParse(arvo, out luku); //Muutetaan Muutetaan teksti "string arvo" desimaaliluvuksi  "double luku"  "string arvo" desimaaliluvuksi  "double luku" 
                summaLuku = summaLuku + luku;
            }
            
            double prosenttiluku = 100 * maksu.numero / summaLuku; //Lasketaan maksettavavan summan osuus tilin koko saldosta
            string prosenttiluku_1_desimaali = string.Format("{0:0.0}", prosenttiluku); //Pyöristää tulostettavan prosenttiluvun yhden desimaalin tarkkuuteen
            Console.Write("\n\n\t Maksetun summan osuus tilin saldosta  : " + prosenttiluku_1_desimaali + " %");

            string viimeisinMaksu = string.Format("{0:0.00}", maksu.numero); //Merkitään tulostukseen aina luvun pilkun jälkeen kaksi desimaalilukua
            Console.Write("  Viimeisin maksu:  " + viimeisinMaksu + "  euroa"); //Tulostetaan näytölle viimeisen maksun määrä
        }
    }
}

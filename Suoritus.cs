using System;


namespace ConsoleApp1
{
    public class Suoritus : Omistaja, IMaksaminen //Rajapinta IMaksaminen, mitä asuntojen vuokralaiset käyttävät.
    {                                             //Polymorfismia moniperinnässä käytetty rajaminnan avulla.

        public static string summa1;                //Käytetään tätä myös luokassa Maksutiedot 
        public static string vuokralaisen_nimi;     //Käytetään tätä myös luokassa Maksutiedot     

        void IMaksaminen.Maksa()
        {
            Console.Write("\n\n Kirjoita vuokralaisen etu- ja sukunimi!  ");
            vuokralaisen_nimi = Console.ReadLine();
            Console.Write("\n\n Kirjoita vuokralaisen maksama summa euroina! ");
            summa1 = Console.ReadLine();
            
            //Kirjoittaa tiedostoon olemassaolevien rivien perään uuden rivin
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("pankkitili.txt", true))
            
                file.WriteLine("Tilinomistaja " + nimi + ", \t vuokralainen " + vuokralaisen_nimi + ", " + asunnonnimi + ", " + "\t ja maksettu summa " + summa1 + " Euroa");
         
            
        }
    }
}

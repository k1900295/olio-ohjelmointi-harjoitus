using System;


namespace ConsoleApp1
{
    public class Maksaja : Suoritus, ITulosta //Tässä hyödynnetään eimerkin vuoksi polymorfismia rajapinnan avulla.
    {
        public void Tulosta() //Metodi rajapinnasta ITulosta.
        {
            Console.WriteLine("\t\t Maksaja:  " + vuokralaisen_nimi);
        }
    }

    public class Maksu : Suoritus, ITulosta //Tässä hyödynnetään eimerkin vuoksi polymorfismia rajapinnan avulla.
    {
        public void Tulosta() //Metodi rajapinnasta ITulosta.
        {
            Console.WriteLine("\t\t Maksettu summa:  " + summa1 + " euroa ");
        }
    }

    public class Maksunsaaja : Suoritus, ITulosta //Tässä hyödynnetään eimerkin vuoksi polymorfismia rajapinnan avulla.
    {
        public void Tulosta() //Metodi rajapinnasta ITulosta.
        {
            Console.WriteLine("\t\t Maksun saaja:  " + nimi);
        }
    }
}

using System;
using System.IO;


namespace ConsoleApp1
{
    public class KokonaisSumma : Omistaja
    {       
        //Metodi Summa() suorittaa maksujen tiedostossa "summat.txt" yhteenlaskemisen 
        public void Summa()
        {

            // Avataan tiedosto "summa.txt" ja luetaan sen rivit.
            string[] lueSumma = File.ReadAllLines("summat.txt");

            double luku = 0;
            double summaLuku = 0; 
            

            foreach (string arvo in lueSumma)
                {                
                double.TryParse(arvo, out luku); //Muutetaan merkkijono "string arvo" desimaaliluvuksi  "double luku" 
                summaLuku = summaLuku + luku;
                }
           
            string tulostettavasummaLuku = string.Format("{0:0.00}", summaLuku); //Merkitään tulostukseen aina luvun pilkun jälkeen kaksi desimaalilukua
            Console.WriteLine("\n\n \t Omistajan " +nimi + " tilin saldo:  " + tulostettavasummaLuku + " euroa \n");
            



        }
    }
 }

       
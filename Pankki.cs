using System;


namespace ConsoleApp1
{
   public class Pankki : Omistaja //Perintä luokasta Omistaja, missä muuttujat nimi ja "justnyt" määritelty.
    {
        
        public void Tilinomistaja() //Metodi tilinomistaja- tapahtuma-ajankohtien kirjaamiseksi tiedostoon "tilinomistajat.txt".
        {            
            Console.Write("\n\n Tilinomistajan nimi: \t" + nimi + "\t" + " Päiväys ja aika: \t" +justnyt);        
         
            //Kirjoittaa tiedostoon olemassaolevien rivien perään uuden rivin.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("tilinomistajat.txt", true))           
            {
                file.WriteLine("Tilinomistajan nimi: \t" +nimi + "\t " + "Tilitapahtuman päiväys ja aika: \t" + justnyt );               
            }
        }
        
    }
}


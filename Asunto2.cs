using System;


namespace ConsoleApp1
{
    public class Asunto2 : Omistaja // Muuttuja "nimi" nimi peritään luokasta Omistaja.
    {
        IMaksaminen suorita = new Suoritus();
        ISumma talleta = new TallennaSumma();
       
        public void Vuokralainen()
        {           
            Console.Write("\n\n Jos vuokralaisen maksu merkitään Asunto2:n omistajan  " + nimi + " tilille niin kirjoita kirjain K, muuten enter !  ");

            string ehto = Console.ReadLine();

            if (ehto == "K")
            {
                suorita.Maksa(); //Johtaa luokkaan Suoritus, missä on void IMaksaminen.Maksa()-metodin  
                                 //toteutus maksun kirjoittamiseksi ja kirjaamiseksi tiedostoon pankkitili.txt.
                                 //Interface IMaksaminen on tiedostossa Maksaminen.cs. 

                talleta.Tallenna();    //Johtaa luokkaan TallennaSumma, missä on void ISumma.Tallenna()-metodin  
                                       //toteutus maksun kirjoittamiseksi ja kirjaamiseksi tiedostoon summat.txt.
                                       //Interface ISumma on tiedostossa ISumma.cs.                              

            }
        }
    }
}


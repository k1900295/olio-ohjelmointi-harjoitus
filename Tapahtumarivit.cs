using System;


namespace ConsoleApp1
{                                    
    class Rivit : Maksutapahtumia   //Toteuttaa Abstract class Maksutapahtumia tiedostossa Maksutapahtumia.cs.
    {
        private int kappaletta;

        public Rivit(int kpl) // Konstruktori
        {
            kappaletta = kpl;
        }
        public override int Maksut()
        {
            return (kappaletta);
        }
    }

    public class Tapahtumarivit : Omistaja  //Luokasta Omistaja peritään muuttujan riviluku määrittelemä 
    {                                       //rivien eli maksutapahtumien määrä.

        public void Maksuja()               //Toteutetaan luokan Rivit ilmentymä
        {
            Rivit r = new Rivit(riviluku); //Tässä viitataan olioon "riviluku"
            int maksua = r.Maksut();
            if(maksua < 2)
             { Console.WriteLine("\n\n\t Maksutapahtumien määrä yhteensä:  1 kpl"); } // Muuten tulee maksutapahtumamääräksi negatiivinen luku.
            else
            Console.WriteLine("\n\n\t Maksutapahtumien määrä yhteensä: {0}", + (maksua-2) +" kpl"); //Tiedostossa on alussa rivejä, mitkä vähennetään.            
                                                                                                    //Siksi "maksua-2". 
            Console.WriteLine("\n Paina enter! \n");
            Console.ReadKey();                                                                             
        }
    }
}

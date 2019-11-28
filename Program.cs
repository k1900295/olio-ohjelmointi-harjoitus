using System;


// Tämä on asunnon- ja tilinomistajan vuokranmaksujen kirjaamiseen ja ilmoittamiseen käytettävä sovellus.

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Seuraava konsolin teksti näytetään vihreänä
            Console.Write("\n Tämä on asunnon- ja tilinomistajan vuokranmaksujen kirjaamiseen ja ilmoittamiseen käytettävä sovellus. \n ");
            Console.Write("\n Laatinut Tapani Tarri kurssin Olio-Ohjelmointi (TETI19) lopputyönä. \n");
            Console.ForegroundColor = ConsoleColor.White; // Konsolin teksti muutetaan valkoiseksi

            Omistaja omistaja = new Omistaja();

            omistaja.Tuotekuvaus(); // Luokassa Omistaja metodi Tuotekuvaus() toteuttaa dokumentin "tuotespeksi.docx" avaamisen.


            omistaja.Asuntolista(); // Luokassa Omistaja metodi Asuntolista(), missä "Dictionary" asunnoista.

            omistaja.Asukaslista(); // Luokassa Omistaja metodi Asukaslista(), missä "Dictionary" asukkaiden listaamista varten dynaamisesti olioita lisäten.
                                    //Lisätään myös tässä metodissa Asukaslista()listaan dynaamisesti uusia olioita (asukkaita).

            omistaja.Nimi(); // Luokassa Omistaja omistajan nimen kirjoittamiselle metodi Nimi().

            omistaja.Asunnot(); // Luokassa Omistaja asunnonvalinnan metodi Asunnot().             

            omistaja.Katso(); // Luokassa Omistaja metodi Katso() voidaan valita tilitapahtumien tulostus näytölle.

            Console.ForegroundColor = ConsoleColor.White; // Konsolin teksti muutetaan valkoiseksi.

            omistaja.Rahalaitos(); // Luokassa Omistaja metodi Rahalaitos() johtaa luokassa Pankki.cs tiedostoon kirjoittamisen metodiin.

            Console.ForegroundColor = ConsoleColor.Red; // Konsolin teksti muutetaan punaiseksi.

            omistaja.Ilmoita(); // Luokassa Omistaja veroilmoitukseen ilmoittamisen metodi Ilmoita().

            Console.ForegroundColor = ConsoleColor.White; // Konsolin teksti muutetaan valkoiseksi.

            omistaja.Postitus(); // Luokassa Omistaja metodi Postitus() johtaa luokassa Email sähköpostilla lähettämisen metodiin Postittaa().   

            omistaja.Saldo(); // Luokassa Omistaja metodi Saldo() johtaa luokassa KokonaisSumma maksujen tiedostossa "summat.txt" yhteenlaskemiseen.  

            omistaja.Prosenttiosuus(); // Luokassa Omistaja metodi Prosenttiosuus().

            omistaja.Tapahtumia(); // Luokassa Omistaja metodi Tapahtumia().

            omistaja.Viimeisinmaksu(); // Luokassa Omistaja metodi Viimeisinmaksu(), jotta tulostetaan asunto, minkä asukkaalta viimeisin maksusuoritus.                                      

            omistaja.Transaktio(); // Luokassa Omistaja metodi Transaktio() johtaa luokkiin, missä on hyödynnetty polymorfismia rajapinnan avulla.

            Console.Write("\n\n Paina enter-näppäintä lopettaaksesi istunto!");
            
            Console.Read();
        }        
    }
}

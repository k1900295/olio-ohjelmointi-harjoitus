using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;



namespace ConsoleApp1
{
    public class Omistaja
    {

        public static string nimi; //Näkyvyys julkinen.
        public static DateTime justnyt; //Näkyvyys julkinen.
        public static string asunnonnimi; //Näkyvyys julkinen.
        public static int riviluku; //Näkyvyys julkinen.
        private string puuttuunimi; //Näkyvyys ei ole julkinen eli on yksityinen.


        public void Tuotekuvaus() //Vuokranmaksujen kirjaamiseen ja ilmoittamiseen käytettävän sovelluksen ohjelmistokuvaus avaus toteutetaan tässä metodissa.
        {
            Console.Write("\n\n Jos haluat lukea tämän ohjelmiston tuotekuvauksen kirjoita kirjain K, muuten enter !  ");

            string kirjoita = Console.ReadLine();
            if (kirjoita == "K")
            {
                System.Diagnostics.Process.Start("tuotespeksi.docx"); //Avaa dokumentin "tuotespeksi.docx", missä ohjelmiston kuvaus.
            }
        }

        public Omistaja()
        { 
            puuttuunimi = "Nimi antamatta";  //Konstruktori, missä parametrille nimi annetaan arvoksi merkkijono "Nimi antamatta" 
                                             //parametrin puuttuunimi arvosta.
        }

        public void Asuntolista() //Listataan näyttölle oheisessa Dictionary:ssä määritelty teksti (oliokokoelma).
        {
            Dictionary<int, string> asuntodict = new Dictionary<int, string>()
                 {
                        {1,"Ohessa hallittavat asunnot:"},
                        {2,"Asunto1"},
                        {3,"Asunto2"},
                        {4,"Toistaiseksi ei enempää asuntoja hallittavana!"}
                };

            Console.WriteLine("\n");
           
            int i = 1;
            foreach (KeyValuePair<int, string> item in asuntodict)
            {
                
                Console.WriteLine("\t" +asuntodict[i]); //Tulostaa tekstit lainausmerkkien välissä.
                i = i + 1;
            }

        }

        public void Asukaslista() //Kirjoitetaan muistiin tiedostoon "asukkaat.txt" ja listataan näytölle oheisessa Dictionary:ssä määritellyt asukkaat.
        {                         //Lisätään myös tässä metodissa listaan dynaamisesti uusia olioita (asukkaita).

            Dictionary<int, string> asukasdict = new Dictionary<int, string>();
            int j = 1;
            string vastaus = "K";


            Console.Write("\n\n Halutessasi kirjoittaa asukkaan nimen muistiin niin seuraavaksi kirjoita kirjain K, muuten enter !  ");

            string kirjoita = Console.ReadLine();
            if (kirjoita == "K")
            {
                while (vastaus == "K")
                {
                    Console.Write("\n\n Kirjoita asukkaan nimi!  ");
                    string asukas = Console.ReadLine();
                    asukasdict.Add(j, asukas);
                    j = j + 1;
                    Console.Write("\n\n Halutessasi kirjoittaa seuraavan asukkaan nimen niin seuraavaksi kirjoita kirjain K, muuten enter !  ");
                    vastaus = Console.ReadLine();
                }
            }

            if (kirjoita == "K")
            {
                Console.WriteLine("\n Edellä kirjoittamasi asukkaiden nimet: \n");
            }

            int i = 1;

            foreach (KeyValuePair<int, string> item in asukasdict)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("asukkaat.txt", true))
                    file.WriteLine(asukasdict[i]); //Kirjoittaa muistiin tiedostoon "asukkaat.txt" edellä tämän metodin Dictionary:n listaukseen määritellyt asukkaat.

                Console.WriteLine("\t" + asukasdict[i]); //Tulostaa näytölle edellä tämän metodin Dictionary:n listaukseen määritellyt asukkaat.

                i = i + 1;
            }

            i = 1;

            IList<string> stringLista = new List<string>(); //Lisää listaan dynaamisesti uusia olioita (asukkaita), mitä edellä asukasdict[i]:lle kirjoitettiin.

            foreach (KeyValuePair<int, string> item in asukasdict) // Viittaus oliokokoelmaan.
            {

                stringLista.Add(asukasdict[i]);
                i = i + 1;
            }
            Console.WriteLine("\n Edellä kirjoittamasi asukkaiden nimet UUDELLEEN: \n");

            foreach (var asukasnimet in stringLista) // Viittaus oliokokoelmaan.
                Console.WriteLine("\t" + asukasnimet);


            //Seuraavassa lasketaan ja tulostetaan näyttöön listan "stringLista" rivimäärä eli kirjoitettujen asukkaiden nimien määrä.
            List<string> stringListaL = new List<string>();
            stringListaL.AddRange(stringLista);
            Console.WriteLine("\n Kirjoitit " + stringListaL.Count + " asukkaan nimet!");

            Console.Write("\n\n Jos haluat lisätä vielä uuden asukkaan nimen listan alkuun niin seuraavaksi kirjoita kirjain K, muuten enter !  ");

            string kirjoitetaan = Console.ReadLine();

            if (kirjoitetaan == "K")
            {
                Console.Write("\n Kirjoita uusi asukkaan nimi listan alkuun!  ");
                string uusinimi = Console.ReadLine();
                stringLista.Insert(0, uusinimi);// Lisätään uusi nimi listan alkuun elirivin 0 jälkeen.

                Console.WriteLine("\n Nimet uudestaan ja lisätty nimi ensimmäisenä listassa: \n");
                foreach (var asukasnimet in stringLista) // Viittaus oliokokoelmaan.
                    Console.WriteLine("\t" + asukasnimet);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("asukkaat.txt", true))
                    file.WriteLine("\n Ohessa asukkaiden nimet uudestaan ja lisätty uusi nimi on mukana:"); //Kirjoittaa muistiin tiedostoon "asukkaat.txt" tuon ilmoituksen.

                foreach (var asukasnimet in stringLista) // Viittaus oliokokoelmaan.
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter("asukkaat.txt", true))
                        file.WriteLine(asukasnimet); //Kirjoittaa muistiin tiedostoon "asukkaat.txt" myös lisätyn uuden nimen.
                }
            }
        }

        public virtual void Nimi()  //"virtual" määrittelee metodin ylikirjoitettavaksi.
        {
            Console.Write("\n\n Halutessasi kirjoittaa omistajan nimen niin seuraavaksi kirjoita kirjain K, muuten enter !  ");

            string kirjoitan = Console.ReadLine();
            if (kirjoitan == "K")
            {
                Console.Write("\n\n Kirjoita omistajan etu- ja sukunimi! ");
                nimi = Console.ReadLine();                  
            }
            else //if (kirjoitan != "K")
            {
                nimi = puuttuunimi; // Edellä annettu parametrin puuttuunimi arvoksi"Nimi antamatta", mikä arvo tässä annetaan parametrille nimi.
                Console.Write("\n\n" + nimi + ", joten sovellus suljetaan!  Paina seuraavaksi enter! \n ");
                Console.Read();

                System.Environment.Exit(1); //Poistutaan sovelluksesta, koska omistajan nimeä ei annettu.
            }

            Console.Write("\n\n Jos haluat vaihtaa omistajan etu- ja sukunimen niin kirjoita kirjain K, muuten enter !  ");

            string nimenvaihto = Console.ReadLine();

            if (nimenvaihto == "K")
            {
                Muunimi muunimi = new Muunimi(); // Luokassa Muunimi() voidaan edellä kirjoitettu nimi muuttaa eli ylikirjoittaa (override).
                muunimi.Nimi();
            }

            justnyt = DateTime.Now; // Päiväys ja kellonaika tiedostoon "tilinomistat.txt" kirjattavaksi luokassa Pankki.cs.
        }
        
               
        public void Ilmoita() //Kirjoitetaan vuokranmaksutapahtumat veroilmoitukseen. 
        {                  
            Console.Write("\n\n Jos kopioit pannkitilitiedot veroilmoitukseen kirjoita kirjain K, muuten enter !  ");

            string ilmoitan = Console.ReadLine();

            if (ilmoitan == "K")
            {
                Veroilmoitus laadi = new Veroilmoitus(); //Tässä luodaan uusi olio luokkaan Veroilmoitus.
                laadi.Veroilmoitukseen();
            }           
        }
        
        public void Asunnot() // Valitaan joko luokan Asunto1.cs tai luokan Asunto2.cs metodi Vuokralainen.
        {

            //Jos valitaan asunto luokasta Asunto1.cs tai luokasta Asunto2.cs
            Console.Write("\n\n Jos kirjaat Asunto1:n vuokralaisen suorittaman maksun kirjoita numero 1, ");
            Console.Write("\n Jos kirjaat Asunto2:n vuokralaisen suorittaman maksun kirjoita numero 2, ");
            Console.Write("\n muuten paina enter ");
            string ehto1 = Console.ReadLine();

            if (ehto1 == "1")   //Jos valitaan asunto luokasta Asunto1.cs.
            {
                asunnonnimi = "Asunto1";
                Asunto1 asunto1 = new Asunto1();
                asunto1.Vuokralainen();
            }

            else if (ehto1 == "2")  //Jos valitaan asunto luokasta Asunto2.cs.
            {
                asunnonnimi = "Asunto2";
                Asunto2 asunto2 = new Asunto2();
                asunto2.Vuokralainen();
            }
        }
                
        public void Katso() //luokassa Omistaja tilitietojen katsomisen metodi Katso().
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Konsolin teksti muutetaan keltaiseksi.

            // Lukee luokassa Lue rivit tiedostosta pankkitili.txt.
            Lue lue = new Lue();

            //Serialize: tiedostosta pankkitili.txt luetut rivit tallennetaan tavuvirtana (byte stream) tiedostoon tiedosto.txt.
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("tiedosto.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                binaryFormatter.Serialize(fileStream, lue);
            }
            catch
            {
                Console.WriteLine("Virhe tallennuksessa!");
            }
            finally
            {
                fileStream.Close();
            }

            ///Deserialize: tiedostoon tiedosto.txt tallennettu tavuvirta (byte stream) luetaan tekstiriveiksi ja tulostetaan konsolin näyttöllä.
            try
            {
                fileStream = new FileStream("tiedosto.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                lue = (Lue)binaryFormatter.Deserialize(fileStream);

                riviluku = 0; //Alustetaan arvo.

                foreach (string rivi in lue.rivit)
                {
                    Console.WriteLine("\t\t" + rivi);

                    riviluku = riviluku + 1; // Lasketaan tiedoston "tiedosto.txt" rivien määrä.
                }

                if (riviluku < 2)
                    { Console.WriteLine("\n TIEDOT LADATTU NÄYTÖLLE JA LADATTUJA RIVEJÄ ON  1 kpl !"); } // Muuten tulee rivimääräksi negatiivinen luku.
                else
                    Console.WriteLine("\n TIEDOT LADATTU NÄYTÖLLE JA LADATTUJA RIVEJÄ ON " +(riviluku-2) +" kpl !" ); //Tiedostossa, mistä rivit parametrille "riluku"
                                                                                                                     //lasketaan, alussa on rivejä, mitä vähennetään
                                                                                                                    //laskettavista riveistä, siksi "riviluku-3".
            }
            catch
            {
                Console.WriteLine("Virhe näytölle tulostamisessa!");
            }
            finally
            {
                fileStream.Close();
            }
        }        
    

        public void Rahalaitos() //Luokassa Pankki() metodi tilinomistajien nimien sekä tapahtuma-ajankohtien kirjaamiseksi tiedostoon "tilinomistajat.txt".
        {
            Pankki pankki = new Pankki();

            pankki.Tilinomistaja(); // Luokassa Pankki.cs.
        }

        
        public void Postitus() //Luokkaan Email, missä metodi Postittaa() sähköpostin lähettämiseksi.
        {
            Console.Write("\n\n Jos sähköpostitat tilitapahtumista tietoa pankkiin niin kirjoita K, muuten enter !  ");

            string ehto2 = Console.ReadLine();

            if (ehto2 == "K")
            {
                Console.Write("\n Lähetyksen onnistuminen edellyttää, että olet luokassa Email määritellyt toimivat lähettäjän sähköpostiosoitteen, \n" +
                    " salasanan ja sähköpostipalvelimen sekä toimivan vastaanottajan  sähköpostiosoitteen. \n ");

                Email postita = new Email();

                postita.Postittaa(); // Luokassa Email.cs.
            }             
         } 
        
        public void Saldo() //Metodi Summa() luokassa KokonaisSumma suorittaa maksujen tiedostossa "summat.txt" yhteen laskemisen.  
        {
            KokonaisSumma ilmoita = new KokonaisSumma();
            ilmoita.Summa();
        }

        public void Prosenttiosuus()    //Metodi Jako() luokassa Osuus suorittaa maksetun osuuden määrittelyn tilin saldosta 
        {                               //ja tulostaa viimeisimmän maksetun summan.

            Osuus suorita = new Osuus(); // Luokka osuus tiedostossa Prosentti.cs
            suorita.Jako();
           
        }

        public void Tapahtumia()    //Metodi Maksuja() luokassa Tapahtumarivit tiedostossa Maksutiedot.cs tulostaa maksutapahtumien määrän. 
        {                            
            Tapahtumarivit suorita = new Tapahtumarivit();  
            suorita.Maksuja();
        }

        public void Viimeisinmaksu() //Tiedostossa Asunnonnumero.cs metodi Asuntonimi() luokassa  Viimeinenmaksu tulostaa asunnon, 
                                     //minkä asukas teki viimeksi maksusuorituksen.
        {
            Viimeinenmaksu tulosta = new Viimeinenmaksu();
            tulosta.Asuntonimi();
        }

        public void Transaktio()    //Tämä vielä esimerkin vuoksi hyödyntäen polymorfismia rajapinnan avuulla seuraavissa luokissa, 
        {                           //mitkä ovat tiedostossa "Maksutiedot.cs".

            Console.WriteLine("\t Viimeisimmän maksusuorituksen tiedot:");

            Maksaja maksaja = new Maksaja();
            maksaja.Tulosta();

            Maksu maksu = new Maksu();
            maksu.Tulosta();

            Maksunsaaja maksunsaaja = new Maksunsaaja();
            maksunsaaja.Tulosta();
        }
    }
}

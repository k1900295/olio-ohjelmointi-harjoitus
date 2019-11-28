using System;


namespace ConsoleApp1
{
    class Asunnonnumero : IAsuntonumero   //Rajapinta IAsuntonumero, mikä toteutetaan tässä luokassa.                                         
    {
        //Kenttä
        private string _asunto; //Näkyvyys yksityinen.

        // Konstruktori:
        public Asunnonnumero(string asuntoIF)
        {
            _asunto = asuntoIF;
        }

        // Rajapinnan toteutus:
        public string asuntoIF
        {
            get
            {
                return _asunto;
            }

            set
            {
                _asunto = value;
            }
        }
    }

    public class Viimeinenmaksu : Omistaja //Parametri "asunnonnimi" peritään luokasta Omistaja
    {    
        public void Asuntonimi() //Määritellään ohessa parametri "asuntonimi" rajapinnan IAsuntonumero tyypiksi.
        {
            string asuntotyyppi = asunnonnimi;
            IAsuntonumero asuntonimi = new Asunnonnumero(asuntotyyppi);

            Console.Write("\n\n\t Huomaathan, että kyse on asunnon  " + asuntonimi.asuntoIF + " viimeisimmästä maksusuorituksesta! \n");
        }

        
    }
}


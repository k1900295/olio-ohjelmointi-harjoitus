using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TallennaSumma : Suoritus, ISumma //Rajapinta ISumma, mitä asuntojen vuokralaiset käyttävät. 
    {                                      //Polymorfismia moniperinnässä käytetty rajaminnan avulla.

        void ISumma.Tallenna()
        {
            //Kirjoittaa tiedostoon olemassaolevien rivien perään uuden rivin

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("summat.txt", true))

                file.WriteLine(summa1);
        } 
    }
}

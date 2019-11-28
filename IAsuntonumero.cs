using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Tämä toimii rajapintana, joka toteutetaan luokassa Asuntonumero ja 
    // on luokassa Viimeinenmaksu metodin Asuntonimi() parametrin "asuntonimi" tyyppimäärittely.
    interface IAsuntonumero
    {       
            // Ptoperty eli ominaisuus "asuntoIF" on tyyppiä "string"
            string asuntoIF
            {
                get;
                set;
            }        
    }
}





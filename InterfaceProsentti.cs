using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Tämä toimii rajapintana, joka toteutetaan luokassa Prosentti ja 
    // on luokassa Osuus metodin Jako() parametrin "maksu" tyyppimäärittely.
    interface InterfaceProsentti
    {
        // Ptoperty eli ominaisuus "numero" on tyyppiä "double"
        double numero
        {
            get;
            set;
        }

    }
}
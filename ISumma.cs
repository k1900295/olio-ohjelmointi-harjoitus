using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ISumma        //Tämä toimii rajapintana, jotta asunnon ja tilin omistaja TallennaSumma-luokassa
                            // metodin "void ISumma.Tallenna()" mukaan voi kirjata maksun tiedostoon summat.txt.
    {
        void Tallenna();

    }
}

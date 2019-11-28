using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMaksaminen  //Tämä toimii rajapintana, jotta asunnon ja tilin omistaja Suoritus-luokassa
                          // metodin "void IMaksaminen.Maksa()" mukaan voi kirjata maksun tiedostoon pankkitili.txt.
    {
        void Maksa();
    }
}


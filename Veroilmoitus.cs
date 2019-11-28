using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
   public class Veroilmoitus //Kopioi olemassa olevan "pankkitili.txt" tiedot veroilmoitukseen "veroilmoitus.txt".
    {
       public void Veroilmoitukseen()
        {
            string tiedosto1 = "pankkitili.txt";
            string tiedosto2 = "veroilmoitus.txt";
            
            // Path-luokassa käsitellää tiedosto- ja hakemistopolut.
            string sourceFile = System.IO.Path.Combine(tiedosto1);
            string destFile = System.IO.Path.Combine(tiedosto2);

            System.IO.File.Copy(sourceFile, destFile, true); //Kopiointi tiedostosta toiseen tiedostoon
        }
    }
}
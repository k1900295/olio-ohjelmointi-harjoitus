using System;


namespace ConsoleApp1
{

//Luetaan sarjaistamistakin (serialize) varten tierdostosta pankkitili.txt rivit

    [Serializable]  //Tiedot sarjaistettavissa
    public class Lue
    {
        public string[] rivit = System.IO.File.ReadAllLines("pankkitili.txt");
    }
}
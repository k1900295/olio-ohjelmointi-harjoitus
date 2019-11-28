using System;


namespace ConsoleApp1
{
    public class Muunimi : Omistaja //Perintä luokasta Omistaja.cs, missä muuttuja nimi
    {
        public override void Nimi() //"override" jotta ylikirjoitetaan luokassa Omistaja metodissa public virtual void Nimi() kirjoitettu nimi.
        {
            Console.Write("\n Vaihda omistajan aikaisemmin kirjattu nimi " + nimi  +" !  ");
            nimi = Console.ReadLine();
        }
    }
}

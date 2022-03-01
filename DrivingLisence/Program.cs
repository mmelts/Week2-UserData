using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taotleda"


            Console.WriteLine("Palun sisesta oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2022 - YearOfBirth;

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana juhilubadeks");
            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor juhilubadeks");
            }
            else
            {
                Console.WriteLine("Palju õnne, võid juhilube taotleda");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}

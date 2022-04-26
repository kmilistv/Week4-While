using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpunumber = rnd.Next(1, 11);
            int i = 0;



            while (i < 3)
            {

                Console.WriteLine("Sisesta number:");
                int myRandomNumber = Convert.ToInt32(Console.ReadLine());

                if (myRandomNumber == cpunumber)
                {
                    Console.WriteLine("Õige number. Olete mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number. Proovi uuesti");
                    Console.WriteLine($"Oled vale numbri {i} korda sisestanud.");

                }
            }

            Console.WriteLine("Head päeva!");
        }
    }
}

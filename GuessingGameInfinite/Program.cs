using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpunumber = rnd.Next(1, 11);
            bool loopActive = true;


            while (loopActive)
            {
               
                Console.WriteLine("Sisesta number:");
                int myRandomNumber = Convert.ToInt32(Console.ReadLine());
                

                if (myRandomNumber == cpunumber)
                {
                    Console.WriteLine("Õige number. Olete mängu võitnud!");
                    loopActive = false;
                }
                else
                {

                    Console.WriteLine("Vale number. Proovi uuesti.");
                }
            }

                Console.WriteLine("Head päeva!");



            
        }
    }
}

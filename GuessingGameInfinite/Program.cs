using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvuma;
            //kui kasutaja suutis seda numbrit ära arvuta, siis ta on mängu võitnud;
            //katsete arv piiramatu.
            //*programm genereerib juhuslikku nimbrit ühe korda;

            bool loopActive = true;
            int i = 0;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            
            while (loopActive)
            {
                Console.WriteLine("Sisesta oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    loopActive = false;
                }
                else
                {
                    i++; // i = i + 1;
                    Console.WriteLine("Vale number. Proovi uuesti!");
                    Console.WriteLine($"Oled vale numbrit {i} korda sisestanud.");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}

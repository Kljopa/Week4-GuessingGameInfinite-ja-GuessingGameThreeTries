using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvuma;
            //kui kasutaja suutis seda numbrit ära arvuta, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata;
            //siis mängu võidab arvuti;
            //*programm genereerib juhuslikku nimbrit ühe korda;


            int i = 0;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);


            while (i < 3)
            {
                i++;
                Console.WriteLine("Sisesta oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    break;
                }
                if (i == 3)
                {
                    Console.WriteLine("Sa kaotasid!");
                }
                else
                {
                    Console.WriteLine("Vale number. Proovi uuesti!");
                    Console.WriteLine($"On jäänud {3 - i} katset.");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}

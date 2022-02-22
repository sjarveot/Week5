using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat - arvuti ja kasutaja
            //mõlemad mängjad viskavad täringuid
            //program kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on võitja
            //täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            int userScore = 0;
            int CPUScore = 0;
            for (int i = 0; i < 3; i++)
            {

                int CPURandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas: {CPURandom}");
                Console.WriteLine($"Kasutaja viskas: {userRandom}");
                if (CPURandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud.");
                    userScore++;
                }
                else if (CPURandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    CPUScore++;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }
            if (CPUScore < userScore)
            {
                Console.WriteLine($"Võitsid punktidega {userScore} : {CPUScore}");
            }
            else if (CPUScore > userScore)
            {
                Console.WriteLine($"Arvuti võitis kokkuvõttes {CPUScore} : {userScore}");
            }
            else
            {
                Console.WriteLine(" Jäite viiki!");
            }

        }
    }
}

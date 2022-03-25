using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kusib kasutajal sisestada eesnime
            //programm kusib kasutajal sisestada numbrid 1-3
            //kui kasutaja sisestab 1 siis kuvatakse eesnime tagurpidi
            //kui kasutaja valib 2 siis kuvatakse kasutaja eesnime esimest tahte
            //kui kasutaja valib 3 siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta nuber 1-3");
            string userNumber = Console.ReadLine();

            switch (userNumber)
            {
                case "1":
                    UserNameReverse(userName);
                    break;
                case "2":
                    FirstLetter(userName);
                    break;
                case "3":
                    UsernameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;
            }

            

        }

        public static void UserNameReverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene taht on {userInput[0]}");
        }

        public static void UsernameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk.");
        }
    }
}

using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("About Me Quiz");
            Console.WriteLine(HomeState());
            Console.WriteLine(SeattleHome());
            Console.WriteLine(PetsOwned());
            Console.WriteLine(Birthmark());
            Console.WriteLine(FavoriteSport());
        }

        static string HomeState()
        {
            Console.WriteLine("From which state did Anthony move to Washington?");

            string q1response = Console.ReadLine();

            if (q1response.ToLower() == "mississippi" || q1response.ToLower() == "ms")
            {
                return "Correct";
            }
            else
            {
                return "Wrong! I am from Mississippi";
            }
        }
        static string SeattleHome()
        {
            Console.WriteLine("Does Anthony live in the city limits of Seattle?");
            string q2response = Console.ReadLine();

            if (q2response.ToLower() == "yes" || q2response.ToLower() == "y")
            {
                return "Correct! I just moved to a new apartment in South Lake Union";
            }
            else
            {
                return "Wrong! I live in South Lake Union";
            }
        }
        static string PetsOwned()
        {
            Console.WriteLine("How many pets does Anthony own?");
            string q3response = Console.ReadLine();

            if (q3response.ToLower() == "0" || q3response.ToLower() == "none" || q3response.ToLower() == "zero")
            {
                return "Correct! I do not own any pets but my roommate has an 11 week old corgi puppy!";
            }
            else
            {
                return "Nope! I do not own any pets but my roommate has an 11 week old corgi puppy";
            }
        }
        static string Birthmark()
        {
            Console.WriteLine("Where is Anthony's birthmark? Arm, Leg, Eyeball, Tongue, or Big Toe");
            string q4response = Console.ReadLine();

            if (q4response.ToLower() == "eyeball" || q4response.ToLower() == "eye")
            {
                return "Correct! I have a birthmark in the iris of my left eye. (partial heterochromia)";
            }
            else
            {
                return $"Hey now! What is wrong with my {q4response}? I have partial heterochromia meaning my eyeball is two different colors";
            }
        }
        static string FavoriteSport()
        {
            Console.WriteLine("What is Anthony's favorite sport to watch on TV? UFC, Basketball, Football, or Golf");
            string q5response = Console.ReadLine();

            if (q5response.ToLower() == "football")
            {
                return "Correct!";
            }
            else
            {
                return "wrong!";
            }
        }
    }
}











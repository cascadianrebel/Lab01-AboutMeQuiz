using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction line
            Console.WriteLine("About Me Quiz");

            while (PlayGame())
            {
                Console.Clear();
            // Question 1 displays
            Console.WriteLine(HomeState());
            // Question 2 displays
            Console.WriteLine(SeattleHome());
            // Question 3 displays
            Console.WriteLine(PetsOwned());
            // Question 4 displays
            Console.WriteLine(Birthmark());
            // Question 5 displays
            Console.WriteLine(FavoriteSport());
            // Calculates score
            Console.WriteLine($"Your Score is {FindScore()}");

            Console.WriteLine($"Let's play again!");
            
            }

        }
        /// <summary>
        /// asks user if they want to play 
        /// </summary>
        /// <returns>true or false</returns>
        public static bool PlayGame()
        {
            Console.WriteLine($"Do you want to play the game?");
            string StartGame = Console.ReadLine();
            if (StartGame.ToLower() == "yes")
            {
                return true;
            }
            if (StartGame.ToLower() == "no")
            {
                Console.WriteLine("ok, fine. bye, felicia");
                return false;
            }
            else
            {
                Console.WriteLine("Let's try that again. Please enter yes or no");
                return PlayGame();
            }

        }

        public static int ScoreCounter = 0;

        static string HomeState()
        {
            //1st question
            Console.WriteLine("From which state did Anthony move to Washington?");
            //creates variable to hold question response
            string q1response = Console.ReadLine();
            //determines if the response is correct
            if (q1response.ToLower() == "mississippi" || q1response.ToLower() == "ms")
            {
                ScoreCounter += 1;
                return "Correct";
            }
            //for all incorrect answers the following will be returned
            else
            {
                return $"Wrong! Do I act like someone from {q1response}? I am from Mississippi";
            }
        }
        //same process for the next 4 questions
        static string SeattleHome()
        {
            Console.WriteLine("Does Anthony live in the city limits of Seattle?");
            string q2response = Console.ReadLine();

            if (q2response.ToLower() == "yes" || q2response.ToLower() == "y")
            {
                ScoreCounter += 1;
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
                ScoreCounter += 1;
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
                ScoreCounter += 1;
                return "Correct! I have a birthmark in the iris of my left eye. (partial heterochromia)";
            }
            else
            {
                //using the user's response within the incorrect reply
                return $"Hey now! What is wrong with my {q4response}? I have partial heterochromia meaning my eyeball is two different colors";
            }
        }
        static string FavoriteSport()
        {
            Console.WriteLine("What is Anthony's favorite sport to watch on TV? UFC, Basketball, Football, or Golf");
            string q5response = Console.ReadLine();

            if (q5response.ToLower() == "football")
            {
                ScoreCounter += 1;
                return "Damn, right! I love me some good ole football. I follow college football religiously";
            }
            else
            {
                return $"Meh. I don't really enjoy watching {q5response} on TV.";
            }
        }

        //returns a number
        static int FindScore()
        {
            return ScoreCounter;
        }
    }
}











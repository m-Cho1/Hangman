namespace Hangman
{
    internal class Program
    {
        static string userName;
        static int numberOfGuesses;
        static string correctWord = "hangman";
        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine( "Starting the game...");
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("Enter your name:");
            string input = Console.ReadLine();

            if (input.Length >= 2) 
            {
                // The user entered a valid name
                userName = input;
            }
            else
            {
                AskForUsersName();
            }
                

        }
        private static void PlayGame()
        {
            Console.WriteLine("Playing the game...");
            DisplayMaskedWord();
            AskForLetter();
        }

        static void DisplayMaskedWord()
        {
            Console.WriteLine("Displaying masked word...");
            foreach (char c in correctWord)
            {
                Console.Write('-');
            }
            Console.WriteLine();

        }
        
        static void AskForLetter()
        {
            string input;
            do
            {
                Console.WriteLine("Enter a letter:");
                input = Console.ReadLine();
            } while (input.Length != 1);
            
            numberOfGuesses++;
        }
        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {userName}!");
            Console.WriteLine($"Guesses: {numberOfGuesses}");
        }
    }
}
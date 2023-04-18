namespace Hangman
{
    internal class Program
    {
        static string userName;
        static int numberOfGuesses;
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
            userName = Console.ReadLine();

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
        }
        
        static void AskForLetter()
        {
            Console.WriteLine("Asking for letter...");
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
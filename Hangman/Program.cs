namespace Hangman
{
    internal class Program
    {
        static string correctWord = "hangman";
        static char[] letters;
        // the hyphen in the letters array will be replaced with the correct word from user

        static Player player;
        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine( "Starting the game...");

            // putting hyphens according to the correctWord length:
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
            {
                letters[i] = '-';
            }
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("Enter your name:");
            string input = Console.ReadLine();

            if (input.Length >= 2) 
            {
                // The user entered a valid name
                player = new Player(input);
            }
            else
            {
                AskForUsersName();
            }
                

        }
        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
            } while (correctWord != new string(letters));

            Console.Clear();
            
        }

        private static void CheckLetter(char guessedLetter)
            // checking if the letter matches from correctWord letters:
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                {
                    letters[i] = guessedLetter;
                    player.score++;
                }
                    
            }
        }

        static void DisplayMaskedWord()
        {
            // displaying the masked word:
            foreach (char c in letters)
            {
                Console.Write(c);
            }
            Console.WriteLine();

        }
        
        static char AskForLetter()
        {
            // ask for a letter to user:
            string input;
            do
            {
                Console.WriteLine("Enter a letter:");
                input = Console.ReadLine();
            } while (input.Length != 1);



            // return the character from user input:
            var letter = input[0];

            // if guessedLetter is not in the letter(collection),
            // then add the gussedLetter to letter:
            if (!player.guessedLetters.Contains(letter))
            {
                player.guessedLetters.Add(letter);
            }

            return letter;
        }
        private static void EndGame()
        {
            Console.WriteLine($"The correct word: {correctWord }");
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {player.userName}!");
            Console.WriteLine($"Guesses: {player.guessedLetters.Count} Score: {player.score}");
        }
    }
}
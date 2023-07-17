﻿namespace Hangman
{
    internal class Program
    {
        static string userName;
        static int numberOfGuesses;
        static string correctWord = "hangman";
        static char[] letters;
        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine( "Starting the game...");
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
                userName = input;
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
        {
            for (int i = 0; i <correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                    letters[i] = guessedLetter;
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

            numberOfGuesses++;

            return input[0];
        }
        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {userName}!");
            Console.WriteLine($"Guesses: {numberOfGuesses}");
        }
    }
}
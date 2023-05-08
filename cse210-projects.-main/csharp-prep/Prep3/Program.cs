using System;

class Program {
    static void Main(string[] args) {
        bool playAgain = true;

        while (playAgain) {
            // generate a random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            // initialize the guess variable to 0 and the number of guesses to 0
            int guess = 0;
            int numGuesses = 0;

            // loop until the user guesses the magic number
            while (guess != magicNumber) {
                // ask the user for a guess
                Console.Write("Guess my number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;

                // check if the guess is higher or lower than the magic number
                if (guess < magicNumber) {
                    Console.WriteLine("Higher!");
                } else if (guess > magicNumber) {
                    Console.WriteLine("Lower!");
                } else {
                    Console.WriteLine("Congratulations, you guessed my number in {0} guesses!", numGuesses);
                }
            }

            // ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "yes") {
                playAgain = false;
            }
        }
    }
}
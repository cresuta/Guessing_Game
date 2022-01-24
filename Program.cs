public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 100);
        int guessCount = 0;
        int userGuess;
        int chosenDifficultyLevel;
        
        Console.WriteLine($"Type '100' for cheater, '8' for easy, '6' for medium, or '4' for hard:");
        chosenDifficultyLevel = Convert.ToInt32(Console.ReadLine());
        
    
        while (guessCount < chosenDifficultyLevel)
        {
            Console.WriteLine("Guess the secret number:");
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess < secretNumber)
            {
                Console.WriteLine("\nToo Low");
                guessCount++;
                Console.WriteLine($"Number of guesses left ({chosenDifficultyLevel - guessCount})");
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine("\nToo High");
                guessCount++;
                Console.WriteLine($"Number of guesses left ({chosenDifficultyLevel - guessCount})");
            }
            else if (userGuess == secretNumber)
            {
                Console.WriteLine("\nCORRECT!");
                guessCount++;
                break;
            }

        }
    }

}
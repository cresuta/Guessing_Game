public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 100);
        int guessCount = 0;
        int input;


        while (guessCount < 4)
        {
            // Console.WriteLine($"Random number to guess is: {secretNumber}");
            Console.WriteLine("Guess the secret number:");
            input = Convert.ToInt32(Console.ReadLine());

            if (input < secretNumber)
            {
                Console.WriteLine("\nToo Low");
            }
            else if (input > secretNumber)
            {
                Console.WriteLine("\nToo High");
            }
            else if (input == secretNumber)
            {
                Console.WriteLine("\nCORRECT!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, incorrect guess!");
                Console.WriteLine($"\nPrevious guess ({input})");
                guessCount++;
                Console.WriteLine($"Number of guesses left ({4 - guessCount})");

            }

        }
    }

}
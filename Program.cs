public class Program
{
    static void Main(string[] args)
    {
        int input;
        Console.WriteLine("Guess the secret number:");
        input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your guess was: {input}");
    }
}
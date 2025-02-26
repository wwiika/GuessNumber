using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ConsoleKeyInfo tmp;
            int max = 0;
            int min = 0;
            int attempt = 0;
            int gamescount = 0;
            do
            {
                int number = random.Next(1, 100);
                gamescount++;
                int currentAttempt = 0;
                while (true)
                {
                    currentAttempt++;
                    int mysteryNumber = 0;
                    Console.WriteLine("Enter correct number in [1;100]");
                    while (!int.TryParse(Console.ReadLine(), out mysteryNumber) || mysteryNumber < 1 || mysteryNumber > 100)
                        Console.WriteLine("Error enter correct number in [1;100]");
                    if (mysteryNumber > number)
                        Console.WriteLine("GuessNumber is less");
                    else if (mysteryNumber < number)
                        Console.WriteLine("GuessNumber is more");
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }


                attempt += currentAttempt;
                min = min == 0 || min > currentAttempt ? currentAttempt : min;
                // if (min > attempt) min = attempt;
                max = max < currentAttempt ? currentAttempt : max;
                tmp = Console.ReadKey();
            } while (tmp.Key == ConsoleKey.Y);
            Console.WriteLine($"Min = {min} \nMax = {max}\nAvg = {attempt * 1.0 / gamescount}");

        }
    }
}



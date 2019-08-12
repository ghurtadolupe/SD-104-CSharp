using System;

namespace Lab_4_Guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {


            do
            {

                Random rand = new Random();
                int hidden = rand.Next(100);
                int guess = 0;
                int guesses = 0;

                //ask user for a number
                Console.WriteLine("Guess a number between 0 and 100!");

                while (guess != hidden)
                {
                    guesses++;

                    int.TryParse(Console.ReadLine(), out guess);


                    //keep guessing until they guess the number
                    if (guess > hidden)
                    {
                        Console.WriteLine("Nope, " + guess + " is too high.");
                    }

                    else if (guess < hidden)
                    {
                        Console.WriteLine("No no no, " + guess + " is too low.");
                    }

                    else
                    {
                        Console.WriteLine("That is correct!! " + guess + " Is the correct answer! You Win Nothing!");
                        Console.WriteLine("Took you long enough! Thankyou for wasting my RAM");
                        Console.WriteLine("Number of guesses: " + guesses);

                    }

                }
                Console.WriteLine("Would you like to play again? Type Y for Yes or any other key to quit");
            } while (Console.ReadLine() == "Y");

           

        }
    }
}

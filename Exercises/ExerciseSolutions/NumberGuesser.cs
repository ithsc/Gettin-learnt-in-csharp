using System;
using Exercises.Subscribers;

namespace Exercises.ExerciseSolutions
{
    public class NumberGuesser : Exercise
    {
        ExerciseObserver _observer;
        public NumberGuesser(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 4;
            Title = "Number Guesser";
            Description = "Numbers game!";
        }
        public override void Run()
        {
            int guesses = 0;

            while (true)
            {

                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");


                while (guess != correctNumber)
                {
                    guesses++;
                    if (guesses == 4)
                    {
                        Console.WriteLine($"Hint! The Number you are looking for is {correctNumber - 2 } And {correctNumber + 2}");
                    }

                    string input = Console.ReadLine();


                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Please use an actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.WriteLine("Wrong number");

                    }
                }

                Console.WriteLine("Correct number");

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
    }
}

using System;
using Exercises.Subscribers;

namespace Exercises.Solutions
    public class LargestNumber : Exercise
    {

        ExerciseObserver _observer;
        public LargestNumber(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 3;
            Title = "Compare Numbers";
            Description = "Compares two inputs, returns largest number.";
        }

        public void Compare()
        {
            try
            {
                Console.Write("Enter a number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a another number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (x == y) Console.WriteLine("They are equal");
                else Console.WriteLine(x > y ? x : y);

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Compare();
            }
        }
        public override void Run()
        {
            Compare();

        }
    }
}
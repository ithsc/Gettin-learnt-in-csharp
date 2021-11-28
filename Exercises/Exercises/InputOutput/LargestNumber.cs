using System;
using Exercises.Subscribers;

namespace Exercises.Exercises.InputOutput
{
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
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override void Run()
        {
            Compare();
        }
    }
}

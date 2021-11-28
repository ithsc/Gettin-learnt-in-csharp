using System;
using Exercises.Exercises;
using Exercises.Exercises.InputOutput;
namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            var exerciseObserver = new ExerciseObserver();
            RegisterTasks(exerciseObserver);
            exerciseObserver.Run();
        }
        private static void RegisterTasks(ExerciseObserver observer)
        {
            var helloWorld = new HelloWorld(observer);
            var userProps = new UserProps(observer);
            var compareNumbers = new LargestNumber(observer);
            var numbersGuesser = new NumberGuesser(observer);
            var palindrome = new Palindrome(observer);
            var printNumbersBetween = new PrintNumbersBetween(observer);
            var characterBuilder = new CharacterBuilder(observer);
        }
    }
}

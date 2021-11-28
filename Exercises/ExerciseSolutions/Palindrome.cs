using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Subscribers;

namespace Exercises.Solutions
{
    public class Palindrome : Exercise
    {
        ExerciseObserver _observer;
        public Palindrome(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 5;
            Title = "Palindrome";
            Description = "Palindrome";
        }

        public bool PalindromeValidator()
        {
            Console.WriteLine("Enter a name");
            string input = Console.ReadLine();
            var reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed);
        }
        public override void Run()
        {
            Console.WriteLine(PalindromeValidator());
        }
    }
}
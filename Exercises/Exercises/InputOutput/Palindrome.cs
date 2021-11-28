using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Subscribers;

namespace Exercises.Exercises.InputOutput
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
            return true;
        }
        public override void Run()
        {
            Console.WriteLine(PalindromeValidator());
        }
    }
}
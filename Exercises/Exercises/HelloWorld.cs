using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Subscribers;

namespace Exercises.Exercises
{
    public class HelloWorld : Exercise
    {
        private readonly ExerciseObserver _observer;
        public HelloWorld(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 1;
            Title = "Hello World";
            Description = "Prints 'Hello World'.";
        }
        private void PrintString(string msg)
        {
            ConsoleEventing.Msg(msg);
        }
        public override void Run()
        {
            PrintString("Hello World");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Subscribers;

namespace Exercises.Exercises.InputOutput
{
    public class UserProps : Exercise
    {
        ExerciseObserver _observer;
        public UserProps(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 2;
            Title = "User Props";
            Description = "Prints user info";
        }
        public override void Run()
        {
            
        }
    }
}

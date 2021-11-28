using Exercises.Subscribers;

namespace Exercises.Exercises.InputOutput
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

        }
    }
}

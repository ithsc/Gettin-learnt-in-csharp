using Exercises.Subscribers;

namespace Exercises.Exercises.InputOutput
{
    public class PrintNumbersBetween : Exercise
    {
        ExerciseObserver _observer;
        public PrintNumbersBetween(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 6;
            Title = "PrintNumbersBetween";
            Description = "PrintNumbersBetween";
        }
        public override void Run()
        {
       

        }
    }
}

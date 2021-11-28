using Exercises.Subscribers;

namespace Exercises.Exercises.InputOutput
{
    public class CharacterBuilder : Exercise
    {
        ExerciseObserver _observer;
        public CharacterBuilder(ExerciseObserver observer)
        {
            _observer = observer;
            _observer.RegisterExercise(this);
            Id = 7;
            Title = "CharacterBuilder";
            Description = "CharacterBuilder";
        }

        public override void Run()
        {

        }
       
    }
}

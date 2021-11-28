using System;
using System.Collections.Generic;
using Exercises.Subscribers;
using Exercises.Observers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class ExerciseObserver : IExerciseObserver
    {
        private List<Exercise> _exercises = new List<Exercise>();

        public void RegisterExercise(Exercise exercise)
        {
            _exercises.Add(exercise);
        }

        public void SetActiveTask()
        {
            Menu<Exercise>.SetActive(_exercises);
        }
        public void Run()
        {
            SetActiveTask();
        }
    }
}

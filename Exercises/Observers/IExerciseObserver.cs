using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Subscribers;

namespace Exercises.Observers
{
    public interface IExerciseObserver
    {
        void RegisterExercise(Exercise exercise);
        void SetActiveTask();
    }
}

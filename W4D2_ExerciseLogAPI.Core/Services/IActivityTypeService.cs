using System.Collections.Generic;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeService
    {
        ActivityType Add(ActivityType newActivityType);
        ActivityType Get(int id);
        List<ActivityType> GetAll();
        void Remove(ActivityType deleteActivityType);
        ActivityType Update(ActivityType updatedActivityType);
    }
}
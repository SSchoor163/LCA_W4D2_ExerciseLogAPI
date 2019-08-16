using System;
using System.Collections.Generic;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeRepository
    {
        ActivityType Add(ActivityType newActivityType); //create
        ActivityType Get(int id); //read
        ActivityType Update(ActivityType updatedActivityType); //update
        void Remove(ActivityType deleteActivityType); //Remove
        List<ActivityType> GetAll(); // List all
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityRepository
    {
        Activity Add(Activity newActivity); //create
        Activity Get(int id); //read
        Activity Update(Activity updatedActivity); //update
        void Remove(Activity deleteActivity); //Remove
        List<Activity> GetAll(); // List all
    }
}

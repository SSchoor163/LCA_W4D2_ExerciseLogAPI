using System;
using System.Collections.Generic;
using W4D2_ExerciseLogAPI.Core.Models;
using System.Text;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityService
    {
        Activity Add(Activity newActivity); //create
        Activity Get(int id); //read
        Activity Update(Activity updatedActivity); //update
        void Remove(Activity deleteActivity); //Remove
        List<Activity> GetAll(); // List all
    }
}

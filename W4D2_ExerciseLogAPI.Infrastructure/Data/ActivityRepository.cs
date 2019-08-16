using System;
using System.Collections.Generic;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Services;
using W4D2_ExerciseLogAPI.Core.Models;
using System.Linq;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDBContext _dbContext;
        public ActivityRepository(AppDBContext DbContext)
        {
            _dbContext = DbContext;
        }

        public Activity Add(Activity newActivity) //create
        {
            _dbContext.Activities.Add(newActivity);
            _dbContext.SaveChanges();
            return newActivity;
        }
        public Activity Get(int id) //read
        {
            var activity = _dbContext.Activities
                        .Include(u => u.ActivityType)
                        .FirstOrDefault(u => u.Id == id);
            if (activity == null) return null;
            return activity;
        }
        public Activity Update(Activity updatedActivity) //update
        {
            var currentActivity = _dbContext.Activities.FirstOrDefault(u => u.Id == updatedActivity.Id);
            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity).CurrentValues.SetValues(updatedActivity);
            _dbContext.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }
        public void Remove(Activity deleteActivity) //Remove
        {
            _dbContext.Activities.Remove(deleteActivity);
            _dbContext.SaveChanges();
        }
        public List<Activity> GetAll() // List all
        {
            return _dbContext.Activities
                .Include(a=>a.ActivityType)
                .ToList();
        }
    }
}

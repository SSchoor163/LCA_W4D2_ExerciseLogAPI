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
    public class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDBContext _dbContext;
        public ActivityTypeRepository(AppDBContext DbContext)
        {
            _dbContext = DbContext;
        }

        public ActivityType Add(ActivityType newActivityType) //create
        {
            _dbContext.ActivityTypes.Add(newActivityType);
            _dbContext.SaveChanges();
            return newActivityType;
        }
        public ActivityType Get(int id) //read
        {
            var activityType = _dbContext.ActivityTypes.FirstOrDefault(u => u.Id == id);
            if (activityType == null) return null;
            return activityType;
        }
        public ActivityType Update(ActivityType updatedActivityType) //update
        {
            var currentActivityType = _dbContext.ActivityTypes.FirstOrDefault(u => u.Id == updatedActivityType.Id);
            if (currentActivityType == null) return null;

            _dbContext.Entry(currentActivityType).CurrentValues.SetValues(updatedActivityType);
            _dbContext.Update(currentActivityType);
            _dbContext.SaveChanges();
            return currentActivityType;
        }
        public void Remove(ActivityType deleteActivityType) //Remove
        {
            _dbContext.ActivityTypes.Remove(deleteActivityType);
            _dbContext.SaveChanges();
        }
        public List<ActivityType> GetAll() // List all
        {
            return _dbContext.ActivityTypes.ToList();
        }
    }
}

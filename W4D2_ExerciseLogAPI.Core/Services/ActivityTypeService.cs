using System;
using System.Collections.Generic;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeService
    {
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository ActivityTypeRepo)
        {
            _activityTypeRepo = ActivityTypeRepo;
        }

        public ActivityType Add(ActivityType newActivityType)//create
        {
            return _activityTypeRepo.Add(newActivityType);
        }
        public ActivityType Get(int id) //read
        {
            var activityType = _activityTypeRepo.Get(id);
            return activityType;
        }
        public ActivityType Update(ActivityType updatedActivityType) //update
        {
            var update = _activityTypeRepo.Update(updatedActivityType);
            return update;
        }
        public void Remove(ActivityType deleteActivityType) //Remove
        {
            _activityTypeRepo.Remove(deleteActivityType);
        }
        public List<ActivityType> GetAll() // List all
        {
            return _activityTypeRepo.GetAll();
        }

    }
}

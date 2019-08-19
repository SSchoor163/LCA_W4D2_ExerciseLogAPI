using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Models;


namespace W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activityRepository;
        private IActivityTypeRepository _activityTypeRepository;
        public ActivityService(IActivityRepository activityRepository, IActivityTypeRepository activityTypeRepository)
        {
            _activityRepository = activityRepository;
            _activityTypeRepository = activityTypeRepository;
        }

        public Activity Add(Activity newActivity) //create
        {
            var activityType = _activityTypeRepository.Get(newActivity.ActivityTypeId);
            if(activityType.RecordType == RecordType.DurationAndDistance && newActivity.Distance <= 0)
            {
                throw new Exception("You must supply a distance for this activity.");
            }
            if(newActivity.Duration <= 0)
            {
                throw new ApplicationException("You must supply a Duration for this activity.");
            }
            _activityRepository.Add(newActivity);
            return newActivity;
        }
        public Activity Get(int id) //read
        {
            return _activityRepository
             
                .Get(id);
        }
        public Activity Update(Activity updatedActivity) //update
        {
            var activityType = _activityTypeRepository.Get(updatedActivity.ActivityTypeId);
            if (activityType.RecordType == RecordType.DurationAndDistance && updatedActivity.Distance <= 0)
            {
                throw new Exception("Duration must be greater than 0 for this updated activity");
            }
            var Activity = _activityRepository.Update(updatedActivity);
            return Activity;
        }
        public void Remove(Activity deleteActivity) //Remove
        {
            _activityRepository.Remove(deleteActivity);
        }
        public List<Activity> GetAll() // List all
        {
            return _activityRepository.GetAll();
        }
    }
}

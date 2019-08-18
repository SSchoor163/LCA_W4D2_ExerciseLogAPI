using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.APIModels
{
    public static class ActivityMappingExtension
    {
        public static ActivityModel ToAPIModel(this Activity activity)
        {
            return new ActivityModel
            {
                Id = activity.Id,
                Date = activity.Date,
                Distance = activity.Distance,
                Duration = activity.Duration,
                Notes = activity.Notes,
                ActivityTypeId = activity.ActivityTypeId,
                ActivityType = $"{activity.ActivityType.Name}",
                UserId = activity.UserId,
                User = $"{activity.User.Name}"
            };
        }
        public static Activity ToDomainModel(this ActivityModel activityModel)
        {
            return new Activity
            {
                Id = activityModel.Id,
                Date = activityModel.Date,
                Distance = activityModel.Distance,
                Duration = activityModel.Duration,
                Notes = activityModel.Notes,
                ActivityTypeId = activityModel.ActivityTypeId,
                UserId = activityModel.UserId,
            };
        }
        public static List<ActivityModel>ToAPIModels(this List<Activity> activities)
        {
            if (activities == null) return null;
            return activities
                .Select(a => a.ToAPIModel()).ToList();
        }
        public static List<Activity> ToDomainModels(this List<ActivityModel> activityModels)
        {
            if (activityModels == null) return null;
            return activityModels.Select(a => a.ToDomainModel()).ToList();
        }
        
    }
}

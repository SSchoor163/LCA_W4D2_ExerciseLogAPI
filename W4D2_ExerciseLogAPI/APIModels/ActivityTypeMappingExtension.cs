using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.APIModels
{
    public static class ActivityTypeMappingExtension
    {
        public static ActivityTypeModel ToAPIModel(this ActivityType activityType)
        {
            return new ActivityTypeModel
            {
                Id = activityType.Id,
                Name = activityType.Name,
                RecordType = activityType.RecordType
            };
        }
        public static ActivityType ToDomainModel(this ActivityTypeModel activityType)
        {
            return new ActivityType
            {
                Id = activityType.Id,
                Name = activityType.Name,
                RecordType = activityType.RecordType
            };
        }
        public static List<ActivityTypeModel> ToAPIModels(this List<ActivityType> activityTypes)
        {
            if (activityTypes == null) return null;
            return activityTypes.Select(a => a.ToAPIModel()).ToList();
        }
        public static List<ActivityType> ToDomainModels(this List<ActivityTypeModel> activityTypes)
        {
            if (activityTypes == null) return null;
            return activityTypes.Select(a => a.ToDomainModel()).ToList();
        }
    }
}

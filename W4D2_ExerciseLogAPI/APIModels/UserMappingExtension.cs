using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W4D2_ExerciseLogAPI.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace W4D2_ExerciseLogAPI.APIModels
{
    public static class UserMappingExtension
    {
        public static UserModel ToAPIModel(this User user)
        {
            if (user == null) return null;
            return new UserModel
            {
                Activities = user.Activities
                .ToAPIModels(),
                Id = user.Id,
                Name = user.Name
            };
        }
        public static User ToDomainModel(this UserModel userModel)
        {
            return new User
            {
                Activities = userModel.Activities.ToDomainModels(),
                Id = userModel.Id,
                Name = userModel.Name
            };
        }
        public static List<UserModel> ToAPIModels(this List<User> users)
        {
            if (users == null) return null;
            return users.Select(u => u.ToAPIModel()).ToList();
        }
        public static List<User> ToDomainMoels(this List<UserModel> users)
        {
            if (users == null) return null;
            return users.Select(u => u.ToDomainModel()).ToList();
        }
    }
}

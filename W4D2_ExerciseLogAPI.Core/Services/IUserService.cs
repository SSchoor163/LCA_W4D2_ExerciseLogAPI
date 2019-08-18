using System.Collections.Generic;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public interface IUserService
    {
        User Add(User newUser);
        User Get(int id);
        List<User> GetAll();
        void Remove(User deleteUser);
        User Update(User updatedUser);
    }
}
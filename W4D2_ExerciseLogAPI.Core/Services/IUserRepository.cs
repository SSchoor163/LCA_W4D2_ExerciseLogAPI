using System;
using System.Collections.Generic;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public interface IUserRepository
    {
        User Add(User newUser); //create
        User Get(int id); //read
        User Update(User updatedUser); //update
        void Remove(User deleteUser); //Remove
        List<User> GetAll(); // List all


    }
}

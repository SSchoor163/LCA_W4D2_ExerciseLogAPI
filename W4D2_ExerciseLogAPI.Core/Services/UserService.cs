using System;
using System.Collections.Generic;
using System.Text;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public User Add(User newUser)//create
        {
            return _userRepo.Add(newUser);
        }
        public User Get(int id) //read
        {
            var user = _userRepo.Get(id);
            return user;
        }
        public User Update(User updatedUser) //update
        {
            var update = _userRepo.Update(updatedUser);
            return update;
        }
        public void Remove(User deleteUser) //Remove
        {
            _userRepo.Remove(deleteUser);
        }
        public List<User> GetAll() // List all
        {
            return _userRepo.GetAll();
        }

    }
}

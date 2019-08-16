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
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _dbContext;
        public UserRepository(AppDBContext DbContext)
        {
            _dbContext = DbContext;
        }

        public User Add(User newUser) //create
        {
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
            return newUser;
        }
        public User Get(int id) //read
        {
            var user = _dbContext.Users
                        .Include(u=>u.Activities)
                        .FirstOrDefault(u => u.Id == id);
            if (user == null) return null;
            return user;
        }
        public User Update(User updatedUser) //update
        {
            var currentUser = _dbContext.Users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (currentUser == null) return null;

            _dbContext.Entry(currentUser).CurrentValues.SetValues(updatedUser);
            _dbContext.Update(currentUser);
            _dbContext.SaveChanges();
            return currentUser;
        }
        public void Remove(User deleteUser) //Remove
        {
            _dbContext.Users.Remove(deleteUser);
            _dbContext.SaveChanges();
        }
        public List<User> GetAll() // List all
        {
            return _dbContext.Users.ToList();
        }
    }
}

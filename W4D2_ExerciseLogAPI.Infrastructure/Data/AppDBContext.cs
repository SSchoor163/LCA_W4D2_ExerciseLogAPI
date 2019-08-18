using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;
using W4D2_ExerciseLogAPI.Core.Models;

namespace W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class AppDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutiveDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutiveDirectory.Parent.Parent.Parent.Parent;
           string DatabaseFile = Path.Join(ProjectBase.FullName, "W4D2_ExerciseLogAPI.Infrastructure", "ExerciseLog.db");
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityType>().HasData(

                new ActivityType { Id = 1, Name = "Running", RecordType = RecordType.DurationAndDistance },
                new ActivityType { Id = 2, Name = "Weights", RecordType = RecordType.DurationOnly },
                new ActivityType { Id = 3, Name = "Walking", RecordType = RecordType.DurationAndDistance }
                );
            modelBuilder.Entity<User>().HasData(
                  new User { Id = 1, Name = "Test User" }
              );
            modelBuilder.Entity<Activity>().HasData(
                 new Activity { Id = 1, UserId = 1, ActivityTypeId = 1, Date = new DateTime(2019, 6, 19), Distance = 3, Duration = 30, Notes = "Hot!!!!" }
             );

        }
    }
}

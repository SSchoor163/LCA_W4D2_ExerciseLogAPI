using System;
using System.Collections.Generic;
using System.Text;

namespace W4D2_ExerciseLogAPI.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Activity> Activities { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W4D2_ExerciseLogAPI.APIModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ActivityModel> Activities { get; set; }
    }
}

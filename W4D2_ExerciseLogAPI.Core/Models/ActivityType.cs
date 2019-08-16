using System;
using System.Collections.Generic;
using System.Text;

namespace W4D2_ExerciseLogAPI.Core.Models
{
    public enum RecordType
    {
        DurationOnly, //Activity that only records duration
        DurationAndDistance //Activity that records duration and distance
    }
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RecordType RecordType { get; set; }
    }
}

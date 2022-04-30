using System;

namespace Tasks.API.Models
{
    public class Note
    {
        public int id { get; set; }
        public bool isImportant { get; set; }
        public int number { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime createdTime { get; set; }
    }
}

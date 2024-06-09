using System;
using System.Collections.Generic;

namespace ProjectManagementAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompletionPercentage { get; set; }
        public int OverdueTasks { get; set; }
        public int PendingTasks { get; set; }
        public int CompletedTasks { get; set; }
        public string Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public List<Task> Tasks { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagementAPI.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Task name is required")]
        [StringLength(100, ErrorMessage = "Task name must be between 1 and 100 characters", MinimumLength = 1)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        public string Priority { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }

        public bool Completed { get; set; }

        // Foreign key
        public int ProjectId { get; set; }

        // Navigation property
        public Project Project { get; set; }
    }
}

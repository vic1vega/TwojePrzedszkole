using System;
using System.Collections.ObjectModel;

namespace TwojePrzedszkole.API.Models
{
    public class Task
    {
        public int Id { get; set; }
        public Collection<TaskCategory> TaskCategories { get; set; }
        public string TaskName { get; set; }
        public int Quantity { get; set; }
        public DateTime TaskDate { get; set; }
        public Collection<User> AssignedUsers { get; set; } //classes leaders
        public Collection<Child> AssignedChilds { get; set; }
        public DateTime Created { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using TwojePrzedszkole.API.Models;

namespace TwojePrzedszkole.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<ChildGroup> ChildGroups { get; set; }
        public DbSet<ChildGroupCategory> ChildGroupCategories { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoGallery> PhotoGallerys { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) {}

        public DbSet<TodoItems> TodoItems { get; set; }
    }
}

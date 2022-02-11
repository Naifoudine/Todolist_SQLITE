using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist_SQLITE.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= C:\Users\wazer\source\repos\WinFormsAppSQLITE\DB\DBTodolist.sql");
        }

        public DbSet<Todo> Todos { get; set; }

        public List<Todo> GetAll()
        {
            return Todos.ToList();
        }

        public bool Update(Todo todo)
        {
            var data = Todos.FirstOrDefault();
            if (data == null)
            {
                return false;
            }
            data.Task = todo.Task;  
            data.Description = todo.Description;
            data.Date = todo.Date;
            data.Status = todo.Status;
            return SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var todo = Todos.FirstOrDefault(task=>task.Id==id);
            if (todo == null)
            {
                return false;
            }
            Todos.Remove(todo);
            
            return SaveChanges() > 0;
        }


    }
}

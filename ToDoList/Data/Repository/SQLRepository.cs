using ToDoList.Models;

namespace ToDoList.Data.Repository
{
    public class SQLRepository : IRepository
    {
        private readonly DB _context;
        public SQLRepository(DB context)
        {
            _context = context;
        }

        public void AddTodo(string todoName)
        {
            TodoItems newItem = new TodoItems()
            {
                Title= todoName,
                IsDone= false,
            };

            _context.TodoItems.Add(newItem);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var deletedItem = _context.TodoItems.Find(id);

            if (deletedItem != null)
            {
                _context.TodoItems.Remove(deletedItem);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TodoItems> GetAllItems()
        {
            return _context.TodoItems;
        }

        public void ValueChanged(TodoItems changedItem)
        {
            var item = _context.TodoItems.Attach(changedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }
    }
}

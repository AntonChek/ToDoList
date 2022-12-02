using ToDoList.Models;

namespace ToDoList.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItems> GetAllItems();
        void AddTodo(string todoName);
        void ValueChanged(TodoItems changedItem);
        void DeleteItem(int id);
    }
}

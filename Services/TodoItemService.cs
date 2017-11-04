using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Data;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Services
{
    public class TodoItemService : ITodoItemService
    {
        public readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            return await _context.Items
                 .Where(x => x.IsDone == false)
                 .ToArrayAsync();
        }
    }
}

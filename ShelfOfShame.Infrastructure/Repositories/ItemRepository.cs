using Microsoft.EntityFrameworkCore;
using ShelfOfShame.Domain.Interfaces;
using ShelfOfShame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }
        public int AddItem(Item itemToAdd)
        {
            _context.Items.Add(itemToAdd);
            _context.SaveChanges();
            return itemToAdd.Id;
        }

        public void DeleteItem(int itemToRemove)
        {
            var itemToRemoveInDatabase = _context.Items.Find(itemToRemove);
            if (itemToRemoveInDatabase != null)
            {
                _context.Items.Remove(itemToRemoveInDatabase);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Item has not been found in Database");
            }
        }

        public IQueryable<Item> GetAllItems()
        {
            IQueryable<Item> items = _context.Items;
            return items;
        }

        public void UpdateItem(Item itemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

using ShelfOfShame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Interfaces
{
    public interface IItemRepository
    {
        int AddItem(Item itemToAdd);
        void DeleteItem(int itemToRemove);
        void UpdateItem(Item itemUpdatedInfo);
        Item GetItemById(int itemId);
        IQueryable<Item> GetAllItems();
    }
}

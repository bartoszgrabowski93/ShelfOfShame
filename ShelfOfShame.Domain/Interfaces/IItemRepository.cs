using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Interfaces
{
    public interface IItemRepository
    {
        int AddItem(IItem itemToAdd);
        void DeleteItem(IItem itemToRemove);
        void UpdateItem(IItem itemToUpdate);
        IQueryable<IItem> GetAllItems();
    }
}

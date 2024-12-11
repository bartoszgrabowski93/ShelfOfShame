using ShelfOfShame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Interfaces
{
    public interface IShelfRepository
    {
        int AddShelf(int userId, Shelf shelf);
        void AddItemOnShelf(int userId, int shelfId, Item item);
        void RemoveItemFromShelf(int userId, int shelfId, int itemId);
        void RemoveShelf(int userId, int shelfId);
        ICollection<Shelf> GetAllShelves(int userId);
    }
}

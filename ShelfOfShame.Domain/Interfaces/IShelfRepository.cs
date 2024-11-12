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
        int AddShelf(Shelf shelf, User user);
        void AddItemOnShelf(Shelf shelf, Item item);
        void RemoveItemFromShelf(Shelf shelf, int itemId);
        void RemoveShelf(int shelfId);
        ICollection<Shelf> GetAllShelves();
    }
}

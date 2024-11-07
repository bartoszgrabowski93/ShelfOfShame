using ShelfOfShame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Interfaces
{
    public interface IUserRepositorycs
    {
        int AddUser(User userToAdd);
        void DeleteUser(int userId);
        void UpdateUser(User userToUpdate);
        IQueryable<User> GetAllUsers();

    }
}

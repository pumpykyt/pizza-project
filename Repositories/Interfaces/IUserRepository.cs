using System.Collections.Generic;
using System.Threading.Tasks;
using DTO.Requests;
using EFCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(string id);
    }
}
using CinemaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaApplication.Areas.Admin.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
        // Task<IEnumerable<Order>> GetAllAsync(params Expression<Func<Order, object>>[] includeProperties);
        Task<List<Order>> GetOrderByIdAsync(int id);
        Task DeleteAsync(int id);




    }
}

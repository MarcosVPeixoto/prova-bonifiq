using Microsoft.EntityFrameworkCore;
using ProvaPub.Data;
using ProvaPub.IRepositories;
using ProvaPub.Models;

namespace ProvaPub.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TestDbContext _context;

        public CustomerRepository(TestDbContext context)
        {
            _context = context;
        }

        public Task<bool> CanPurchase(int customerId, decimal purchaseValue)
        {
            throw new NotImplementedException();
        }

        public CustomerList ListCustomers(int page)
        {
            var count = _context.Products.Count();
            var hasNext = count - (page * 10) > 0;
            var skip = (page - 1) * 10;
            var customers = _context.Customers
                                   .Skip(skip)
                                   .Take(10)
                                   .ToList();
            return new CustomerList() { HasNext = hasNext, TotalCount = count, Customers = customers };
        }

        public async ValueTask<Customer> FindAsync(int customerId) 
        {
            return await _context.Customers.FindAsync(customerId);
        }

        public Task<int> GetUserOrdersCountByDate(int customerId, DateTime baseDate)
        {
            return _context.Customers.CountAsync(s => s.Id == customerId && s.Orders.Any(w => w.OrderDate >= baseDate.Date));
        }
        public async Task<int> BoughtsBeforeCount (int customerId)
        {
            return await _context.Customers.CountAsync(s => s.Id == customerId && s.Orders.Any());
        }
    }
}

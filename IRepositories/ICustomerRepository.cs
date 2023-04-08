using ProvaPub.Models;

namespace ProvaPub.IRepositories
{
    public interface ICustomerRepository
    {
        CustomerList ListCustomers(int page);
        Task<bool> CanPurchase(int customerId, decimal purchaseValue);
        ValueTask<Customer> FindAsync(int customerId);
        Task<int> GetUserOrdersCountByDate(int customerId, DateTime baseDate);
        Task<int> BoughtsBeforeCount(int customerId);
    }
}

using ProvaPub.Enums;
using ProvaPub.Models;

namespace ProvaPub.IServices
{
    public interface IOrderService
    {
        Task<Order> PayOrder(PaymentMethod paymentMethod, decimal paymentValue, int customerId);
    }
}

using ProvaPub.Enums;
using ProvaPub.IServices;
using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService : IOrderService
	{
		public async Task<Order> PayOrder(PaymentMethod paymentMethod, decimal paymentValue, int customerId)
		{
			if (paymentMethod == PaymentMethod.Pix)
			{
				//Faz pagamento...
			}
			else if (paymentMethod == PaymentMethod.CreditCard)
			{
				//Faz pagamento...
			}
			else if (paymentMethod == PaymentMethod.Paypal)
			{
				//Faz pagamento...
			}

			return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}

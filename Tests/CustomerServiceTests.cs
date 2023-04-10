using ProvaPub.IRepositories;
using ProvaPub.Services;
using Moq;
using ProvaPub.Models;

namespace ProvaPub.Tests
{
    public class CustomerServiceTests
    {
        private readonly Mock<ICustomerRepository> _customerRepositoryMock;
        private CustomerService _customerService;

        public CustomerServiceTests()
        {
            _customerRepositoryMock = new Mock<ICustomerRepository>();            
            _customerService = new CustomerService(_customerRepositoryMock.Object);
        }

        [Fact]
        public void CanPurchase_CustomerIdIs0_ThrowsException()
        {
            Func <Task> act = async () => await _customerService.CanPurchase(0, 2);
            ArgumentException exception = Assert.ThrowsAsync<ArgumentOutOfRangeException>(act).Result;
            Assert.Equal("customerId", exception.ParamName);
        }

        [Fact]
        public void CanPurchase_PurchaseIs0_ThrowsException()
        {
            Func<Task> act = async () => await _customerService.CanPurchase(2, 0);
            ArgumentException exception = Assert.ThrowsAsync<ArgumentOutOfRangeException>(act).Result;
            Assert.Equal("purchaseValue", exception.ParamName);
        }

        [Fact]
        public void CanPurchase_CustomerIdNotExists_ThrowsException()
        {
            Func<Task> act = async () => await _customerService.CanPurchase(1, 2);
            InvalidOperationException exception = Assert.ThrowsAsync<InvalidOperationException>(act).Result;
            Assert.Equal("Customer Id 1 does not exists", exception.Message);
        }

        [Fact]
        public void CanPurchase_CustomerBoughtMoreThanOnce_ReturnsFalse()
        {
            _customerRepositoryMock.Setup(x => x.FindAsync(1).Result).Returns(new Customer { Id = 1, Name = "Jane Doe", Orders = new List<Order>() });            
            _customerRepositoryMock.Setup(x => x.GetUserOrdersCountByDate(1, DateTime.UtcNow.AddMonths(-1).Date).Result).Returns(2);
            Func<Task<bool>> act = async () => await _customerService.CanPurchase(1, 2);
            var result =  act.Invoke().GetAwaiter().GetResult();
            Assert.False(result);            
        }

        [Fact]
        public void CanPurchase_CustomerCanPurchase_ReturnsTrue()
        {
            _customerRepositoryMock.Setup(x => x.FindAsync(1).Result).Returns(new Customer { Id = 1, Name = "Jane Doe", Orders = new List<Order>() });            
            Func<Task<bool>> act = async () => await _customerService.CanPurchase(1, 2);
            var result = act.Invoke().GetAwaiter().GetResult();
            Assert.True(result);
        }
    }
}
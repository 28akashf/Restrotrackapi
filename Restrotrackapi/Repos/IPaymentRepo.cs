using Restrotrackapi.Models;

namespace Restrotrackapi.Repos
{
    public interface IPaymentRepo
    {
        Task<List<Payment>> GetAllPayments();
        Task<Payment> GetPaymentById(string id);
        Task<Payment> GetPaymentByOrderId(string id);
        Task<Payment> DeletePaymentById(string id);
        Task<Payment> AddNewPayment(Payment newPayment);
        Task<Payment> ModifyPayment(Payment newPayment);
    }
}

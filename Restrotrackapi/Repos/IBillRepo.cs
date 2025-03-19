using Restrotrackapi.Models;

namespace Restrotrackapi.Repos
{
    public interface IBillRepo
    {
        Task<List<Bill>> GetAllBills();
        Task<Bill> GetBillById(string id);
        Task<Bill> GetBillByOrderId(string id);
        Task<Bill> DeleteBillById(string id);
        Task<Bill> AddNewBill(Bill newbill);
        Task<Bill> ModifyBill(Bill newbill);
    }
}

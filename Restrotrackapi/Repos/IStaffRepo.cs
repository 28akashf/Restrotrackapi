using Restrotrackapi.Models;

namespace Restrotrackapi.Repos
{
    public interface IStaffRepo
    {
        Task<List<Staff>> GetAllStaffs();
        Task<Staff> GetStaffById(string id);
        Task<Staff> GetStaffByStaffId(string id);
        Task<Staff> DeleteStaffById(string id);
        Task<Staff> AddNewStaff(Staff newStaff);
        Task<Staff> ModifyStaff(Staff newStaff);
    }
}

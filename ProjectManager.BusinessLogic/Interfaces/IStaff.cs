using System.Collections.Generic;
using ProjectManager.BusinessLogic.Models;

namespace ProjectManager.BusinessLogic.Interfaces
{
    public interface IStaff
    {
        Staff GetStaffById(int id);

        List<Staff> GetStaffList();

        void AddStaff();

        void EditStaff(int id);

        void DeleteStaff(int id);
    }
}

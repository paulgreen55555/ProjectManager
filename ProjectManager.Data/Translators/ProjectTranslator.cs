using System.Collections.Generic;
using System.Linq;
using ProjectManager.Data.Models;

namespace ProjectManager.Data.Translators
{
    public class ProjectTranslator
    {
        public static BusinessLogic.Models.Project ToBusiness(Project from)
        {
            List<BusinessLogic.Models.Staff> blStaffs = new List<BusinessLogic.Models.Staff>();

            foreach (Staff staff in from.StaffList)
            {
                blStaffs.Add(StaffTranslator.ToBusiness(staff));
            }

            return new BusinessLogic.Models.Project()
            {
                ProjectId = from.ProjectId,
                Name = from.Name,
                Discription = from.Discription,
                StartDate = from.StartDate,
                EndDate = from.EndDate,
                CloseDate = from.CloseDate,
                StaffList = blStaffs,
                OwnerId = from.OwnerId
            };
        }
    }
}

using System;
using ProjectManager.Data.Models;

namespace ProjectManager.Data.Translators
{
    public class StaffTranslator
    {
        public static BusinessLogic.Models.Staff ToBusiness(Staff from)
        {
            return new BusinessLogic.Models.Staff()
            {
                FirstName = from.FirstName,
                LastName = from.LastName,
                MiddleName = from.MiddleName,
                StaffId = from.StaffId,
                UserId =  Convert.ToInt32(from.UserId)
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Data.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public virtual User UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Positions Position { get; set; }

        public Phone Phone { get; set; }

        public WorkType WorkType { get; set; }
    }

    public enum Positions
    {
        Administrator = 0,
        Manager = 1,
        PrManager = 2,
        Programer = 3,
        Tester = 4
    }

    public enum WorkType
    {
        Day = 0,
        Percent = 1
    }

}

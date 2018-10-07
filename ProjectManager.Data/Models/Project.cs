using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Data.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public int OwnerId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CloseDate { get; set; }

        public List<Staff> StaffList { get; set; }
    }
}

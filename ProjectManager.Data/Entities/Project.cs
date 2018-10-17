using System;

namespace ProjectManager.Data.Entities
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

    }
}

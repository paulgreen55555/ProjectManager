﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.Entities.Enums;

namespace ProjectManager.Entities.ViewModels.Project
{
    public class ProjectEditViewModel
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProjectStatus ProjectStatus { get; set; }
        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}

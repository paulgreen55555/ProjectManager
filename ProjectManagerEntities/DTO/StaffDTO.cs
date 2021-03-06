﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entities.DTO
{
    public class StaffDTO
    {
        public int StaffId { get; set; }
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Positions Position { get; set; }
        public PhoneDTO Phone { get; set; }
    }

    public enum Positions
    {
        Administrator = 0,
        Manager = 1,
        PrManager = 2,
        Programer = 3,
        Tester = 4
    }
}

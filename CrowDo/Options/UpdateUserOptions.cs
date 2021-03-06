﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowDo.Options
{
    public class UpdateUserOptions
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? YearOfBirth { get; set; }
        public int? DateOfBirthMonth { get; set; }
        public int? DateOfBirthDay { get; set; }
    }
}

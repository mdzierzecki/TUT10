﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial10_APBD.Models
{
    public class GetStudentsResponse
    {

        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public int Semester { get; set; }

        public string Studies { get; set; }


    }
}

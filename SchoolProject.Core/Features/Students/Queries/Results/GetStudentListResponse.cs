﻿using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Results
{
    public class GetStudentListResponse
    {
 
        public int Id { get; set; }
        public string? StudentName { get; set; }

        public string? Address { get; set; }

        public string? DepartmentName { get; set; }

    }
}

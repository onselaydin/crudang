﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crudang.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeAddress { get; set; }

        public string EmployeeSalary { get; set; }
    }
}
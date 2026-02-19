using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Tables
{
    public class Employee
    {
        public int EmployeeID {  get; set; }
        public string EmployeeName { get; set; } 
        public string EmployeeEmail { get; set; }
        public int DeparmentID { get; set; }
        public Department Department {  get; set; }
    }
}

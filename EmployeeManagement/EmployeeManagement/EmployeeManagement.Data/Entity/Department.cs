using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Tables
{
    public class Department
    {
        public int DepartmentId {  get; set; }
        public string DepartmentName {  get; set; } = string.Empty;
        public List<Employee> Employee {  get; set; }
    }
}

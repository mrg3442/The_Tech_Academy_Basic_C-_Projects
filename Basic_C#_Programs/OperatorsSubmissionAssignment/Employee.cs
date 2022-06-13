using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            return employee.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.ID.Equals(emp.ID);
        }
    }
}

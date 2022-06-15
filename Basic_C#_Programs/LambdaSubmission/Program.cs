using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a list of employees
            List<Employee> allEmployees = new List<Employee>();
            //foreach list
            List<Employee> joeEmployees1 = new List<Employee>();
            //instaniates ten instances of employee class with two having first name of joe
            //adds employees to list allEmployees
            allEmployees.Add(new Employee() { fName = "Joe", id = 0, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Ron", id = 1, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Kirk", id = 2, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Dee", id = 3, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Joe", id = 4, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Ron", id = 5, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Ronny", id = 6, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Ted", id = 7, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Xavier", id = 8, lName = "Brown" });
            allEmployees.Add(new Employee() { fName = "Joey", id = 9, lName = "Brown" });


            //foreach loop to create a list with each employee whos first name is joe
            foreach(var employee in allEmployees)
            {
                if(employee.fName == "Joe")
                {
                    joeEmployees1.Add(employee);
                }
            }

            //Lambda expression for list with each employee named joe
            List<Employee> joeEmployees2 = allEmployees.Where(x => x.fName == "Joe").ToList();

            //Lambda expression for list with id greater than 5
            List<Employee> greater5 = allEmployees.Where(x => x.id > 5).ToList();
            Console.WriteLine(greater5[1].id);
            Console.Read();
        }
    }
}

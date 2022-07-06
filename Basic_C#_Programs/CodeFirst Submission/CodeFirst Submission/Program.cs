using System.Data.Entity;

class Program
{
    static void Main(string[] args)
    {
        using (var ctx = new WorkContext())
        {
            var employee = new Employee() { FirstName = "Matt", LastName = "Green", HourlyRate = 9.45, HoursWorked = 40, Id = 1 };

            ctx.Employees.Add(employee);
            ctx.SaveChanges();
        }
    }
}


public class Employee
{
    public int Id { get; set; } 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public ICollection<Employee> Employees { get; set; }
}

public class WorkContext: DbContext
{
    public WorkContext(): base()
    {

    }

    public DbSet<Employee> Employees { get; set; }
}

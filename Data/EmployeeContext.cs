using Microsoft.EntityFrameworkCore;


public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Employee> Employees {get; set;}
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API Configuration Example:

        // Make LastName required using Fluent API
        modelBuilder.Entity<Employee>()
            .Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(50); // Redundant here as Data Annotation already set it, but shows the syntax

        // Define a one-to-many relationship between Department and Employee using Fluent API
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentID);

        // You can add more Fluent API configurations here

        base.OnModelCreating(modelBuilder);
    }
}

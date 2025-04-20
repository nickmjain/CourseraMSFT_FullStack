// See https://aka.ms/new-console-template for more information
using Course6_DatabaseIntegration;
using Course6_DatabaseIntegration.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


Console.WriteLine("Hello, World!");

var context = new CompanyContext();

var department = new Department { Name = "Engineering" };
context.Departments.Add(
    new Department
    {
        Name = "Engineering",
        Employees = new List<Employee>
        {
            new Employee
            {
                FirstName = "Marissa",
                LastName = "Johannsen",
                HireDate = DateTime.Now,
            },
            new Employee
            {
                FirstName = "Ryan",
                LastName = "Ford",
                HireDate = DateTime.Now,
            },
        },
    }
    );
context.SaveChanges();

var employees = context.Employees.Where(e => e.Department.Name == "Engineering").ToList();
Console.WriteLine($"Employees in Engineering Department: {employees.Count}");
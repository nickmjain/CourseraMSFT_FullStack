// See https://aka.ms/new-console-template for more information
using System;
using Course6_ProjectManagementApp;

using (var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();

    // Create
    context.Products.Add(new Product { Name = "Laptop", Price = 999.99m });
    context.SaveChanges();

    // Read
    Console.WriteLine("Products in the database:");
    var products = context.Products.ToList();
    foreach (var  product in products)
    {
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
    }

    // Update
    var productToUpdate = context.Products.First();
    productToUpdate.Price = 1200.99m;
    context.SaveChanges();

    // Delete
    var productToDelete = context.Products.OrderByDescending(p => p.Id).Last();
    context.Products.Remove(productToDelete);
    context.SaveChanges();
}
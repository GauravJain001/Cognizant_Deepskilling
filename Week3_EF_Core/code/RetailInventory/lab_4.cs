using RetailInventory.Data;
using RetailInventory.Models;

var context = new AppDbContext();

// Seed categories
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);

// Seed products
var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

await context.Products.AddRangeAsync(product1, product2);

// Save changes
await context.SaveChangesAsync();

Console.WriteLine("Initial data inserted successfully!");

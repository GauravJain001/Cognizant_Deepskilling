using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

var context = new AppDbContext();

//  Retrieve all products
var products = await context.Products.Include(p => p.Category).ToListAsync();
Console.WriteLine("\n All Products:");
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price} ({p.Category?.Name})");

//  Find product by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"\n Product with ID = 1: {product?.Name ?? "Not Found"}");

//  First product with price > ₹50,000
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\n Expensive Product: {expensive?.Name ?? "None"}");

using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;
var context = new AppDbContext();
// Update the price of the "Laptop"
var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
if (product != null)
{
    Console.WriteLine($"\nUpdating price of: {product.Name}");
    product.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine("Price updated!");
}
else
{
    Console.WriteLine("Laptop not found.");

//Delete the product "Rice Bag"
var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
if (toDelete != null)
{
    Console.WriteLine($"\nDeleting product: {toDelete.Name}");
    context.Products.Remove(toDelete);
    await context.SaveChangesAsync();
    Console.WriteLine("Product deleted!");
}
else
{
    Console.WriteLine("Rice Bag not found.");
}

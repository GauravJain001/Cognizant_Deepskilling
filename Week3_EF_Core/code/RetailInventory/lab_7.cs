using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    class Lab7
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("\nFiltered Products (Price > ₹1000, sorted by Price descending):");

            var filtered = await context.Products
                .Where(p => p.Price > 1000)
                .OrderByDescending(p => p.Price)
                .ToListAsync();

            foreach (var p in filtered)
            {
                Console.WriteLine($"- {p.Name} - ₹{p.Price}");
            }

            Console.WriteLine("\nProduct DTOs (Name + Price only):");

            var productDTOs = await context.Products
                .Select(p => new { p.Name, p.Price })
                .ToListAsync();

            foreach (var dto in productDTOs)
            {
                Console.WriteLine($"• {dto.Name}: ₹{dto.Price}");
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using Wardrobe.BL;

namespace Wardrobe.DAL
{
    public class WardrobeContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;

namespace Bethany_sPieShop.Models
{
    public class BethanysPieShopDbContext : DbContext
    {
       public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options) : base(options)
        {
        }  

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }

    }
}

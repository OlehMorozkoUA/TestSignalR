using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Models.Classes
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base() { }
        public DbSet<User> Users { get; set; }
    }
}

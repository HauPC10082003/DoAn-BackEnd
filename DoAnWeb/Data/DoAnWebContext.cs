using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAnWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DoAnWeb.Data
{
    public class DoAnWebContext : IdentityDbContext<User>
    {
        public DoAnWebContext (DbContextOptions<DoAnWebContext> options)
            : base(options)
        {
        }

        public DbSet<DoAnWeb.Models.Product> Products { get; set; } = default!;


        public DbSet<Cart> Carts { get; set; } = default!;

        public DbSet<Invoice> Invoices { get; set; } = default!;
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; } = default!;
        public DbSet<ProductType> ProductTypes { get; set; } = default!;
    }
}

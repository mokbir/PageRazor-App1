using Microsoft.EntityFrameworkCore;
using PageRazor_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageRazor_App1.Data
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PractiseTest.Models
{
    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext(DbContextOptions<CustomerDataContext> options)
          : base(options)
        {
        }

        public DbSet<Customer> TodoItems { get; set; }
    }
}

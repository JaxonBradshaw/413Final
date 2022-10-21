using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    public class QuoteDbContext : DbContext
    {
        //constructor
        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base(options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }
    }
}

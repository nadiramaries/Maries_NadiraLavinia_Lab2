using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maries_NadiraLavinia_Lab2.Models;

namespace Maries_NadiraLavinia_Lab2.Data
{
    public class Maries_NadiraLavinia_Lab2Context : DbContext
    {
        public Maries_NadiraLavinia_Lab2Context (DbContextOptions<Maries_NadiraLavinia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Maries_NadiraLavinia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Maries_NadiraLavinia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Maries_NadiraLavinia_Lab2.Models.Category> Category { get; set; } = default!;
    }
}

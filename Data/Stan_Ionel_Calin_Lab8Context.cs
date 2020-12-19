using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stan_Ionel_Calin_Lab8.Models;

namespace Stan_Ionel_Calin_Lab8.Data
{
    public class Stan_Ionel_Calin_Lab8Context : DbContext
    {
        public Stan_Ionel_Calin_Lab8Context (DbContextOptions<Stan_Ionel_Calin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stan_Ionel_Calin_Lab8.Models.Book> Book { get; set; }
    }
}

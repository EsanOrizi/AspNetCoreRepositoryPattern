using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMDB.Models;

namespace MyMDB.Data
{
    public class MyMDBContext : DbContext
    {
        public MyMDBContext (DbContextOptions<MyMDBContext> options)
            : base(options)
        {
        }

        public DbSet<MyMDB.Models.Movie> Movie { get; set; }
    }
}

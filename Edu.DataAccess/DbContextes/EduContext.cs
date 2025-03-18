using Edu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DataAccess.DbContextes
{
    public class EduContext : DbContext
    {
        public EduContext (DbContextOptions options) : base(options)
        {

        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ShowTime> ShowTimes { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

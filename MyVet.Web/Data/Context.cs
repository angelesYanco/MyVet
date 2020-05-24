using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;

namespace MyVet.Web.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owner { get; set; }

        public DbSet<Manager> Manager { get; set; }
    }
}

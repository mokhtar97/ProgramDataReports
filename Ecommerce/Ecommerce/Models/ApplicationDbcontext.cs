using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Models
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products{ get; set; }

        public DbSet<Ecommerce.Models.ApplicationProgram> Program { get; set; }

        public DbSet<Report> Rports { get; set; }

        public DbSet<Parameter> Parameters { get; set; }

      

    }
}

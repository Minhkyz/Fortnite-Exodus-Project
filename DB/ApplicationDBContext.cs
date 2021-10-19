using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mydemo.Models;

namespace AspWedsite.DB
{
    public class ApplicationDBContext: DbContext 
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options){

        }

        public DbSet<Product> Product{get; set;}
        public DbSet<Category> Category{get; set;}

    }
}
using EFWithRepo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWithRepo.Core
{
    public class Context : DbContext
    {

        public Context() : base("DefaultConnection")
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}

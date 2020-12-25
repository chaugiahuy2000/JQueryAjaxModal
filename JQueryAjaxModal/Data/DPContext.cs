using JQueryAjaxModal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JQueryAjaxModal.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options)
           : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}

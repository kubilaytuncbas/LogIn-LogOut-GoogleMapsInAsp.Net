using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
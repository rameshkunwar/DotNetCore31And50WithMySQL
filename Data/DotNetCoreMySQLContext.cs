using DotNetCoreMySQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreMySQL.Data
{
    public class DotNetCoreMySQLContext : DbContext
    {
        public DotNetCoreMySQLContext(DbContextOptions<DotNetCoreMySQLContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }    
}

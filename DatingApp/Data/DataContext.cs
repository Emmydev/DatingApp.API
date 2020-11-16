using DatingApp.DbObjects;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Value { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}

using System;
using dotnet_tutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_tutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
    }
}

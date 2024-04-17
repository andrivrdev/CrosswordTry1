using Microsoft.EntityFrameworkCore;
using Shared.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shared.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<tblTopic> tblTopics { get; set; }

        public AppDbContext()
        {
            SQLitePCL.Batteries_V2.Init();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Database.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }


    
    }

}

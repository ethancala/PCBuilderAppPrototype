using Microsoft.EntityFrameworkCore;
using PCBuilderPrototype1.Models;

namespace PCBuilderPrototype1.Data
{
    public class ApplicationDbContext : DbContext
    {

   // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        

    public DbSet<PCBuild> PCBuilds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)

           => options.UseSqlite(@"Data Source=C:\Users\ecala\OneDrive\Desktop\PCbuilddb\PCBuilder.db");
        


    }



}


using Microsoft.EntityFrameworkCore;
using NurseryMgrData.Models;

namespace NurseryMgrData
{
    public class NurseryDbContext : DbContext{
        public NurseryDbContext(DbContextOptions options):base(options){}
        public DbSet<Person> Persons{get; set;}
        public DbSet<Child> Children{get;set;}
        public DbSet<Parent> Parents{ get; set;}
        public DbSet<Teacher> Teacher{get;set;}
        public DbSet<Class> Classes{get;set;}
        public DbSet<DailyActivity> Activitties{get;set;}
        public DbSet<RegisterChild> RegisteredChildrens{get;set;}
        public DbSet<RegistrationStatus> RegistrationStatuses { get; set; }
        
        
    }
}

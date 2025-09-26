using Microsoft.EntityFrameworkCore;
using Konveyer.Models;

namespace Konveyer.Data{
    public class KonveyerDbContext: DbContext{
        public KonveyerDbContext(DbContextOptions<KonveyerDbContext> options)
        :base(options){
            
        }

        public DbSet<Application> Applications {get;set;}
        public DbSet<Client> Clients {get;set;}
        public DbSet<Credit> Credits {get;set;}
    }
}
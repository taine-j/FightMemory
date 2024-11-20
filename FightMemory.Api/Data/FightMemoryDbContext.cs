using Microsoft.EntityFrameworkCore;
using FightMemory.Domain.Entities;

namespace FightMemory.Infrastructure.Data // declares path for export
{
    public class FightMemoryDbContext : DbContext // inherits from DbContext, gives it functionality like connecting and querying
    {
        public DbSet<Technique> Techniques { get; set; } // represents table in DB, allows you to query like this:  var allTechniques = _context.Techniques.ToList(); 
        public DbSet<SparringLog> SparringLogs { get; set; }

        public FightMemoryDbContext(DbContextOptions<FightMemoryDbContext> options) 
            : base(options)
        { } // like a constructor with a super call. Using the parameter DbContextOptions from DbContext, 
    }
}

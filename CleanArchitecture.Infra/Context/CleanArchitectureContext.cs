using CleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Context
{
    public class CleanArchitectureContext : DbContext
    {
        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options) 
            : base(options)
        { }

        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<ParkedCar> ParkedCars { get; set; }
    }
}

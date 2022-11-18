using Vehiculo20201061.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Vehiculo20201061.Data.Context;
public class Vehiculo20201061DbContext:DbContext,IVehiculo20201061DbContext{
     public Vehiculo20201061DbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Vehiculo> Vehiculos {get; set;} = null!;

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}
public interface IVehiculo20201061DbContext
{
    public DbSet<Vehiculo> Vehiculos {get; set;}
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
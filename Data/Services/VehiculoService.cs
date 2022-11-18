using Vehiculo20201061.Data.Context;

namespace Vehiculo20201061.Data.Services;

public class VehiculoService
{
    private readonly IVehiculo20201061DbContext db;

    public VehiculoService(IVehiculo20201061DbContext db)
    {
        this.db = db;
    }


}
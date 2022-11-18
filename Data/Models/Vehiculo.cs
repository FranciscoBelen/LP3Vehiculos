namespace Vehiculo20201061.Data.Models;
using System.ComponentModel.DataAnnotations;
public class Vehiculo
{
    [Key]
    public int VehiculoID { get; set; }
    public string Marca { get; set; } = null!;
    public string  Modelo { get; set; } = null!;
    public int Año { get; set; }
    public string Color { get; set; } = null!;

}
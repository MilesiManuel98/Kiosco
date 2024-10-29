using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Producto
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; } = null!;
    [Required]
    private decimal precio;
    [Required]
    public decimal Precio
    {
        get => Math.Round(precio, 2);
        set => precio = Math.Round(value, 2);
    }

    public bool Eliminado { get; set; } = false;

    public bool Oferta { get; set; } = false;

    public override string ToString()
    {
        return Nombre;
    }
}

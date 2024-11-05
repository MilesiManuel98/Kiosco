using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Compra
{
    public int Id { get; set; }

    public FormaDePagoEnum FormaDePago { get; set; }

    private decimal iva;
    public decimal Iva
    {
        get => Math.Round(iva, 2);
        set => iva = Math.Round(value, 2);
    }

    private decimal total;
    public decimal Total
    {
        get => Math.Round(total, 2);
        set => total = Math.Round(value, 2);
    }

    public DateTime Fecha { get; set; }

    public int? ProveedorID { get; set; }

    public virtual Proveedor? Proveedor { get; set; }

    public virtual ICollection<DetalleCompra?> DetallesCompra { get; set; } = new HashSet<DetalleCompra>();

    public bool Eliminado { get; set; } = false;
}

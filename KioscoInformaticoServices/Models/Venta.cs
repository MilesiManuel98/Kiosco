using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Venta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public virtual Cliente? Cliente { get; set; } = null!;
    public FormaDePagoEnum FormaPago { get; set; }
    public int ClienteId { get; set; }
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
    public bool Eliminado { get; set; } = false;
    public virtual ICollection<DetalleVenta> DetallesVenta { get; set; } = new HashSet<DetalleVenta>();

}

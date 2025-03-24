using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JCVL20250324.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de la bodega es obligatorio")]
    [StringLength(100, ErrorMessage = "El nombre de la bodega no puede exceder los 100 caracteres")]
    [Display(Name = "Bodegas")]
    public string WarehouseName { get; set; } = null!;

    [StringLength(500, ErrorMessage = "Las notas es demasiado larga")]
    [Required(ErrorMessage = "La notas de la bodega es obligatorio")]
    [Display(Name = "Notas")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

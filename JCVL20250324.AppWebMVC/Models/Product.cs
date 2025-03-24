using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JCVL20250324.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }



    [Display(Name = "Nombre Del Producto")]
    [Required(ErrorMessage = "Informacion Obligatorio")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = "Informacion Obligatorio")]
    public string? Description { get; set; }

    [Display(Name = "Precio")]
    [Required(ErrorMessage = "Precio Obligatorio")]
    public decimal Price { get; set; }

    [Display(Name = "Precio de Compra")]
    public decimal PurchasePrice { get; set; }


    [Display(Name = "Bodega")]
    [Required(ErrorMessage = "Informacion Obligatorio")]
    public int? WarehouseId { get; set; }

    [Display(Name = "Marca")]
    [Required(ErrorMessage = "Obligatorio seleccionar marca")]
    public int? BrandId { get; set; }

    public string? Notes { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}

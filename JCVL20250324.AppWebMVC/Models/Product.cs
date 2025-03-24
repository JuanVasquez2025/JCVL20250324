using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Agregado para Column y ForeignKey

namespace JCVL20250324.AppWebMVC.Models;

public partial class Product
{
    [Key] // Especifica que Id es la clave primaria
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indica que Id es autoincremental
    public int Id { get; set; }

    [Display(Name = "Nombre Del Producto")]
    [Required(ErrorMessage = "Informacion Obligatorio")]
    [StringLength(255, ErrorMessage = "El nombre del producto no puede exceder los 255 caracteres.")] // Agregado límite de longitud
    public string ProductName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = "Informacion Obligatorio")]
    [DataType(DataType.MultilineText)] 
    public string? Description { get; set; }

    [Display(Name = "Precio")]
    [Required(ErrorMessage = "Precio Obligatorio")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0.")] 
    [DataType(DataType.Currency)] 
    public decimal Price { get; set; }

    [Display(Name = "Precio de Compra")]
    [Range(0.00, double.MaxValue, ErrorMessage = "El precio de compra debe ser mayor o igual a 0.")] 
    [Required(ErrorMessage = "Precio de Venta Obligatorio")]
    public decimal PurchasePrice { get; set; }

    [Display(Name = "Bodega")]
    [Required(ErrorMessage = "Informacion Obligatorio")]

    public int? WarehouseId { get; set; }

    [Display(Name = "Marca")]
    [Required(ErrorMessage = "Obligatorio seleccionar marca")]

    public int? BrandId { get; set; }

    [DataType(DataType.MultilineText)] 
    public string? Notes { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
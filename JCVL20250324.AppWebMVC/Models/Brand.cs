using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JCVL20250324.AppWebMVC.Models;

public partial class Brand
{
    public int Id { get; set; }

    [Display(Name = "Marcas")]
    [Required(ErrorMessage = "Marca Obligatorio")]

    public string BrandName { get; set; } = null!;

    [Display(Name = "Pais")]
    [Required(ErrorMessage = "Pais Obligatorio")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

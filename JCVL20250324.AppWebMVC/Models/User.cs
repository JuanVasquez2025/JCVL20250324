using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCVL20250324.AppWebMVC.Models;

public partial class User
{
    public int Id { get; set; }


    [Required(ErrorMessage = "El campo es obligatorio es obligatorio.")]
    [Display(Name = "Nombre de Usuario")]
    public string Username { get; set; } = null!;


    [Required(ErrorMessage = "El Email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    [Display(Name = "Correo email")]
    public string Email { get; set; } = null!;

    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Ingresar Password")]
    [Required(ErrorMessage = "El password es obligatorio.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;




    [Required(ErrorMessage = "El role es obligatorio.")]
    [Display(Name = "Rol")]
    public string Role { get; set; } = null!;


    [StringLength(500, ErrorMessage = "Las notas es demasiado larga")]
    [Required(ErrorMessage = "La notas de la bodega es obligatorio")]
    [Display(Name = "Notas")]
    public string? Notes { get; set; }



    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "El password es obligatorio.")]

    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;





}

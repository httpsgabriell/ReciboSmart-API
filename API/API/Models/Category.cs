using System.ComponentModel.DataAnnotations;

namespace API.Models;

/// <summary>
/// possiveis categorias associadas ás fotografias
/// </summary>

public class Category {
    
    /// <summary>
    /// PK
    /// </summary>
    
    public int Id { get; set; }

    /// <summary>
    /// nome da categoria
    /// </summary>

    [StringLength(20)]
    [Display(Name = "Nome da Categoria")]
    [Required(ErrorMessage = "{0} é de preenchimento obrigatorio")]

    public required string Name { get; set; } = "";
    
    /*
     * relacionamentos 1-N
     */

    public required ICollection<Photography> ListOfPhotos { get; set; } = [];

}
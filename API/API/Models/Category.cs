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
    
    public required string Name { get; set; }
    
    /*
     * relacionamentos 1-N
     */
    
    public required ICollection<Photography> ListOfPhotos { get; set; }
    
}
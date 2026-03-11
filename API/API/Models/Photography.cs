namespace API.Models;

/// <summary>
/// objetos a serem vendidos na loja
/// </summary>

public class Photography {
    
    /// <summary>
    /// PK
    /// </summary>
    
    public int Id { get; set; }
    
    /// <summary>
    /// nome associado à fotografia
    /// </summary>
    
    public required string Title { get; set; }
    
    /// <summary>
    /// descrição (opcional) da fotografia
    /// </summary>
    
    public required string Description { get; set; }
    
    /// <summary>
    /// nome do ficheiro que contém a fotografia
    /// </summary>
    
    public required string File { get; set; }
    
    /// <summary>
    /// data em que a fotografia foi tirada
    /// </summary>
    
    public required DateTime Date { get; set; }
    
    /// <summary>
    /// preço de venda da fotografia
    /// </summary>
    
    public decimal Price { get; set; }
    
}
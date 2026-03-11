namespace API.Models;

/// <summary>
/// dados dos clientes da loja
/// </summary>

public class MyUser {
    
    /// <summary>
    /// PK
    /// </summary>
    
    public int Id { get; set; }
    
    /// <summary>
    /// nome do cliente
    /// </summary>
    
    public required string Name { get; set; }
    
    /// <summary>
    /// morada do cliente
    /// </summary>

    public required string Address { get; set; }
    
    /// <summary>
    /// codigo postal da morada do cliente
    /// </summary>
    
    public required string PostalCode { get; set; }
    
    /// <summary>
    /// país da morada do cliente
    /// </summary>
    
    public required string Country { get; set; }
    
    /// <summary>
    /// número de contribuinte
    /// </summary>
    
    public required string TaxNumber { get; set; }
    
    /// <summary>
    /// telemóvel do cliente
    /// </summary>

    public required string CellPhone { get; set; }
    
    /*
     * relacionamentos 1-N
     */
    
    /// <summary>
    /// lista das compras de fotografias efetuadas pelo cliente
    /// </summary>

    public required ICollection<Purchase> ListOfPurchases { get; set; }
    
}
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

/// <summary>
/// dados da compra de fotografia, por um utilizador
/// </summary>

public class Purchase {
    
    /// <summary>
    /// PK
    /// </summary>
    
    public int Id { get; set; }
    
    /// <summary>
    /// data da compra
    /// </summary>
    
    public DateTime Date { get; set; }
    
    /// <summary>
    /// estado (situação) em que se encontra a compra
    /// </summary>
    
    public State State { get; set; }
    
    /*
     * relacionamentos 1-N
     */
    
    [ForeignKey(nameof(Buyer))]
    public int BuyerFk { get; set; }
    
    /// <summary>
    /// cliente que efetuou uma compra
    /// </summary>
    
    public required MyUser Buyer { get; set; }
    
    /*
     * relacionamentos M-N
     */
    
    public required ICollection<Photography> ListOfPhotos { get; set; }
}

/// <summary>
/// possiveis estados associados a uma compra
/// </summary>

public enum State {
    Pending,
    Paid,
    Sent,
    Delivered,
    Closed
}
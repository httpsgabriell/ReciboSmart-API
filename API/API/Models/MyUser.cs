namespace API.Models;

public class MyUser {
    
    public int Id { get; set; }
    
    public required string Name { get; set; }

    public required string Address { get; set; }
    
    public required string PostalCode { get; set; }
    
    public required string Country { get; set; }
    
    public required string TaxNumber { get; set; }

    public required string CellPhone { get; set; }
    
}
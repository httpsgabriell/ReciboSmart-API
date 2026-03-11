namespace API.Models;

public class Photography {
    
    public int Id { get; set; }
    
    public required string Title { get; set; }
    
    public required string Description { get; set; }
    
    public required string File { get; set; }
    
    public required DateTime Date { get; set; }
    
    public decimal Price { get; set; }
    
}
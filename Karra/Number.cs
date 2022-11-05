using Microsoft.AspNetCore.Identity;

namespace Project;
public class Number
{
    public int Id { get; set; }
    public int KarraNumber { get; set; }
}

public class NumberValue 
{
    public int Id { get; set; }
    public string? Karra { get; set; }
    public int NumberId { get; set; }
}
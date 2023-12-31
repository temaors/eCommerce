namespace eCommerce.APIObjects;

public class APIUser
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int Type { get; set; }
    public int Currency { get; set; }
}
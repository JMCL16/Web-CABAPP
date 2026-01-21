namespace CABAPP.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? PasswordHash { get; set; }
}
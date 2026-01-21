using System.ComponentModel.DataAnnotations;

namespace CABAPP.Domain.Entities;

public class Jugador
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int TutorId { get; set; }
    public required Tutor Tutor { get; set; }

}
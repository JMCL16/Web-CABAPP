using CABAPP.Domain.Entities;
namespace CABAPP.Application.Interfaces;

public interface IJugadorRepository
{
    Task<List<Jugador>> GetAllJugadoresAsync();
    Task<Jugador?> GetJugadorByIdAsync(int id);
    Task AddJugadorAsync(Jugador jugador);
    Task SaveChangesAsync();
}
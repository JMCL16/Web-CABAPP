using CABAPP.Application.Interfaces;
using CABAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace CABAPP.Infraestructure.Repositories;

public class JugadorRepository : IJugadorRepository
{
    private readonly DbContext _context;

    public JugadorRepository(DbContext context)
    {
        _context = context;
    }
    public Task AddJugadorAsync(Jugador jugador)
    {
        throw new NotImplementedException();
    }

    public Task<List<Jugador>> GetAllJugadoresAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Jugador?> GetJugadorByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
using firstProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace firstProject.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    // DbSet<Game> property represents the collection of Game entities in the database
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();
}

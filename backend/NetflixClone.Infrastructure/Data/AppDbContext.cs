namespace NetflixClone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using NetflixClone.Domain.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options
    ) : base(options)
    {
    }


    // Isso aqui diz basicamente: Existe uma tabela chamada Users e outra chamada Movies, e cada uma delas 
    // tem os campos definidos nas classes User e Movie, respectivamente.

    public DbSet<User> Users { get; set; }

    public DbSet<Movie> Movies { get; set; }
}
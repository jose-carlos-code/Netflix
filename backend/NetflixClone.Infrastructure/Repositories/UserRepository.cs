using Microsoft.EntityFrameworkCore;
using NetflixClone.Domain.Entities;
using NetflixClone.Domain.Interfaces;
using NetflixClone.Infrastructure.Data;


namespace NetflixClone.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    // readonly indica que a variável não pode ser alterada após a sua inicialização
    // só pode ser atribuído no contrutor, depois é imutável
    private readonly AppDbContext _context;

    public UserRepositoy( AppDbContext context)
    {
        // Fazendo com que o atributo _context receba o context do contrutor
        _context = context;
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task CreateAsync(User user)
    {
        // Adiciona em uma transation, só salva se tudo der certo
        await _context.Users.AddAsync(user);

        // salva de fato no banco de dados
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

}
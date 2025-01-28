using IdeaAppCore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdeaAppCore.Models;

public class IdeaRepository : IIdeaRepository
{
    private readonly ApplicationDbContext _context;

    public IdeaRepository(ApplicationDbContext context)
    {
        this._context = context;
    }

    public async Task<Idea> AddIdea(Idea idea)
    {
        _context.Ideas.Add(idea);
        await _context.SaveChangesAsync();
        return idea; 
    }

    public async Task<List<Idea>> GetIdeas()
    {
        return await _context.Ideas.ToListAsync();
    }
}

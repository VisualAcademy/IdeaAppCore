using IdeaAppCore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdeaAppCore.Models;

public class IdeaRepository(ApplicationDbContext context) : IIdeaRepository
{
    public async Task<Idea> AddIdea(Idea idea)
    {
        context.Ideas.Add(idea);
        await context.SaveChangesAsync();
        return idea; 
    }

    public async Task<List<Idea>> GetIdeas()
    {
        return await context.Ideas.ToListAsync();
    }
}

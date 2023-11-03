using ManageSystemBlazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace ManageSystemBlazor.Data
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        private readonly NavigationManager _navigationManager;

        public GameService(ApplicationDbContext context, NavigationManager navigationManager)
        {
            _context = context;
            _navigationManager = navigationManager;
            _context.Database.EnsureCreated();
        }

        
    }
}

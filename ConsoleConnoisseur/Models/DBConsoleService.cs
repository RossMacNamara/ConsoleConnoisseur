using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class DBConsoleService : IConsoleRepository
    {
        private readonly AppDbContext _appDbContext;

        public DBConsoleService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Console> GetAllConsoles()
        {
            return _appDbContext.Consoles;
        }

        public Console GetConsoleById(int consoleId)
        {
            return _appDbContext.Consoles.FirstOrDefault(c => c.Id == consoleId);
        }
    }
}

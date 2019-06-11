using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public interface IConsoleRepository
    {
        IEnumerable<Console> GetAllConsoles();
        Console GetConsoleById(int consoleId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public interface IResponseRepository
    {
        void AddResponse(Response response);
    }
}

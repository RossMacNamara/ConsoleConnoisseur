using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class ResponseService : IResponseRepository
    {
        private readonly AppDbContext _appDbContext;

        public ResponseService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddResponse(Response response)
        {
            _appDbContext.Responses.Add(response);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Response> GetResponses()
        {
            return _appDbContext.Responses;
        }
    }
}

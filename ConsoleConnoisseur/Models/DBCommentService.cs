using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class DBCommentService : ICommentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DBCommentService(AppDbContext commentRepository)
        {
            _appDbContext = commentRepository;
        }
        public void AddComment(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Comment> GetComments()
        {
            return _appDbContext.Comments;
        }

    }
}

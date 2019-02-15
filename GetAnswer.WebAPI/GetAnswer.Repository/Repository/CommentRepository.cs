using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {

        }
         

        public Comment GetById(int id)
        {
            return _dbset.Where(x => x.AnsweId == id).FirstOrDefault();
        }
    }
}

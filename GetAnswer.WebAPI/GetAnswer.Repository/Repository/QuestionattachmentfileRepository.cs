using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class QuestionattachmentfileRepository : GenericRepository<QuestionAttachmentFile>, IQuestionattachmentfileRepository
    {
        public QuestionattachmentfileRepository(DbContext context) : base(context)
        {

        }
         

        public QuestionAttachmentFile GetById(int id)
        {
            return _dbset.Where(x => x.QuestionId == id).FirstOrDefault();
        }
    }
}

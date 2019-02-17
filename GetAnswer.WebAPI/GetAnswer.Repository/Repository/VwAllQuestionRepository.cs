using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class VwAllQuestionRepository : GenericRepository<VW_ALL_QUESTION>, IVwAllQuestionRepository
    {
        public VwAllQuestionRepository(DbContext context) : base(context)
        {

        }
         

        public VW_ALL_QUESTION GetById(int id)
        {
            return _dbset.Where(x => x.QuestionId == id).FirstOrDefault();
        }
    }
}

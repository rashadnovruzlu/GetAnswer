using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class QuestionadditionRepository : GenericRepository<QuestionAddition>, IQuestionadditionRepository
    {
        public QuestionadditionRepository(DbContext context) : base(context)
        {

        }
         

        public QuestionAddition GetById(int id)
        {
            return _dbset.Where(x => x.QuestionId == id).FirstOrDefault();
        }
    }
}

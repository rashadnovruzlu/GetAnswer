using GetAnswer.Helpers;
using GetAnswer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetAnswer.WebAPI.Controllers
{
    [RoutePrefix("api/question")]
    public class QuestionController : BaseApiController
    {
        IGetAnswerResolver _getAnswerResolver;
        IQuestionService _questionService;
        IVwAllQuestionService _viewQuestionService;


        public QuestionController()
        {
            _getAnswerResolver = new GetAnswerResolver();

            _questionService = _getAnswerResolver.Create<IQuestionService>();

            _viewQuestionService = _getAnswerResolver.Create<IVwAllQuestionService>();
        }

        [Route("count")]
        public IHttpActionResult GetQuestionCount()
        {
            var model = _questionService.Count();

            return Ok(model);
        }

        [Route("questions")]
        public IHttpActionResult GetAllQuestion(int page, int count, int? filterCategoryId = null)
        {
            var model = _viewQuestionService.GetAsIQueryable();

            if (filterCategoryId != null)
            {
                model = model.Where(x => x.CategoryId == filterCategoryId);
            }

            model = model.Take(count).Skip(page * count);

            return Ok(model.ToList());
        }
    }
}

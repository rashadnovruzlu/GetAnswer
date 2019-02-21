using GetAnswer.Helpers;
using GetAnswer.Service;
using GetAnswer.WebAPI.Facades;
using System.Web.Http;

namespace GetAnswer.WebAPI.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : BaseApiController
    {
        IGetAnswerResolver _getAnswerResolver;

        AspnetuserService _userService;

        IUserFacade _userFacade;

        public UserController()
        {
            _getAnswerResolver = new GetAnswerResolver();

            _userService = _getAnswerResolver.Create<AspnetuserService>();

            _userFacade = new UserFacade(_getAnswerResolver);
        }

        [Route("count")]
        public IHttpActionResult GetTagCount()
        {
            var model = _userService.Count();

            return Ok(model);
        }

        [Route("point")]
        public IHttpActionResult GetUserByPoint()
        {
            var model = _userFacade.GetUserByPoint();

            return Ok(model);
        }

        [Route("answer")]
        public IHttpActionResult GetUserByAnswer()
        {
            var model = _userFacade.GetUserByAnswer();

            return Ok(model);
        }

        [Route("question")]
        public IHttpActionResult GetUserByQuestion()
        {
            var model = _userFacade.GetUserByQuestion();

            return Ok(model);
        }

    }
}

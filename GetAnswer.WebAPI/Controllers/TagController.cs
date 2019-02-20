using GetAnswer.DTO;
using GetAnswer.Helpers;
using GetAnswer.Service;
using GetAnswer.WebAPI.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UtilityLibrary;

namespace GetAnswer.WebAPI.Controllers
{
    [RoutePrefix("api/tag")]
    public class TagController : BaseApiController
    {
        IGetAnswerResolver _getAnswerResolver;
        ITagService _tagService;
        IVwTagService _viewTagService;
        ITagFacade _tagFacade;

        public TagController()
        {
            _getAnswerResolver = new GetAnswerResolver();

            _tagService = _getAnswerResolver.Create<ITagService>();

            _viewTagService = _getAnswerResolver.Create<IVwTagService>();

            _tagFacade = new TagFacade(_getAnswerResolver);
        }


        [Route("count")]
        public IHttpActionResult GetTagCount()
        {
            var model = _tagService.GetMostUsedTag();

            return Ok(model);
        }

        [Route("alphabetic")]
        public IHttpActionResult GetTagAlphabetic(int page, int count)
        {
            var model= _viewTagService.GetAlphabetical().Take(count).Skip(page * count);

            return Ok(model);
        }

        [Route("popular")]
        public IHttpActionResult GetTagPopular()
        {
            return Ok(_viewTagService.GetPopular());
        }
    }
}

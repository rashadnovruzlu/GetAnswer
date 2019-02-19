using GetAnswer.DTO;
using GetAnswer.Helpers;
using GetAnswer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAnswer.WebAPI.Facades
{
    public interface ITagFacade
    {
        List<LetterTag> GetAlphabetical();
    }

    public class TagFacade : ITagFacade
    {
        IGetAnswerResolver _getAnswerResolver;
        ITagService _tagService;
        IQuestionService _questionService;

        public TagFacade(IGetAnswerResolver getAnswerResolver)
        {
            _getAnswerResolver = getAnswerResolver;
            _tagService = _getAnswerResolver.Create<ITagService>();
            _questionService = _getAnswerResolver.Create<IQuestionService>();
        }

        public List<LetterTag> GetAlphabetical()
        {
            return null;
        }
    }
}
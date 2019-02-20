using GetAnswer.DTO;
using GetAnswer.Helpers;
using GetAnswer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UtilityLibrary;

namespace GetAnswer.WebAPI.Facades
{
    public interface ITagFacade
    {
       
    }

    public class TagFacade : ITagFacade
    {
        IGetAnswerResolver _getAnswerResolver;
        ITagService _tagService;
        IVwTagService _viewTagService;

        public TagFacade(IGetAnswerResolver getAnswerResolver)
        {
            _getAnswerResolver = new GetAnswerResolver();

            _tagService = _getAnswerResolver.Create<ITagService>();

            _viewTagService = _getAnswerResolver.Create<IVwTagService>();
        }

        

        
    }
}
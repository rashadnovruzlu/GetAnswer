using GetAnswer.DTO;
using GetAnswer.Helpers;
using GetAnswer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAnswer.WebAPI.Facades
{
    public interface IUserFacade
    {
        List<NameCountDTO> GetUserByPoint();

        List<NameCountDTO> GetUserByQuestion();

        List<NameCountDTO> GetUserByAnswer();
    }

    public class UserFacade : IUserFacade
    {
        IGetAnswerResolver _getAnswerResolver;

        IAspnetuserService _userService;

        IUserinfoService _userinfoService;


        public UserFacade(IGetAnswerResolver getAnswerResolver)
        {
            _getAnswerResolver = getAnswerResolver;

            _userService = _getAnswerResolver.Create<IAspnetuserService>();

            _userinfoService = _getAnswerResolver.Create<IUserinfoService>();
        }

        public List<NameCountDTO> GetUserByPoint()
        {
            var model = from ur in _userService.GetAsIQueryable()
                        join ui in _userinfoService.GetAsIQueryable() on ur.Id equals ui.UserId
                        orderby ui.Point descending
                        select new NameCountDTO { Id = ur.Id, Name = ur.UserName, Count = ui.Point };

            return model.Take(6).ToList();

        }

        public List<NameCountDTO> GetUserByAnswer()
        {
            var model = from ur in _userService.GetAsIQueryable()
                        join ui in _userinfoService.GetAsIQueryable() on ur.Id equals ui.UserId
                        orderby ui.AnswerCount descending
                        select new NameCountDTO { Id = ur.Id, Name = ur.UserName, Count = ui.AnswerCount };

            return model.Take(6).ToList();
        }



        public List<NameCountDTO> GetUserByQuestion()
        {
            var model = from ur in _userService.GetAsIQueryable()
                        join ui in _userinfoService.GetAsIQueryable() on ur.Id equals ui.UserId
                        orderby ui.QuestionCount descending
                        select new NameCountDTO { Id = ur.Id, Name = ur.UserName, Count = ui.QuestionCount };

            return model.Take(6).ToList();
        }
    }
}
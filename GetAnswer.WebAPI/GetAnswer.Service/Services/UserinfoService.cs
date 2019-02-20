using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using GetAnswer.DTO;

namespace GetAnswer.Service
{
    public class UserinfoService : EntityService<UserInfo>, IUserinfoService
    {
        IUnitOfWork _unitOfWork;
        IUserinfoRepository _userinfoRepository;

        public UserinfoService(IUnitOfWork unitOfWork, IUserinfoRepository userinfoRepository)
            : base(unitOfWork, userinfoRepository)
        {
            _unitOfWork = unitOfWork;
            _userinfoRepository = userinfoRepository;
        }

        public UserInfo GetById(string Id)
        {
            return _userinfoRepository.GetById(Id);
        }

        public List<NameCountDTO> GetTopUserByPoint()
        {
            return _userinfoRepository.GetAsIQueryable().OrderBy(x => x.Point)
                   .Select(x => new NameCountDTO { Id = x.UserId, Name = x.AspNetUser.UserName, Count = x.Point }).Take(5).ToList();
        }

        public List<NameCountDTO> GetTopUserByAnswer()
        {
            return _userinfoRepository.GetAsIQueryable().OrderBy(x => x.AnswerCount)
                   .Select(x => new NameCountDTO { Id = x.UserId, Name = x.AspNetUser.UserName, Count = x.AnswerCount }).Take(5).ToList();
        }

        public List<NameCountDTO> GetTopUserByQuestion()
        {
            return _userinfoRepository.GetAsIQueryable().OrderBy(x => x.QuestionCount)
                   .Select(x => new NameCountDTO { Id = x.UserId, Name = x.AspNetUser.UserName, Count = x.QuestionCount }).Take(5).ToList();
        }
    }
}

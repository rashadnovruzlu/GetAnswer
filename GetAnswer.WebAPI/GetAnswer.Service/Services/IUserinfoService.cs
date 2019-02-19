using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;
using GetAnswer.DTO;

namespace GetAnswer.Service
{
    public interface IUserinfoService : IEntityService<UserInfo>
    {
        UserInfo GetById(string Id);
        List<NameCountDTO> GetTopUserByPoint();
        List<NameCountDTO> GetTopUserByAnswer();
        List<NameCountDTO> GetTopUserByQuestion();
    }
}

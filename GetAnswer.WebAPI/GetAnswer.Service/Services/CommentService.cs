using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class CommentService : EntityService<Comment>, ICommentService
    {
        IUnitOfWork _unitOfWork;
        ICommentRepository _commentRepository;

        public CommentService(IUnitOfWork unitOfWork, ICommentRepository commentRepository)
            : base(unitOfWork, commentRepository)
        {
            _unitOfWork = unitOfWork;
            _commentRepository = commentRepository;
        }
 
        public Comment GetById(int Id)
        {
            return _commentRepository.GetById(Id);
        }

        
    }
}

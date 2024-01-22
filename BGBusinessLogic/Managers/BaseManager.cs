using AutoMapper;
using BGBusinessLogic.Interfaces;
using BGDataLayer.DAL.Interfaces;

namespace BGBusinessLogic.Managers
{
    public class BaseManager : IBaseManager
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public BaseManager(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}

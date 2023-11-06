using BGDataLayer.DAL.Interfaces;

namespace BGDataLayer.DAL
{
    public class BaseRepository : IBaseRepository
    {
        protected UnitOfWork unitOfWork;

        protected BGContext BGContext
        {
            get
            {
                return unitOfWork.bgContext;
            }
        }
    }
}

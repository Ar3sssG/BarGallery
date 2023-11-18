using BGDataLayer.DAL.Interfaces;

namespace BGDataLayer.DAL
{
    public class UserRepository : BaseRepository,IUserRepository
    {
        public UserRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //code
    }
}

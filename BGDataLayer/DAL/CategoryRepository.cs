using BGDataLayer.DAL.Interfaces;

namespace BGDataLayer.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}

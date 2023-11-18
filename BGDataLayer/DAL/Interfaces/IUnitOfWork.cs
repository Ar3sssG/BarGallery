
namespace BGDataLayer.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}

using BGDataLayer.DAL.Contexts;
using BGDataLayer.DAL.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace BGDataLayer.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        //private IMemoryCache _memoryCache;
        public UnitOfWork(BGContext dbContext/*,IMemoryCache memoryCache*/)
        {
            bgContext = dbContext;
            //_memoryCache = memoryCache;
        }

        public BGContext bgContext { get; }
        //public IMemoryCache MemoryCache => _memoryCache;

        #region Repositories

        private IUserRepository _userRepository;
        public IUserRepository UserRepository => _userRepository != null ? _userRepository : new UserRepository(this);

        private ICategoryRepository _categoryRepository;
        public ICategoryRepository CategoryRepository => _categoryRepository != null ? _categoryRepository : new CategoryRepository(this);

        private IProductRepository _productRepository;
        public IProductRepository ProductRepository => _productRepository != null ? _productRepository : new ProductRepository(this);

        #endregion
    }
}

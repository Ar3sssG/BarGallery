using BGDataLayer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BGDataLayer.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private IMemoryCache _memoryCache;
        public UnitOfWork(BGContext dbContext, IMemoryCache memoryCache)
        {
            bgContext = dbContext;
            _memoryCache = memoryCache;
        }

        public BGContext bgContext { get; }
        public IMemoryCache MemoryCache => _memoryCache;

        #region Repositories
        private IUserRepository userRepository;
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;


        public IUserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(this);
                }
                return userRepository;
            }
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new CategoryRepository(this);
                }
                return categoryRepository;
            }
        }
        public IProductRepository ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new ProductRepository(this);
                }
                return productRepository;
            }
        }

        #endregion
    }
}

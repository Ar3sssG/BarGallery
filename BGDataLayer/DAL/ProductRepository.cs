using BGDataLayer.DAL;
using BGDataLayer.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGDataLayer.DAL
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //public async Task<List<ProductViewModel>> GetProductsByCategoryID(int categoryID)
        //{
        //    //return await (from p in BGContext.Products
        //    //              join sc in BGContext.Categories on p.
        //    //              where p.cat)
        //    return new List<ProductViewModel>();
        //}
    }
}

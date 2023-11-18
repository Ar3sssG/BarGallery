using BGDataLayer.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGDataLayer.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //public async Task<List<CategoryViewModel>> GetCategories()
        //{
        //    var categoryList = new List<CategoryViewModel>();
        //    var cacheKey = MemoryCacheHelper.CreateCacheKey(MemoryCacheHelper.MemoryCacheKeys.Categories);

        //    if (!unitOfWork.MemoryCache.TryGetValue(cacheKey, out categoryList))
        //    {
        //        categoryList = await (from c in BGContext.Categories
        //                              where c.IsEnabled
        //                              select new CategoryViewModel
        //                              {
        //                                  ID = c.ID,
        //                                  Name = c.Name,
        //                              }).ToListAsync();

        //        if (categoryList.Count() != 0)
        //            unitOfWork.MemoryCache.Set(cacheKey, categoryList, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(MemoryCacheConstants.TimeUnitFive)));
        //    }
        //    //to avoid reference returned object change in outer code
        //    List<CategoryViewModel> safeModel = categoryList.Select(c => new CategoryViewModel
        //    {
        //        ID = c.ID,
        //        Name = c.Name,
        //    }).ToList();

        //    return safeModel;
        //}

        //public async Task<List<CategoryCombinedViewModel>> GetCategoriesAndSubcategories()
        //{
        //    var combinedCategoryList = new List<CategoryCombinedViewModel>();
        //    var cacheKey = MemoryCacheHelper.CreateCacheKey(MemoryCacheHelper.MemoryCacheKeys.Categories, MemoryCacheHelper.MemoryCacheKeys.SubCategories);

        //    if (!unitOfWork.MemoryCache.TryGetValue(cacheKey, out combinedCategoryList))
        //    {
        //        combinedCategoryList = await (from c in BGContext.Categories
        //                                      join sc in BGContext.SubCategories on c.ID equals sc.CategoryID
        //                                      where c.IsEnabled && sc.IsEnabled
        //                                      select new CategoryCombinedViewModel
        //                                      {
        //                                          ID = c.ID,
        //                                          Name = c.Name,
        //                                          Description = c.Description,
        //                                          Subcategories = c.SubCategories.Select(sc => new SubCategoryViewModel
        //                                          {
        //                                              ID = sc.ID,
        //                                              CategoryID = sc.CategoryID,
        //                                              Name = sc.Name,
        //                                              Description = sc.Description
        //                                          }).ToList(),
        //                                      }).ToListAsync();

        //        if (combinedCategoryList.Count() != 0)
        //            unitOfWork.MemoryCache.Set(cacheKey, combinedCategoryList, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(MemoryCacheConstants.TimeUnitFive)));
        //    }

        //    List<CategoryCombinedViewModel> safeModel = combinedCategoryList.Select(cc => new CategoryCombinedViewModel
        //    {
        //        ID = cc.ID,
        //        Name = cc.Name,
        //        Description = cc.Description,
        //        Subcategories = cc.Subcategories,
        //    }).ToList();

        //    return combinedCategoryList;
        //}
    }
}

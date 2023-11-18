
namespace BGDataLayer.Helpers
{
    public static class MemoryCacheHelper
    {
        public enum MemoryCacheKeys
        {
            Categories,
            SubCategories,
            Products
        }
        public static string CreateCacheKey(params object[] values)
        {
            return string.Join("_", values);
        }
    }
}

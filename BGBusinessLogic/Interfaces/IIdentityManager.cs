using BGCommon.Models.Manager;
using BGDataLayer.Identity;

namespace BGBusinessLogic.Interfaces
{
    public interface IIdentityManager
    {
        Task AddRefreshToken(RefreshTokenModel model);
        Task<User> GetUserByRefreshToken(string refreshToken);
    }
}

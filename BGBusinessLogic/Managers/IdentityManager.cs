using AutoMapper;
using BGBusinessLogic.Interfaces;
using BGCommon.Constants;
using BGCommon.Models.Manager;
using BGDataLayer.DAL.Entities;
using BGDataLayer.DAL.Interfaces;
using BGDataLayer.Identity;
using Microsoft.EntityFrameworkCore;

namespace BGBusinessLogic.Managers
{
    public class IdentityManager : BaseManager, IIdentityManager
    {
        public IdentityManager(IUnitOfWork unitOfWork,IMapper mapper) : base(unitOfWork,mapper)
        {
        }

        public async Task AddRefreshToken(RefreshTokenModel model)
        {
            //check if user have token delete
            var oldToken = await _unitOfWork.RefreshTokenRepository.Get(x => x.UserId == model.UserId).FirstOrDefaultAsync();
            if (oldToken != null)
            {
                _unitOfWork.RefreshTokenRepository.Delete(oldToken);
            }

            RefreshToken refreshToken = new RefreshToken
            {
                UserId = model.UserId,
                Token = model.Token,
                ExpireDate = model.ExpireDate,
                CreationDate = DateTime.UtcNow,
            };

            await _unitOfWork.RefreshTokenRepository.AddAsync(refreshToken);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<User> GetUserByRefreshToken(string refreshToken)
        {
            var token = await _unitOfWork.RefreshTokenRepository.Get(x => x.Token == refreshToken).Include(x => x.User).FirstOrDefaultAsync();

            if (token == null)
            {
                throw new Exception(AuthErrorConstants.InvalidRefreshToken);
            }

            if (token.ExpireDate < DateTime.UtcNow)
            {
                throw new Exception(AuthErrorConstants.ExpiredRefreshToken);
            }

            User user = token.User;

            return user;
        }
    }
}

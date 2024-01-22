using BGDataLayer.DAL;
using BGDataLayer.DAL.DBContext;
using BGDataLayer.DAL.Entities;
using BGDataLayer.DAL.Interfaces;
using Npgsql;

namespace ASDataLayer.DAL
{
    public class RefreshTokenRepository : BaseRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(NpgsqlTransaction transaction,BGContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

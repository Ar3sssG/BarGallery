using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BGCommon.Helpers
{
    public static class AuthOptions
    {
        public const string ISSUER = "GQR";
        public const string AUDIENCE = "GQRClient";
        const string KEY = "mysupersecret_secretkey!123";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}

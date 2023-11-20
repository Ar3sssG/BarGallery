
namespace BGCommon.Models.API.Response.Auth
{
    public class AuthResponseModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Username { get; set; }
    }

    public class UnauthorizedResponseModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}

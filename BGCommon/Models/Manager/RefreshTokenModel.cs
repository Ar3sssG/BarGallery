﻿
namespace BGCommon.Models.Manager
{
    public class RefreshTokenModel
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}

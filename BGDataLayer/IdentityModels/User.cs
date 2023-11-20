using Microsoft.AspNetCore.Identity;
using System;

namespace BGDataLayer.IdentityModels
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

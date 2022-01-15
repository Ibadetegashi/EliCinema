using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Data.Static
{
    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";
        public const string Super = "Super";
        public const string Both = Admin + "," + Super;
    }
}

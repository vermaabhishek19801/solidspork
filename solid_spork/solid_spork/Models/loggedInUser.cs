using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solid_spork
{
    public static class LoggedInUser
    {
        public static int UserId { get; set; }
        public static string Email { get; set; }
        public static int UserType { get; set; }
    }
}
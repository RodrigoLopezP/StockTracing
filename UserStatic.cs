using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing
{
    public static class UserStatic
    {
        public static int userId { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static bool isAdmin{ get; set; }
        public static int permissionID { get; set; }
        public static string permissionName { get; set; } 
    }
}

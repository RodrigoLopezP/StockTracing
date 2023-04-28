using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.DAL.DTO
{
    public class UserDetailDTO
    {
        public int UserId { get; set; }
        public string Username{ get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? UserDeletedDate { get; set; }

    }
}

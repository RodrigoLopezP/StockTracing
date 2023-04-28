using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.DAL.DTO
{
    public class UserDTO
    {
        public List<UserDetailDTO> users { get; set; }
        public List<PermissionDetailDTO> permissions { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;

namespace StockTracing.DAL.DTO
{
    class PermissionDTO
    {
        public List<PermissionDetailDTO> Permissions { get; set; }
    }
}

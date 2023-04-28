using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;

namespace StockTracing.DAL.DTO
{
    public class SalesDTO
    {
        public List<CategoryDetailDTO> Category { get; set; }
        public List<CustomerDetailDTO> Customer{ get; set; }
        public List<SalesDetailDTO> Sales { get; set; }
        public List<ProductDetailDTO> Products { get; set; }
        public List<UserDetailDTO> Users { get; set; }
    }
}

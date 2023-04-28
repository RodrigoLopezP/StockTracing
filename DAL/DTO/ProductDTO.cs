using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.DAL.DTO
{
    public class ProductDTO
    {
        public List<ProductDetailDTO> products { get; set; }
        public List<CategoryDetailDTO> categories { get; set; }
    }
}

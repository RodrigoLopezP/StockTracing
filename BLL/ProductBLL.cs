using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockTracing.DAL;
using StockTracing.DAL.DAO;
using StockTracing.DAL.DTO;

namespace StockTracing.BLL
{
    public class ProductBLL : IBLL<ProductDetailDTO, ProductDTO>
    {
        CategoryDAO categDao = new CategoryDAO();
        ProductDAO prodDao = new ProductDAO();
        SalesDAO saleDao = new SalesDAO();
        public bool Delete(ProductDetailDTO entity)
        {
            SALE saleToBeDelete = new SALE();
            saleToBeDelete.ProductID = entity.productID;
            saleDao.Delete(saleToBeDelete);

            PRODUCT prodToBeDeleted = new PRODUCT();
            prodToBeDeleted.ID = entity.productID;
            prodDao.Delete(prodToBeDeleted);

            return true;
        }

        public bool GetBack(ProductDetailDTO entity)
        { 
            return prodDao.GetBack(entity.productID);
        }

        public bool Insert(ProductDetailDTO entity)
        {
            PRODUCT productDB = new PRODUCT();
            productDB.ProductName = entity.productName;
            productDB.CategoryID = entity.categoryID;
            productDB.Price = entity.price;
            productDB.isDeleted = false;

            return prodDao.Insert(productDB);
        }

        public ProductDTO Select()
        {
            ProductDTO dto = new ProductDTO();
            dto.categories = categDao.Select();
            dto.products = prodDao.Select();
            return dto;
        }

        public bool Update(ProductDetailDTO entity)
        {
            PRODUCT product = new PRODUCT();
 
            product.ID = entity.productID;
            product.Price = entity.price;
            product.ProductName = entity.productName;
            product.CategoryID = entity.categoryID;
            product.StockAmount = entity.stockAmount;

            return prodDao.Update(product);
         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;
using StockTracing.DAL;
using StockTracing.DAL.DAO;

namespace StockTracing.BLL
{
    public class CategoryBLL:IBLL<CategoryDetailDTO,CategoryDTO>
    {
        CategoryDAO catDao = new CategoryDAO();
        ProductDAO prodDao = new ProductDAO();
        SalesDAO saleDao = new SalesDAO();
        public bool Delete(CategoryDetailDTO entity)
        {
            SALE saleToBeDelete = new SALE();
            saleToBeDelete.CategoryID = entity.ID;
            saleDao.Delete(saleToBeDelete);

            PRODUCT prodToBeDelete = new PRODUCT();
            prodToBeDelete.CategoryID = entity.ID;
            prodDao.Delete(prodToBeDelete);

            CATEGORY catToBeDelete = new CATEGORY();
            catToBeDelete.ID = entity.ID;
            catDao.Delete(catToBeDelete);

            return true;
        }

        public bool GetBack(CategoryDetailDTO entity)
        {
            return catDao.GetBack(entity.ID);
        }

        public bool Insert(CategoryDetailDTO entity)
        {
            CATEGORY category = new CATEGORY();
            category.CategoryName = entity.CategoryName;
            return (catDao.Insert(category));
        }

        public CategoryDTO Select()
        {
            CategoryDTO dto = new CategoryDTO();
            dto.category = catDao.Select();
            return dto;
        }

        public bool Update(CategoryDetailDTO entity)
        {
            CATEGORY cat_DB = new CATEGORY();
            cat_DB.ID = entity.ID;
            cat_DB.CategoryName = entity.CategoryName;

            return catDao.Update(cat_DB);
        }
    }
}

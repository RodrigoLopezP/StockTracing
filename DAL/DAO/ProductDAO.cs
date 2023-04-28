using StockTracing.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.DAL.DAO
{
    public class ProductDAO : StockContext, IDAO<PRODUCT, ProductDetailDTO>
    {
        public bool Delete(PRODUCT entity)
        {
            #region DELETE using product ID
            if (entity.ID != 0)
            {
                PRODUCT prodInDb = db.PRODUCTs.First(x => x.ID == entity.ID);
                if (prodInDb.isDeleted == false)
                {
                    prodInDb.isDeleted = true;
                    prodInDb.DeletedDate = DateTime.Today;
                }
                else
                {
                    db.PRODUCTs.Remove(prodInDb);
                }
            }
            #endregion
            #region DELETE using category ID
            else if (entity.CategoryID != 0)
            {
                List <PRODUCT> prodsInDb = db.PRODUCTs.Where(x => x.CategoryID == entity.CategoryID && x.isDeleted==false).ToList();

                foreach (var item in prodsInDb)
                {
                    item.isDeleted = true;
                    item.DeletedDate = DateTime.Today;
                }
            }
            #endregion
            db.SaveChanges();
            return true;
        }

        public bool GetBack(int ID)
        {
            try
            {
                PRODUCT prodInDb = db.PRODUCTs.First(x => x.ID == ID);
                prodInDb.DeletedDate = null;
                prodInDb.isDeleted = false;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(PRODUCT entity)
        {
            try
            {
                db.PRODUCTs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ProductDetailDTO> Select()
        {
            try
            {
                List<ProductDetailDTO> productsList = new List<ProductDetailDTO>();
                var list = (from p in db.PRODUCTs.Where(x=>x.isDeleted==false)
                            join c in db.CATEGORies on p.CategoryID equals c.ID
                            select new
                            {
                                productName = p.ProductName,
                                categoryName= c.CategoryName,
                                stockAmount = p.StockAmount,
                                price       = p.Price,
                                productID   = p.ID,
                                categoryID  =c.ID,
                                isCategoryDeleted = c.isDeleted
                            }).ToList();
                foreach (var item in list)
                {
                    ProductDetailDTO row = new ProductDetailDTO();
                    row.productName = item.productName ;
                    row.categoryName = item.categoryName;
                    row.stockAmount = item.stockAmount ;
                    row.price = item.price       ;
                    row.productID = item.productID   ;
                    row.categoryID = item.categoryID;
                    row.isCategoryDeleted = item.isCategoryDeleted;
                    productsList.Add(row);
                }

                return productsList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal List<ProductDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<ProductDetailDTO> productsList = new List<ProductDetailDTO>();
                var list = (from p in db.PRODUCTs.Where(x => x.isDeleted == isDeleted)
                            join c in db.CATEGORies on p.CategoryID equals c.ID
                            select new
                            {
                                productName = p.ProductName,
                                categoryName = c.CategoryName,
                                stockAmount = p.StockAmount,
                                price = p.Price,
                                productID = p.ID,
                                categoryID = c.ID,
                                isCategoryDeleted= c.isDeleted
                            }).ToList();
                foreach (var item in list)
                {
                    ProductDetailDTO row = new ProductDetailDTO();
                    row.productName = item.productName;
                    row.categoryName = item.categoryName;
                    row.stockAmount = item.stockAmount;
                    row.price = item.price;
                    row.productID = item.productID;
                    row.categoryID = item.categoryID;
                    row.isCategoryDeleted = item.isCategoryDeleted;
                    productsList.Add(row);
                }

                return productsList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(PRODUCT entity)
        {
            try
            {
                PRODUCT product_db = db.PRODUCTs.First(x => x.ID == entity.ID);

                if (entity.CategoryID == 0)
                {
                    product_db.StockAmount = entity.StockAmount;
                }
                else
                {
                    product_db.ProductName = entity.ProductName;
                    product_db.CategoryID = entity.CategoryID;
                    product_db.Price = entity.Price;
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

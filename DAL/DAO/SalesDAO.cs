using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;
namespace StockTracing.DAL.DAO
{
    // public class ProductDAO : StockContext, IDAO<PRODUCT, ProductDetailDTO>

    class SalesDAO : StockContext, IDAO<SALE, SalesDetailDTO>
    {
        public bool Delete(SALE entity)
        {
            try
            {
                #region Delete by saleID
                if (entity.ID != 0)
                {
                    SALE saleInDB = db.SALES.First(x => x.ID == entity.ID);
                    if (saleInDB.isDeleted == false)
                    {
                        saleInDB.isDeleted = true;
                        saleInDB.DeletedDate = DateTime.Today;
                    }
                    else
                    {
                        db.SALES.Remove(saleInDB);
                    }
                }
                #endregion
                #region Delete by product ID
                else if(entity.ProductID!=0)
                {
                    List<SALE> salesInDB = db.SALES.Where(x => x.ProductID == entity.ProductID && x.isDeleted == false).ToList();
                    foreach (var item in salesInDB)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                    }
                }
                #endregion
                #region Delete by customerID
                else if (entity.CustomerID!=0)
                {
                    List<SALE> salesInDB = db.SALES.Where(x => x.CustomerID == entity.CustomerID).ToList();
                    foreach (var item in salesInDB)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                    }
                }
                #endregion
                #region Delete by Category ID

                else if (entity.CategoryID != 0)
                {
                    List<SALE> salesInDB = db.SALES.Where(x => x.CategoryID == entity.CategoryID && x.isDeleted == false).ToList();
                    foreach (var item in salesInDB)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                    }
                }
                #endregion
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool GetBack(int ID)
        {
            try
            {
                SALE saleInDb = db.SALES.First(x => x.ID == ID);
                saleInDb.DeletedDate = null;
                saleInDb.isDeleted =false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Insert(SALE entity)
        {
            try
            {
                db.SALES.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<SalesDetailDTO> Select()
        {
            try
            {
                List<SalesDetailDTO> salesList = new List<SalesDetailDTO>();
                var list = (from s in db.SALES.Where(x=>x.isDeleted==false)
                            join p in db.PRODUCTs on s.ProductID equals p.ID
                            join cu in db.CUSTOMERs on s.CustomerID equals cu.ID
                            join ca in db.CATEGORies on s.CategoryID equals ca.ID
                            select new
                            {
                                CustomerName    = cu.CustomerName,
                                ProductName     = p.ProductName,
                                CategoryName    = ca.CategoryName,
                                CustomerID      = cu.ID,
                                ProductID       = p.ID,
                                CategoryID      = ca.ID,
                                SalesAmount     = s.ProductSalesAmount,
                                Price           = p.Price,
                                SalesDate       = s.SalesDate,
                                StockAmount     = p.StockAmount,
                                SalesID         = s.ID,
                                isProductDeleted=p.isDeleted,
                                isCategoryDeleted=ca.isDeleted,
                                isCustomerDeleted=cu.isDeleted
                            }).OrderByDescending(x=>x.SalesDate).ToList();

                foreach (var item in list)
                {
                    SalesDetailDTO rowPr    =   new SalesDetailDTO();
                    rowPr.CustomerName      =   item.CustomerName ;  
                    rowPr.ProductName       =   item.ProductName  ;  
                    rowPr.CategoryName      =   item.CategoryName ;  
                    rowPr.CustomerID        =   item.CustomerID   ;  
                    rowPr.ProductID         =   item.ProductID    ;  
                    rowPr.CategoryID        =   item.CategoryID   ;  
                    rowPr.SalesAmount       =   item.SalesAmount  ;  
                    rowPr.Price             =   item.Price        ;  
                    rowPr.SalesDate         =   item.SalesDate    ;  
                    rowPr.StockAmount       =   item.StockAmount  ;
                    rowPr.SalesID           =   item.SalesID     ;
                    rowPr.isCategoryDeleted =   item.isCategoryDeleted;
                    rowPr.isProductDeleted  =   item.isProductDeleted;
                    rowPr.isCustomerDeleted =   item.isCustomerDeleted;
                    salesList.Add(rowPr);
                }

                return salesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<SalesDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<SalesDetailDTO> salesList = new List<SalesDetailDTO>();
                var list = (from s in db.SALES.Where(x => x.isDeleted == isDeleted)
                            join p in db.PRODUCTs on s.ProductID equals p.ID
                            join cu in db.CUSTOMERs on s.CustomerID equals cu.ID
                            join ca in db.CATEGORies on s.CategoryID equals ca.ID
                            select new
                            {
                                CustomerName = cu.CustomerName,
                                ProductName = p.ProductName,
                                CategoryName = ca.CategoryName,
                                CustomerID = cu.ID,
                                ProductID = p.ID,
                                CategoryID = ca.ID,
                                SalesAmount = s.ProductSalesAmount,
                                Price = p.Price,
                                SalesDate = s.SalesDate,
                                StockAmount = p.StockAmount,
                                SalesID = s.ID,
                                isProductDeleted = p.isDeleted,
                                isCategoryDeleted = ca.isDeleted,
                                isCustomerDeleted = cu.isDeleted
                            }).OrderByDescending(x => x.SalesDate).ToList();

                foreach (var item in list)
                {
                    SalesDetailDTO rowPr = new SalesDetailDTO();
                    rowPr.CustomerName = item.CustomerName;
                    rowPr.ProductName = item.ProductName;
                    rowPr.CategoryName = item.CategoryName;
                    rowPr.CustomerID = item.CustomerID;
                    rowPr.ProductID = item.ProductID;
                    rowPr.CategoryID = item.CategoryID;
                    rowPr.SalesAmount = item.SalesAmount;
                    rowPr.Price = item.Price;
                    rowPr.SalesDate = item.SalesDate;
                    rowPr.StockAmount = item.StockAmount;
                    rowPr.SalesID = item.SalesID;
                    rowPr.isCategoryDeleted = item.isCategoryDeleted;
                    rowPr.isProductDeleted = item.isProductDeleted;
                    rowPr.isCustomerDeleted = item.isCustomerDeleted;
                    salesList.Add(rowPr);
                }

                return salesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Update(SALE entity)
        {
            try
            {
                SALE saleOld = db.SALES.First(x => x.ID == entity.ID);
                saleOld.ProductSalesAmount = entity.ProductSalesAmount;
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

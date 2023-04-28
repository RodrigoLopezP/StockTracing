using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;
using StockTracing.DAL.DAO;
using StockTracing.DAL;

namespace StockTracing.BLL
{
    public class SalesBLL : IBLL<SalesDetailDTO, SalesDTO>
    {
        CategoryDAO CatDAO = new CategoryDAO();
        CustomerDAO CustDAO = new CustomerDAO();
        SalesDAO SalDAO = new SalesDAO();
        ProductDAO ProdDAO = new ProductDAO();
        UserDAO UserDao = new UserDAO();
        public bool Delete(SalesDetailDTO entity)
        {
            SALE saleToBeDelete = new SALE();
            saleToBeDelete.ID = entity.SalesID;
            saleToBeDelete.CustomerID = entity.CustomerID;
            saleToBeDelete.ProductID = entity.ProductID;
            SalDAO.Delete(saleToBeDelete);

            PRODUCT prodToBeUpdate = new PRODUCT();
            prodToBeUpdate.ID = entity.ProductID;
            prodToBeUpdate.StockAmount = entity.SalesAmount + entity.StockAmount; //entity.StockAmount è uguale a prodToBeUpdate.StockAmount
            ProdDAO.Update(prodToBeUpdate);
            return true;
        }

        public bool GetBack(SalesDetailDTO entity)
        {
            PRODUCT prodToBeUpdate = new PRODUCT();
            prodToBeUpdate.ID = entity.ProductID;
            prodToBeUpdate.StockAmount = entity.StockAmount - entity.SalesAmount;
            ProdDAO.Update(prodToBeUpdate);
            
            SalDAO.GetBack(entity.SalesID);
            return true;
        }

        public bool Insert(SalesDetailDTO entity)
        {
            SALE saleDB = new SALE();
            saleDB.CategoryID = entity.CategoryID;
            saleDB.CustomerID = entity.CustomerID;
            saleDB.ProductID = entity.ProductID;
            saleDB.ProductSalesAmount = entity.SalesAmount;
            saleDB.SalesDate = entity.SalesDate;
            saleDB.ProductSalesPrice = entity.Price;

            PRODUCT produDB = new PRODUCT();
            produDB.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            produDB.StockAmount = temp;
            ProdDAO.Update(produDB);

            return SalDAO.Insert(saleDB);
        }

        public SalesDTO Select(bool isDeleted)
        {
            SalesDTO sales = new SalesDTO();
            sales.Customer = CustDAO.Select(true);
            sales.Category = CatDAO.Select(true);
            sales.Sales = SalDAO.Select(true);
            sales.Products = ProdDAO.Select(true);
            sales.Users = UserDao.Select(true);
            return sales;
        }

        public SalesDTO Select()
        {
            SalesDTO sales = new SalesDTO();
            sales.Customer = CustDAO.Select();
            sales.Category = CatDAO.Select();
            sales.Sales = SalDAO.Select();
            sales.Products = ProdDAO.Select();
            sales.Users = UserDao.Select();
            return sales;
        }

        public bool Update(SalesDetailDTO entity)
        {
            SALE saleDB = new SALE();
            saleDB.ID = entity.SalesID;
            saleDB.ProductSalesAmount = entity.SalesAmount;
            SalDAO.Update(saleDB);

            PRODUCT productDB = new PRODUCT();
            productDB.ID = entity.ProductID;
            productDB.StockAmount = entity.StockAmount;
            ProdDAO.Update(productDB);

            return true;



        }
    }
}

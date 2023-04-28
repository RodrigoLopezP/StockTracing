using StockTracing.DAL;
using StockTracing.DAL.DAO;
using StockTracing.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.BLL
{
    public class CustomerBLL : IBLL<CustomerDetailDTO, CustomerDTO>
    {
        CustomerDAO custDao = new CustomerDAO();
        SalesDAO saleDao = new SalesDAO();

        public bool Delete(CustomerDetailDTO entity)
        {
            CUSTOMER custToDelete = new CUSTOMER();
            custToDelete.ID = entity.ID;
            custDao.Delete(custToDelete);

            SALE salesToDelete = new SALE();
            salesToDelete.CustomerID= entity.ID;
            saleDao.Delete(salesToDelete);
            return true;
        }

        public bool GetBack(CustomerDetailDTO entity)
        {
            return custDao.GetBack(entity.ID);
        }

        public bool Insert(CustomerDetailDTO entity)
        {
            CUSTOMER customerDB = new CUSTOMER();
            customerDB.CustomerName = entity.Name;
            return custDao.Insert(customerDB);
        }

        public CustomerDTO Select()
        {
            CustomerDTO customerSelectTable = new CustomerDTO();
            customerSelectTable.Customer = custDao.Select();

            return customerSelectTable;
        }

        public bool Update(CustomerDetailDTO entity)
        {
            CUSTOMER customerDB = new CUSTOMER();
            customerDB.ID = entity.ID;
            customerDB.CustomerName = entity.Name;

            return custDao.Update(customerDB);
        }
    }
}

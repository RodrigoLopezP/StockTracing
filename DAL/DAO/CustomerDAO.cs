using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;

namespace StockTracing.DAL.DAO
{
    public class CustomerDAO : StockContext, IDAO<CUSTOMER, CustomerDetailDTO>
    {
        public bool Delete(CUSTOMER entity)
        {
            try
            {
                CUSTOMER customerInDb = db.CUSTOMERs.First(x=>x.ID==entity.ID);
                if (customerInDb.isDeleted == false)
                {
                    customerInDb.isDeleted = true;
                    customerInDb.DeletedDate = DateTime.Today;
                }
                else
                {
                    db.CUSTOMERs.Remove(customerInDb);
                }
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
                CUSTOMER custInDb = db.CUSTOMERs.First(x => x.ID == ID);
                custInDb.DeletedDate = null;
                custInDb.isDeleted = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(CUSTOMER entity)
        {
            try
            {
                entity.isDeleted = false;
                db.CUSTOMERs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select()
        {
            try
            {
                List<CustomerDetailDTO> customersList = new List<CustomerDetailDTO>();
                var list = db.CUSTOMERs.Where(x=>x.isDeleted==false);
                foreach (var item in list)
                {
                    CustomerDetailDTO element = new CustomerDetailDTO();
                    element.ID = item.ID;
                    element.Name = item.CustomerName;
                    customersList.Add(element);
                }
                return customersList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<CustomerDetailDTO> customersList = new List<CustomerDetailDTO>();
                var list = db.CUSTOMERs.Where(x => x.isDeleted == isDeleted);
                foreach (var item in list)
                {
                    CustomerDetailDTO element = new CustomerDetailDTO();
                    element.ID = item.ID;
                    element.Name = item.CustomerName;
                    customersList.Add(element);
                }
                return customersList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(CUSTOMER entity)
        {
            try
            {
                CUSTOMER custUpdating = db.CUSTOMERs.First(x => x.ID == entity.ID);
                custUpdating.CustomerName = entity.CustomerName;
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

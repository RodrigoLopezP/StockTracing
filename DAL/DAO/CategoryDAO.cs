using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;

namespace StockTracing.DAL.DAO
{
    public class CategoryDAO : StockContext, IDAO<CATEGORY, CategoryDetailDTO>
    {
        public bool Delete(CATEGORY entity)
        {
            try
            {
                CATEGORY catInDb = db.CATEGORies.First(x => x.ID == entity.ID);
                if (catInDb.isDeleted == false)
                {
                    catInDb.isDeleted = true;
                    catInDb.DeletedDate = DateTime.Today;
                }
                else
                {
                    db.CATEGORies.Remove(catInDb);
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
                CATEGORY catInDb = db.CATEGORies.First(x => x.ID == ID);
                catInDb.DeletedDate = null;
                catInDb.isDeleted = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(CATEGORY entity)
        {
            try
            {
                db.CATEGORies.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryDetailDTO> Select()
        {
            List<CategoryDetailDTO> categories = new List<CategoryDetailDTO>();
            var list = db.CATEGORies.Where(x => x.isDeleted == false) ;
            foreach (var item in list)
            {
                CategoryDetailDTO dto = new CategoryDetailDTO();
                dto.ID = item.ID;
                dto.CategoryName = item.CategoryName;
                categories.Add(dto);
            }
            return categories;
        }

        public List<CategoryDetailDTO> Select(bool isDeleted)
        {
            List<CategoryDetailDTO> categories = new List<CategoryDetailDTO>();
            var list = db.CATEGORies.Where(x => x.isDeleted == isDeleted);
            foreach (var item in list)
            {
                CategoryDetailDTO dto = new CategoryDetailDTO();
                dto.ID = item.ID;
                dto.CategoryName = item.CategoryName;
                categories.Add(dto);
            }
            return categories;
        }

        public bool Update(CATEGORY entity)
        {
            try
            {
                CATEGORY cust_Old = db.CATEGORies.First(x => x.ID == entity.ID);
                cust_Old.CategoryName = entity.CategoryName;
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

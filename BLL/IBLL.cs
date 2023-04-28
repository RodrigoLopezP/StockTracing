using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.DAL.DAO
{
    //T- ProductDetailDTO | K-ProductDTO
    public interface IBLL<T, K> where T : class where K : class
    {
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        K Select();
        bool GetBack(T entity);

    }
}

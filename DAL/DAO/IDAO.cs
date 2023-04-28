using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracing.DAL.DAO
{
    interface IDAO<tTable, kTable> where tTable : class where kTable:class
    {
        List <kTable> Select();
        bool Insert(tTable entity);
        bool Update(tTable entity);
        bool Delete(tTable entity);
        bool GetBack(int ID);
    }
}

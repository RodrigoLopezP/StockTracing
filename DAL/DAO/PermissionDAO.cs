using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;

namespace StockTracing.DAL.DAO
{
    class PermissionDAO : StockContext, IDAO<PERMISSION, PermissionDetailDTO>
    {
        public bool Delete(PERMISSION entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PERMISSION entity)
        {
            throw new NotImplementedException();
        }

        public List<PermissionDetailDTO> Select()
        {
            List<PermissionDetailDTO> permissionTable = new List<PermissionDetailDTO>();
            var list = db.PERMISSIONs.ToList();
            foreach (var item in list)
            {
                PermissionDetailDTO row = new PermissionDetailDTO();
                row.PermissionID= item.ID;
                row.PermissionName = item.Name;
                permissionTable.Add(row);
            }
            return permissionTable;
        }

        public bool Update(PERMISSION entity)
        {
            throw new NotImplementedException();
        }
    }
}

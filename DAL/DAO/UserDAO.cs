using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DTO;

namespace StockTracing.DAL.DAO
{
    public class UserDAO : StockContext, IDAO<USER, UserDetailDTO>
    {
        public bool Delete(USER entity)
        {
            USER userInDb = db.USERs.First(x => x.ID == entity.ID);
            userInDb.isDeleted = true;
            userInDb.DeletedDate = DateTime.Today;
            db.SaveChanges();
            return true;
        }

        public bool GetBack(int ID)
        {
            USER userInDb = db.USERs.First(x => x.ID == ID);
            userInDb.isDeleted = false;
            userInDb.DeletedDate = null;
            db.SaveChanges();
            return true;
        }

        public bool Insert(USER entity)
        {
            db.USERs.Add(entity);
            db.SaveChanges();
            return true;
        }

        public List<UserDetailDTO> Select()
        {
            List<UserDetailDTO> users = new List<UserDetailDTO>();

            var list = (from u in db.USERs.Where(x => x.isDeleted == false)
                        join p in db.PERMISSIONs on u.PermissionID equals p.ID
                        select new
                        {
                            userId = u.ID,
                            username = u.Username,
                            userPassword = u.Password,
                            userIsAdmin = u.isAdmin,
                            permissionId = p.ID,
                            permissionName = p.Name,
                            isDeleted = u.isDeleted,
                            DeletedDate=u.DeletedDate
                        }).ToList();
            foreach(var item in list)
            {
                UserDetailDTO row = new UserDetailDTO();
                row.UserId = item.userId;
                row.Username = item.username;
                row.Password = item.userPassword;
                row.isAdmin = item.userIsAdmin;
                row.PermissionId = item.permissionId;
                row.PermissionName = item.permissionName;
                row.isDeleted = item.isDeleted;
                row.UserDeletedDate = item.DeletedDate;
                users.Add(row);
            }

            return users;
        }
        public List<UserDetailDTO> Select(bool isDeleted)
        {
            List<UserDetailDTO> users = new List<UserDetailDTO>();

            var list = (from u in db.USERs.Where(x => x.isDeleted == isDeleted)
                        join p in db.PERMISSIONs on u.PermissionID equals p.ID
                        select new
                        {
                            userId = u.ID,
                            username = u.Username,
                            userPassword = u.Password,
                            userIsAdmin = u.isAdmin,
                            permissionId = p.ID,
                            permissionName = p.Name,
                            isDeleted = u.isDeleted,
                            DeletedDate = u.DeletedDate
                        }).ToList();
            foreach (var item in list)
            {
                UserDetailDTO row = new UserDetailDTO();
                row.UserId = item.userId;
                row.Username = item.username;
                row.Password = item.userPassword;
                row.isAdmin = item.userIsAdmin;
                row.PermissionId = item.permissionId;
                row.PermissionName = item.permissionName;
                row.isDeleted = item.isDeleted;
                row.UserDeletedDate = item.DeletedDate;
                users.Add(row);
            }

            return users;
        }

        public bool Update(USER entity)
        {
            try
            {
                USER userOld = db.USERs.First(x => x.ID == entity.ID);
                userOld.Username = entity.Username;
                userOld.Password = entity.Password;
                userOld.isAdmin = entity.isAdmin;
                userOld.PermissionID = entity.PermissionID;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracing.DAL.DAO;
using StockTracing.DAL.DTO;
using StockTracing.DAL;

namespace StockTracing.BLL
{
    class UserBLL : IBLL<UserDetailDTO, UserDTO>
    {
        UserDAO userDao = new UserDAO();
        PermissionDAO permDao = new PermissionDAO();
        public bool Delete(UserDetailDTO entity)
        {
            USER userToDelete = new USER();
            userToDelete.ID = entity.UserId;
            return userDao.Delete(userToDelete);
        }

        public bool GetBack(UserDetailDTO entity)
        {
            USER userToGetBack = new USER();
            return userDao.GetBack(entity.UserId);
        }

        public bool Insert(UserDetailDTO entity)
        {
            USER userToInsert = new USER();
            userToInsert.isAdmin = entity.isAdmin;
            userToInsert.Username = entity.Username;
            userToInsert.Password = entity.Password;
            userToInsert.PermissionID = entity.PermissionId;
            return userDao.Insert(userToInsert);
        }

        public UserDTO Select()
        {
            UserDTO listUsers = new UserDTO();
            listUsers.users = userDao.Select();
            listUsers.permissions = permDao.Select();
            return listUsers;
        }

        public bool Update(UserDetailDTO entity)
        {
            USER userToUpdate = new USER();
            userToUpdate.ID = entity.UserId;
            userToUpdate.Username = entity.Username;
            userToUpdate.Password = entity.Password;
            userToUpdate.isAdmin = entity.isAdmin;
            userToUpdate.PermissionID = entity.PermissionId;
            return userDao.Update(userToUpdate);
        }
    }
}

using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.DAL
{
    public interface IUsersDAL
    {
        bool Login(string userName, string password);
        
        bool Register_(UsersBLL model);
        bool Delete(UsersBLL model);
        //tbUser GetUserByUserName(string userName);
        UsersBLL GetUserByUserName(string userName);
        UsersBLL GetUserById(long id);
        IEnumerable<UsersBLL> GetALLUsers();
    }
    public class UsersDAL : IUsersDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public bool Delete(UsersBLL model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersBLL> GetALLUsers()
        {
            throw new NotImplementedException();
        }
        //public tbUser GetUserByUserName(string userName)
        //{
        //    return db.tbUsers.SingleOrDefault(x => x.Name_User == userName);
        //}
        public UsersBLL GetUserByUserName(string userName)
        {
            tbUser obj = db.tbUsers.SingleOrDefault(x => x.Name_User == userName);
            if (obj == null)
            {
                return null;
            }
            else
            {
                UsersBLL model = new UsersBLL();
                model.Name_User = obj.Name_User;
                model.Id_User = obj.Id_User;
                return model;
            }
        }

        public UsersBLL GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string userName, string password)
        {
            var result = db.tbUsers.Count(x => x.Name_User == userName && x.Password_User == password);
            if(result>0) return true;
            else return false;
        }

        public bool Register_(UsersBLL model)
        {
            try
            {
                tbUser obj = new tbUser();
                if (GetUserByUserName(model.Name_User) != null) return false;
                obj.Name_User = model.Name_User;
                obj.Password_User = model.Password_User;
                obj.Email_User = model.Email_User;
                obj.Date_Created_User = DateTime.Now;
                obj.Status_User = true;
                db.tbUsers.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
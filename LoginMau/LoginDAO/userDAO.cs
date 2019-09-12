using LoginMau.Models;
using LoginMau.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginMau.LoginDAO
{
    public class userDAO
    {
        quynh db = null;
        public userDAO()
            {
               db = new quynh(); 
            }
        public Userr GetUser(string username)
        {
            Userr getuser = db.Userrs.SingleOrDefault(x => x.name == username);           
            return getuser;
        }
        public long Insert(Userr entity)
        {
            db.Userrs.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
        public bool Login(Userr userlogin)
        {

        }
    }
}
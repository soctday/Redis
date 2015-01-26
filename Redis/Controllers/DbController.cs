using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Redis.Ef;
using Redis.Models;

namespace Redis.Controllers
{
    public class DbController : Controller
    {
        //
        // GET: /Db/

        public void Index()
        {
            DBUser u = new DBUser() { Name = "巨兴传媒"};
            CRMDBContext.CurrentThreadCRMDBContext.DBUser.Add(u);
            CRMDBContext.CurrentThreadCRMDBContext.SaveChanges();
            
        }

    }
}

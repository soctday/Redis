using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Redis.Helper;
using Redis.Models;
using ServiceStack.Redis;

namespace Redis.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        RedisHelper redisHelper = new RedisHelper(true);
        public void Index()
        {
            //List<User> list = new List<User>();
            //for (int i = 0; i < 100; i++)
            //{
            //    User u = new User() { Name = "巨兴传媒" + i, Id = i };
            //    list.Add(u);
            //}
            //List<User> list = new List<User>();
            //for (int i = 0; i < 100; i++)
            //{
            //User u = new User() { Name = "巨兴传媒" , Id = 1 };
            //redisHelper.Set<User>("jxcm", u);//设置缓存
            // list.Add(u);
            //  }
            //  redisHelper.Remove("list1");//删除缓存
            //redisHelper.AddList<User>("list1", list);//添加缓存链表
            redisHelper.AddEntityToList<User>("jxcm", new User() { Name = "巨兴传媒", Id = 1 });
            //list = redisHelper.GetList<User>("list1").ToList();

            //  u = redisHelper.Get<User>("user");
        }

        public ActionResult List()
        {
            List<User> list = redisHelper.GetList<User>("jxcm").ToList();
            return View(list);
        }



    }
}

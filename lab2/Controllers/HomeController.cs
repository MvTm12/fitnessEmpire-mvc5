using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab2.Models;
using lab2.Dal;
namespace lab2.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // home page of website
        public ActionResult Home()
        { 
            return View();
         
        }

        // about page
        public ActionResult About()
        {
            return View();
        }
        // contact page
        public ActionResult Contact()
        {
            // shop is list of Lists of weights and mechines
            DataLayer dal = new DataLayer();
            List<ShopsM> sList = (from x in dal.Shops select x).ToList<ShopsM>();
            ShopVM shop = new ShopVM();
            shop.Shops = sList;
            return View(shop);
        }

        // this is the registar page
        public ActionResult Enter()
        {
            return View(new User());
        }

        //this is the registar page
        public ActionResult details(User cust)
        {
            
            if (ModelState.IsValid)
            {
                cust.Roles = "USER";
                DataLayer dal = new DataLayer();
                List<User> objCustomers = (from x in dal.Customers
                                               where x.USER_ID.Equals(cust.USER_ID)
                                               select x).ToList<User>();
                // if not the website adds the user to the user DB
                if (objCustomers.Count == 0)
                {
                    dal.Customers.Add(cust);
                    dal.SaveChanges();
                    return View("Home");
                    
                }
                else
                {
                    // if yes the user get a message that the user akready exsists
                    ModelState.AddModelError("USER_ID", "The user id already exist!");
                    return View("Enter", cust);
                }

            }
            else
                // if user not allowed to get into this page the usre will be sent to login page
                return View("Enter", cust);
        }

    }



}
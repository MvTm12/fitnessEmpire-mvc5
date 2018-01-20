using lab2.Dal;
using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    [Authorize(Roles ="MANAGER")]
    public class ManagerController : Controller
    {
        // view users page
        public ActionResult ViewUsers()
        {
            // get list of users from DB
            DataLayer dal = new DataLayer();
            List<User> Cust = dal.Customers.ToList<User>();
            UserVM cust = new UserVM();
            cust.customer = new User();
            cust.customers = Cust;
            // return the view, and send to it the user list
            return View(cust);
        }
        //view shops and add a new shop page
        public ActionResult Shops_view()
        {
            // get the shop list from DB
            DataLayer dal1 = new DataLayer();
            List<ShopsM> Sho = dal1.Shops.ToList<ShopsM>();
            ShopVM sho = new ShopVM();
            sho.Shop = new ShopsM();
            sho.Shops = Sho;
            return View(sho);

        }
        // JSON view table Asynchronicly
        public ActionResult Get_Shop_By_Json()
        {
            DataLayer dal1 = new DataLayer();
            Thread.Sleep(2000);
            List<ShopsM> Sho = dal1.Shops.ToList<ShopsM>();
            return Json(Sho,JsonRequestBehavior.AllowGet);
        }

        //add shop to DB
        [HttpPost]
        public ActionResult SubmitShop()
        {

            ShopVM S = new ShopVM();
            ShopsM objS = new ShopsM();
            objS.City = Request.Form["shop.City"].ToString();
            objS.Address = Request.Form["shop.Address"].ToString();
            objS.Phone = Request.Form["shop.Phone"].ToString();
            objS.Week_days = Request.Form["shop.Week_days"].ToString();
            objS.Week_end = Request.Form["shop.Week_end"].ToString();

            DataLayer dal2 = new DataLayer();

            // checking if the entered data is valid
            if (ModelState.IsValid)
            {
                // add the data to DB
                List<ShopsM> objCustomers = (from x in dal2.Shops select x).ToList<ShopsM>();
                    objS.ID = (objCustomers.Count+1).ToString();
                    dal2.Shops.Add(objS);
                    dal2.SaveChanges();
                    S.Shop = new ShopsM();
            }
            else
            {
                S.Shop = objS;
            }
            S.Shops = dal2.Shops.ToList<ShopsM>();
            return View("Shops_view", S);
        }
        // manage page view
        public ActionResult Manage()
        {
            return View();
        }

    }
}
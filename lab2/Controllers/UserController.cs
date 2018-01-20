//using lab2.modelBinder;
using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab2.Dal;
using System.Web.Security;

namespace lab2.Controllers
{

    //after user looged in he can enter this page
    [Authorize(Roles = "MANAGER,USER")] 
    public class UserController : Controller
    {


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            // it will clear the session at the end of request
            Session.Abandon(); 

            //resend the user after logout to home page
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Shop()
        {
            // shop is list of Lists of weights and mechines
            DataLayer dal = new DataLayer();
            List<Product> objProduct = (from x in dal.Products select x).ToList<Product>();
            ShopVM shop = new ShopVM();
            shop.prods = objProduct;

            // list of products of type Weights from DB
            List<Weights> objWeights = (from x in dal.Weights select x).ToList<Weights>();
            ShopVM Weights = new ShopVM();
            shop.Weights = objWeights;

            // list of products of type Mechine from DB
            List<Mechine> objMechines = (from x in dal.Mechines select x).ToList<Mechine>();
            ShopVM Mechines = new ShopVM();
            shop.Mechines = objMechines;

            // return the view
            return View(shop);
        }


    }
}
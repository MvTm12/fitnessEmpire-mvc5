using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab2.Models;
using lab2.Dal;
using System.Web.Security;

namespace lab2.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // login page
        public ActionResult Index()
        {
            return View("Login");
        }

        // login method
        public ActionResult Authenticate(UserLogin usr)
        {
            DataLayer dal = new DataLayer();
            if(ModelState.IsValid) // tells you if any model errors have been added to modelstate
            {
               // checks if user exsists 
                List<User> useValidated = (from u in dal.Customers
                                               where (u.USER_ID == usr.USER_ID) && (u.PASSWORD == usr.PASSWORD)
                                               select u).ToList<User>();
                if(useValidated.Count==1)
                {// user autenticated succeccfully
                 FormsAuthentication.SetAuthCookie(usr.USER_ID, true);

                    // seve in session the name and id of user 
                    Session["UserID"] = usr.USER_ID;
                    Session["UserName"] = useValidated[0].FNAME;

                    // set the cookie name to user name
                    Response.Cookies["UserName"].Value = Session["UserName"].ToString();
                    // save the authorization to the page 
                    Response.Cookies["authcookie"].Expires = DateTime.Now.AddDays(2);
                    // save cookie of user name afte page closes
                    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(2);

                    return RedirectToRoute("ShowHomePage");
                }
                else
                {
                    // Error message
                    ViewBag.msg = "User id / Password INCORRECT!";
                    // return the user to the same view , with the full fields that the user filled 
                    return View("Login", usr);
                }

            }
            else
            {
                // return the user to the same view , with the full fields that the user filled 
                return View("Login",usr);
            }

        }
    }
}
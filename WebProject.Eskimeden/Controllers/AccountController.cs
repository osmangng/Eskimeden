using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Eskimeden.Entity;
using WebProject.Eskimeden.Identity;
using WebProject.Eskimeden.Models;

namespace WebProject.Eskimeden.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        DataContext db = new DataContext();
        public AccountController()
        {
            var UserStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(UserStore);

            var RoleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(RoleStore);


        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                //Kayıt İşlemleri

                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.UserName = model.Username;

                IdentityResult Result = UserManager.Create(user, model.Password);
                if (Result.Succeeded)
                {
                    //kullanıcı oluşturuldu ve kullanıcıyı bir role atanacak
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");

                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı Oluşturma Hatası.");

                }
            }
            return View(model);
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Kayıt İşlemleri
                var user = UserManager.Find(model.Username, model.Password);
                if (user != null)
                {
                    //varolan kullanıcıyı sisteme dahil edilecek
                    //ApplicationCookie oluşturulup sisteme dail et
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user,"ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;

                    authManager.SignIn(authProperties,identityclaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                       return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Kullanıcı Kayıtlı değil");

                }



            }
            return View(model);
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index","Home");
        }
        public ActionResult Index()
        {
            var userName = User.Identity.Name;
            var orders = db.Orders
                .Where(i => i.UserName == userName)
                .Select(i => new UserOrderModel
                {
                    Id = i.Id,
                    OrderNumber=i.OrderNumber,
                    OrderDate=i.OrderDate,
                    OrderState=i.OrderState,
                    Total=i.Total


                }).OrderByDescending(i=>i.OrderDate).ToList();
            return View(orders);
        }
        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
                .Select(i => new DetailsModel()
                {
                    OrderId=i.Id,
                    OrderNumber=i.OrderNumber,
                    Total=i.Total,
                    OrderDate=i.OrderDate,
                    OrderState=i.OrderState,

                    AdresBasligi=i.AdresBasligi,

                    Adres=i.Adres,
                    Sehir=i.Sehir,
                    Semt=i.Semt,
                    Mahalle=i.Mahalle,
                    PostaKodu=i.PostaKodu,
                    OrderLines=i.OrderLines.Select(a=>new OrderLineModel()
                    {
                        ProductId=a.ProductId,
                        ProductName=a.Product.Name,
                        Image=a.Product.Image,
                        Quantity=a.Quantity,
                        Price=a.Price
                    }).ToList(),


                }).FirstOrDefault();
            return View(entity);
        }

    }
}

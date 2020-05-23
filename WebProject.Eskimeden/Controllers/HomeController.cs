using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Eskimeden.Entity;
using WebProject.Eskimeden.Models;

namespace WebProject.Eskimeden.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {

            var urunler = _context.Products.Where(i => i.IsHome == true)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length>50 ?i.Name.Substring(0,47)+"...":i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "camera.jpg",
                    CategoryId = i.CategoryId,
                    IsApproved = i.IsApproved

                }).ToList();
            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            var urunler = _context.Products.Where(i => i.Id == id)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description =i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "camera.jpg",
                    CategoryId = i.CategoryId,
                    IsApproved=i.IsApproved
                   

                }).FirstOrDefault();
            return View(urunler);
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                .Where(i=>i.IsApproved==true)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "camera.jpg",
                    CategoryId = i.CategoryId,
                    IsApproved = i.IsApproved

                }).AsQueryable();
            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);

            }
            return View(urunler.ToList());
        }
       
        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.OrderBy(i=>i.Name).ToList());
        }
    }
}
using AJAX_MVC4_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAX_MVC4_APP.Controllers
{
    public class AjaxController : Controller
    {
        //
        // GET: /Ajax/
        static List<Product> productList;
        public ActionResult Index()
        {
            productList = new List<Product>()
            {
                new Product{ID="P101", Name="MS Galaxy 555", Price=500, Quantity= 10},
                new Product{ID="P102", Name="MS Galaxy 540", Price=500, Quantity= 10},
                new Product{ID="P103", Name="MS Galaxy 655", Price=500, Quantity= 10},
                new Product{ID="P104", Name="MS Galaxy 555", Price=500, Quantity= 10},
                new Product{ID="P105", Name="MS Galaxy 555", Price=500, Quantity= 10},
                new Product{ID="P101", Name="MS Galaxy 698", Price=500, Quantity= 10},
                new Product{ID="P101", Name="MS Galaxy 400", Price=500, Quantity= 10},
                new Product{ID="P101", Name="MS Galaxy 250", Price=500, Quantity= 10},
                new Product{ID="P101", Name="MS Galaxy 100", Price=500, Quantity= 10},
                new Product{ID="P101", Name="MS Galaxy 640", Price=500, Quantity= 10}
            };
            
            return View();
        }
        public PartialViewResult showDetails()
        {
            System.Threading.Thread.Sleep(3000);
            string id = Request.Form["txtCode"];
            Product p = new Product();
            foreach (Product item in productList)
            {
                if (item.ID == id)
                {
                    p = item;
                    break;
                }
            }

            return PartialView("_showDetails", p);
        }

    }
}

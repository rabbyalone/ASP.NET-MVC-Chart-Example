using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AJAX_MVC4_APP.Controllers
{
    
    public class ChartController : Controller
    {
        //
        // GET: /Chat/
        AJAX_MVC4_APP.Models.AJAX_MVC4_APPContext db = new Models.AJAX_MVC4_APPContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult myChart1()
        {
            var data = db.Products.ToList();

            new Chart(width: 400, height: 400)
                .AddTitle("This is my Chart one")
                .AddSeries(chartType: "Pie",
                xValue: data, xField: "Name",
                yValues: data, yFields: "Price").Write();

            return null;
        }

        public ActionResult myChart2()
        {
            var data = db.Products.ToList();

            new Chart(width: 400, height: 400, theme: ChartTheme.Blue)
                .AddTitle("This is my Chart one")
                .AddSeries(chartType: "Pie",
                xValue: data, xField: "Name",
                yValues: data, yFields: "Price").Write();

            return null;
        }

        public ActionResult myChart3()
        {
            var data = db.Products.ToList();

            string myStyle = @"<Chart BackColor=""LightGray"" ForeColor=""Blue"">
                             <ChartAreas>
                                <ChartArea Name=""Default"" BackColor=""Pink""></ChartArea>
                             </ChartAreas>
                            </Chart>";

            new Chart(width: 400, height: 400, theme: myStyle)
                .AddTitle("This is my Chart one")
                .AddSeries(chartType: "Pie",
                xValue: data, xField: "Name",
                yValues: data, yFields: "Price").Write();

            return null;
        }


        private string myCustomTheme()
        {
            return @"<Chart BackColor=""LightGray"" ForeColor=""Blue"">
                             <ChartAreas>
                                <ChartArea Name=""Default"" BackColor=""Red""></ChartArea>
                             </ChartAreas>
                            </Chart>";
        }
        public ActionResult myChart4()
        {
            var data = db.Products.ToList();


            //new Chart(width: 400, height: 400, myCustomTheme())
            
            new Chart(width: 400, height: 400, theme: myCustomTheme())
                .AddTitle("This is my Chart one")
                .AddSeries(chartType: "Pie",
                xValue: data, xField: "Name",
                yValues: data, yFields: "Price").Write();

            return null;
        }
        public ActionResult myChart5()
        {
            var d = new DateTimeFormatInfo();
           var key =  new Chart(width: 400, height: 400, theme: myCustomTheme())
                .AddTitle("This is my Chart one")
                .AddSeries(chartType: "column")
                .DataBindTable(d.DayNames)
                .Write(format:"gif");
           key.Save(Server.MapPath("../Content/myChat.jpg"),format:"jpeg");
            return null;
        }
    }
}

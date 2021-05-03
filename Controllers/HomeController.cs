using Lodziarnia.Models;
using Lodziarnia.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILody lodyRepository;
        private readonly ICennik cennik;
        private readonly IGodzinyPracy godzinypracy;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(ILogger<HomeController> logger, ILody _lodyRepository, ICennik _cennik, IGodzinyPracy _godzinypracy
            , IHostingEnvironment _hostingEnvironment)
        {
            _logger = logger;
            lodyRepository = _lodyRepository;
            cennik = _cennik;
            godzinypracy = _godzinypracy;
            hostingEnvironment = _hostingEnvironment;
        }


        public IActionResult Index()
        {
            Lody_i_Godziny lody_i_godziny = new Lody_i_Godziny { Godziny = godzinypracy.GetAll(), Lody = lodyRepository.GetAll() };
            return View(lody_i_godziny);
        }

        

        [HttpPost]
        public IActionResult EditHour(GodzinyPracy x)
        {
            int tymczasowo = x.GodzinaStart;
            x = godzinypracy.GetOne(x.DzienID);
            x.GodzinaStart = tymczasowo;
            godzinypracy.Edit(x);

            int daynow = Convert.ToInt32(DateTime.Now.DayOfWeek);
            Dzien Today = ConvertDay.ReturnDay(daynow);
            ViewBag.Day = x.GodzinaStart + ":" + x.MinutaStart;

            return View("index",x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult GodzinyEdit(GodzinyPracyEditAllArray Godziny_all)
        {
            /*ViewBag.Days = JednaGodzina.DzienID;
            int tymczasowySTR1 = JednaGodzina.GodzinaStart; int tymczasowySTR2 = JednaGodzina.MinutaStart;
            int tymczasowyEND1 = JednaGodzina.GodzinaEnd; int tymczasowyEND2 = JednaGodzina.MinutaEnd;
            GodzinyPracy Y = godzinypracy.GetOne(JednaGodzina.DzienID);
            Y.GodzinaStart = tymczasowySTR1; Y.MinutaStart = tymczasowySTR2;
            Y.GodzinaEnd = tymczasowyEND1; Y.MinutaEnd = tymczasowyEND2;
            godzinypracy.Edit(Y);*/
            foreach(var x in Godziny_all.ReturnAll())
            {
                int tymczasowySTR1 = x.GodzinaStart; int tymczasowySTR2 = x.MinutaStart;
                int tymczasowyEND1 = x.GodzinaEnd; int tymczasowyEND2 = x.MinutaEnd;
                //x = godzinypracy.GetOne(x.DzienID);
                godzinypracy.Edit(x);
                ViewBag.Days = x.DzienID;
            }
            GodzinyPracyEditAllArray ShowAll = new GodzinyPracyEditAllArray(godzinypracy.GetAll());
            return View(ShowAll);
        }
        [HttpGet]
        public IActionResult GodzinyEdit()
        {
            GodzinyPracyEditAllArray ShowAll =new GodzinyPracyEditAllArray(godzinypracy.GetAll());
            return View(ShowAll);
        }
    }
}

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
    public class EdycjaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILody lodyRepository;
        private readonly ICennik cennik;
        private readonly IGodzinyPracy godzinypracy;
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public EdycjaController(ILogger<HomeController> logger, ILody _lodyRepository, ICennik _cennik, IGodzinyPracy _godzinypracy
            , IHostingEnvironment _hostingEnvironment)
        {
            _logger = logger;
            lodyRepository = _lodyRepository;
            cennik = _cennik;
            godzinypracy = _godzinypracy;
            hostingEnvironment = _hostingEnvironment;

        }


        [HttpGet]
        public IActionResult DodawanieSmaku()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DodawanieSmaku(LodyCreateView x)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (x.SciezkaZdjecia != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + x.SciezkaZdjecia.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    x.SciezkaZdjecia.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Lody smakLoda = new Lody(x.SmakNazwa, x.SmakOpis, x.SmakDostepny == 1 ? true : false, x.SmakAlkohol == 1 ? true : false, uniqueFileName,
                    x.kategoriaLoda);
                lodyRepository.AddNew(smakLoda);
                return RedirectToAction("index", "home");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Loda(Lody lod)
        {
            return View(lod);
        }

        [HttpGet]
        public IActionResult Godzin()
        {
            GodzinyView godzV = new GodzinyView(godzinypracy);
            return View(godzV);
        }

        [HttpPost]
        public IActionResult Godzin(GodzinyView _godziny)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < 1; i++)   ////////////////////////////////////////
                {
                    GodzinyPracy x = new GodzinyPracy
                    {
                        DzienID = (Dzien)0,
                        GodzinaStart = _godziny.GodzinaStart0,
                        MinutaStart=_godziny.MinutaStart0,
                        GodzinaEnd=_godziny.GodzinaEnd0,
                        MinutaEnd=_godziny.MinutaEnd0
                    };
                    godzinypracy.Edit(x);
                    x = new GodzinyPracy
                    {
                        DzienID = (Dzien)1,
                        GodzinaStart = _godziny.GodzinaStart1,
                        MinutaStart = _godziny.MinutaStart1,
                        GodzinaEnd = _godziny.GodzinaEnd1,
                        MinutaEnd = _godziny.MinutaEnd1
                    };
                    godzinypracy.Edit(x);
                    x = new GodzinyPracy
                    {
                        DzienID = (Dzien)2,
                        GodzinaStart = _godziny.GodzinaStart2,
                        MinutaStart = _godziny.MinutaStart2,
                        GodzinaEnd = _godziny.GodzinaEnd2,
                        MinutaEnd = _godziny.MinutaEnd2
                    };
                    godzinypracy.Edit(x);
                    x = new GodzinyPracy
                    {
                        DzienID = (Dzien)3,
                        GodzinaStart = _godziny.GodzinaStart3,
                        MinutaStart = _godziny.MinutaStart3,
                        GodzinaEnd = _godziny.GodzinaEnd3,
                        MinutaEnd = _godziny.MinutaEnd3
                    };
                    godzinypracy.Edit(x);
                    x = new GodzinyPracy
                    {
                        DzienID = (Dzien)4,
                        GodzinaStart = _godziny.GodzinaStart4,
                        MinutaStart = _godziny.MinutaStart4,
                        GodzinaEnd = _godziny.GodzinaEnd4,
                        MinutaEnd = _godziny.MinutaEnd4
                    };
                    godzinypracy.Edit(x);
                    x = new GodzinyPracy
                    {
                        DzienID = (Dzien)5,
                        GodzinaStart = _godziny.GodzinaStart5,
                        MinutaStart = _godziny.MinutaStart5,
                        GodzinaEnd = _godziny.GodzinaEnd5,
                        MinutaEnd = _godziny.MinutaEnd5
                    };
                    godzinypracy.Edit(x);
                    x = new GodzinyPracy
                    {
                        DzienID = (Dzien)6,
                        GodzinaStart = _godziny.GodzinaStart6,
                        MinutaStart = _godziny.MinutaStart6,
                        GodzinaEnd = _godziny.GodzinaEnd6,
                        MinutaEnd = _godziny.MinutaEnd6
                    };
                    godzinypracy.Edit(x);
                }
            }
            GodzinyView godzV = new GodzinyView(godzinypracy);
            return View(godzV);
        }

    }
}

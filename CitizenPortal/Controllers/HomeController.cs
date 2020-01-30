using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitizenPortal.Models;
using CitizenPortal.DAL;
using CitizenPortal.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using CitizenPortal.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json;
using System.Text;

namespace CitizenPortal.Controllers
{
   // [AllowSameSite] //For the whole controller
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        const string SessionName = "_Language";
        const string Lankeys = "_LanguageKeys";
        private readonly IPortalService _portalService;
        private readonly ILanguageDictionaryService _languageDictionaryService;
        private readonly ILogger _logger;

        public HomeController(
            ILogger<AccountController> logger, IPortalService portalservice, IStringLocalizer<HomeController> localizer, ILanguageDictionaryService langservices)
        {
            _logger = logger;
            _portalService = portalservice;
            _localizer = localizer;
            _languageDictionaryService = langservices;
        }
        public IActionResult Index()
        {
            List<LanguageKeyViewModel> LanguageObjectAr = new List<LanguageKeyViewModel>();
            string ArValues = "";
            LanguageObjectAr = _languageDictionaryService.GetDictionariesAR();
            for (int i = 0; i < LanguageObjectAr.Count; i++)
            {
                ArValues += LanguageObjectAr[i].LanguageKey + "," + LanguageObjectAr[i].Arabick + "-";
            }

            HttpContext.Session.SetString(SessionName, "AR");
            HttpContext.Session.SetString(Lankeys, Convert.ToString(ArValues));

            return View();

        }

        public IActionResult Indexv()
        {
            var sessionName = new Byte[20];
            bool nameOK = HttpContext.Session.TryGetValue(Lankeys, out sessionName);
            if (nameOK == true)
            {
                string result = System.Text.Encoding.UTF8.GetString(sessionName);
                ViewBag.LanguageKeyViewModel = result;

            }
            else
            {
                HttpContext.Session.SetString(SessionName, "AR");
            }
            // List<LanguageKeyViewModel> LanguageObjectEn = new List<LanguageKeyViewModel>();
            //LanguageObjectEn = _languageDictionaryService.GetDictionariesEN();
            // ViewData["Lansys"] = LanguageObjectEn;

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetProfiles([DataSourceRequest] DataSourceRequest request)
        {
            return Content(JsonConvert.SerializeObject(_portalService.GetGrid(request)), "application/json");
            //return View();
        }


        public IActionResult Profiles([DataSourceRequest] DataSourceRequest request)
        {
           // return Content(JsonConvert.SerializeObject(_portalService.GetGrid(request)), "application/json");
            return View();
        }

        public IActionResult SearchProfiles([DataSourceRequest] DataSourceRequest request,string id)
        {
            return Content(JsonConvert.SerializeObject(_portalService.GetProfile(request, id)), "application/json");
        }

        public IActionResult Profile([DataSourceRequest] DataSourceRequest request, string id)
        {
            // return Content(JsonConvert.SerializeObject(_portalService.GetGrid(request)), "application/json");
            return View();
        }

        public IActionResult EachProfile([DataSourceRequest] DataSourceRequest request,string id)
        {
            return RedirectToAction("Profile", "Home");
        }

        public IActionResult Language()
        {
            var sessionName = new Byte[20];
            List<LanguageKeyViewModel> LanguageObjectEn = new List<LanguageKeyViewModel>();
            LanguageObjectEn = _languageDictionaryService.GetDictionariesEN();

            List<LanguageKeyViewModel> LanguageObjectAr = new List<LanguageKeyViewModel>();
            LanguageObjectAr = _languageDictionaryService.GetDictionariesEN();

            bool nameOK = HttpContext.Session.TryGetValue(SessionName, out sessionName);
            if (nameOK == true)
            {
                string result = System.Text.Encoding.UTF8.GetString(sessionName);
                if (result == "AR")
                {
                    HttpContext.Session.SetString(SessionName, "AR");
                    HttpContext.Session.SetString(Lankeys, Convert.ToString(LanguageObjectEn));
                    // ViewData["Lansys"] = LanguageObjectAr;
                }

                if (result == "EN")
                {
                    HttpContext.Session.SetString(SessionName, "EN");
                    HttpContext.Session.SetString(Lankeys, Convert.ToString(LanguageObjectEn));
                    //ViewData["Lansys"] = LanguageObjectEn;
                }

            }
            else
            {
                HttpContext.Session.SetString(SessionName, "AR");
            }

            return RedirectToAction("Index", "Home");


        }
        public IActionResult LanguageAr()
        {
            List<LanguageKeyViewModel> LanguageObjectAr = new List<LanguageKeyViewModel>();
            string ArValues = "";
            LanguageObjectAr = _languageDictionaryService.GetDictionariesAR();
            for (int i = 0; i < LanguageObjectAr.Count; i++)
            {
                //  ArValues +=""+ LanguageObjectAr[i].LanguageKey + ":" + LanguageObjectAr[i].Arabick + ",";
                ArValues += '"'+ LanguageObjectAr[i].LanguageKey +'\"'+ ':' +'\"' + LanguageObjectAr[i].Arabick + '"'+ ',';
            }

            ArValues = ArValues.TrimEnd(',');
            ArValues = "[{" + ArValues + "}]";
            HttpContext.Session.SetString(SessionName, "AR");
            HttpContext.Session.SetString(Lankeys, Convert.ToString(ArValues));
            return RedirectToAction("Login", "Account");
        }
        public IActionResult LanguageEn()
        {
            var sessionName = new Byte[20];
            List<LanguageKeyViewModel> LanguageObjectEn = new List<LanguageKeyViewModel>();
            LanguageObjectEn = _languageDictionaryService.GetDictionariesEN();
            string ArValues = "English-";
            HttpContext.Session.SetString(SessionName, "EN");
            for (int i = 0; i < LanguageObjectEn.Count; i++)
            {
                //  ArValues +=""+ LanguageObjectAr[i].LanguageKey + ":" + LanguageObjectAr[i].Arabick + ",";
                ArValues += '"' + LanguageObjectEn[i].LanguageKey + '\"' + ':' + '\"' + LanguageObjectEn[i].Arabick + '"' + ',';
            }

            ArValues = ArValues.TrimEnd(',');
            ArValues = "[{" + ArValues + "}]";
            HttpContext.Session.SetString(Lankeys, Convert.ToString(ArValues));
            return RedirectToAction("Login", "Account");
        }
        public IActionResult Language1(string Lanuguage)
        {
            var sessionName = new Byte[20];
            List<LanguageKeyViewModel> LanguageObjectEn = new List<LanguageKeyViewModel>();
            LanguageObjectEn = _languageDictionaryService.GetDictionariesEN();

            List<LanguageKeyViewModel> LanguageObjectAr = new List<LanguageKeyViewModel>();
            LanguageObjectAr = _languageDictionaryService.GetDictionariesAR();

            if (Lanuguage == "EN")
            {
                HttpContext.Session.SetString(SessionName, "AR");
                HttpContext.Session.SetString(Lankeys, Convert.ToString(LanguageObjectEn));
            }

            if (Lanuguage == "AR")
            {
                HttpContext.Session.SetString(SessionName, "EN");
                HttpContext.Session.SetString(Lankeys, Convert.ToString(LanguageObjectAr));
            }
            return RedirectToAction("Index", "Home");

        }
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

    }
}

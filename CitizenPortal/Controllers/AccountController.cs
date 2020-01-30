using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CitizenPortal.Models;
using CitizenPortal.Models.AccountViewModels;
using CitizenPortal.Services;
using CitizenPortal.Interfaces;
using Microsoft.AspNetCore.Http;
using CitizenPortal.DAL;

namespace CitizenPortal.Controllers
{
    
    [Authorize]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        const string SessionName = "_UserName";
        private readonly IEmailSender _emailSender;
        private readonly IPortalService _portalService;
        private readonly ILogger _logger;
        private readonly ILanguageDictionaryService _languageDictionaryService;



        public AccountController(
            IEmailSender emailSender,
            ILogger<AccountController> logger, IPortalService portalservice, ILanguageDictionaryService langservices)
        {
            _emailSender = emailSender;
            _logger = logger;
            _portalService = portalservice;
        _languageDictionaryService = langservices;
    }

       // [TempData]
       // public string ErrorMessage { get; set; }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
           
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                // var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                CPUser _user = new CPUser();
                _user= _portalService.LoginUser(model.Email, model.Password);
                if (_user != null)
                {
                    HttpContext.Session.SetString(SessionName, _user.UserName);
                   // ViewBag["Languages"]= _languageDictionaryService.
                    return RedirectToAction("Profiles", "Home");
                    //return RedirectToLocal("/Main");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

      
      
     


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                    _logger.LogInformation("User created a new account with password.");
                    _portalService.RegisterUser(model.Name,model.Email,model.Password,model.Name);
                    _logger.LogInformation("User created a new account with password.");
                    return RedirectToLocal(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

     
       
    
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]

       

     


        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}

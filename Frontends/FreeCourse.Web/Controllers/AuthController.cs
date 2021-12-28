using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models;
using FreeCourse.Web.Services.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FreeCourse.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IIdentityService _identityService;

        public AuthController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SigninInput input)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var response = await _identityService.SignIn(input);
            if (!response.IsSuccessful)
            {
                response.Errors.ForEach(x =>
                {
                    ModelState.AddModelError(String.Empty,x);

                });
                return View();
            }


            return RedirectToAction(nameof(Index), "Home");

        }
    }
}

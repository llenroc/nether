﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Nether.Identity.Development.DummyWeb.Controllers
{
    public class AccountController : Controller
    {
        public async Task Logout()
        {
            await HttpContext.Authentication.SignOutAsync("Cookies");
            await HttpContext.Authentication.SignOutAsync("oidc");
        }
    }
}
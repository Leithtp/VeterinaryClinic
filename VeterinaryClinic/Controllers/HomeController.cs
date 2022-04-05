using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryClinic.Models;
using VeterinaryClinic.Repositories.Abstract;
using VeterinaryClinic.Repositories.Implementation;

namespace VeterinaryClinic.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ContactUs()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(EmailViewModel emailViewModel )
        {
            //emailSender.SendMessage(emailViewModel);
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;
using MyFirstApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstApp.Controllers
{
    public class GreeterController : Controller
    {

        private IDateTimeService dateTimeService;

        GreeterController(){
            this.dateTimeService = new DateTimeService();
        }

        GreeterController(IDateTimeService dateTimeService){
            this.dateTimeService = dateTimeService;
        }
        // GET: /<controller>/
        public ViewResult Greet()
        {
            this.ViewBag.userDetails = new UserDetails();
            return this.View();
        }

        // POST: /<controller>/
        [HttpPost]
        public ViewResult Greet(UserDetails userDetails)
        {
            //this.ViewData["message"] = "Hi " + FirstName + " " + LastName + ", Have a nice day!";
            userDetails.Greet();
            this.ViewBag.userDetails = userDetails;
            this.ViewBag.Message = userDetails.Message;
            if (this.dateTimeService.GetCurrent().Hour < 12){
                return this.View("MorningMessage");
            } else {
                return this.View("EveningMessage");
            }
        }
    }
}

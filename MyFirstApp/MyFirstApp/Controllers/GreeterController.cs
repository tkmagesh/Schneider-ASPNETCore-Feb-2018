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

        /*
        public GreeterController(){
            this.dateTimeService = new DateTimeService();
        }
        */

        public GreeterController(IDateTimeService dateTimeService, IDummyService dummyService){
            this.dateTimeService = dateTimeService;
        }
        // GET: /<controller>/
        public ViewResult Greet()
        {
            var modelData = new UserDetails() { Message = "[Initial Message]" };
            return this.View(modelData);
        }

        // POST: /<controller>/
        [HttpPost]
        public ViewResult Greet(UserDetails userDetails)
        {
            //this.ViewData["message"] = "Hi " + FirstName + " " + LastName + ", Have a nice day!";
            userDetails.Greet();
            if (this.dateTimeService.GetCurrent().Hour < 12){
                return this.View("MorningMessage", userDetails);
            } else {
                return this.View("EveningMessage", userDetails);
            }
        }
    }
}

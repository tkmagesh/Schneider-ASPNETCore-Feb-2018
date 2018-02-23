using System;
using System.Diagnostics;

namespace MyFirstApp.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTimeService()
        {
            Debug.WriteLine("[@DateTimeService]  instance created");
        }

        public DateTime GetCurrent(){
            return DateTime.Now;
        }
    }
}

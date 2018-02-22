using System;
namespace MyFirstApp.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTimeService()
        {
        }

        public DateTime GetCurrent(){
            return DateTime.Now;
        }
    }
}

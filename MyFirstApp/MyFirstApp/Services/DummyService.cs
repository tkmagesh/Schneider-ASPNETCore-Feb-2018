using System;
using System.Diagnostics;
namespace MyFirstApp.Services
{
    public interface IDummyService{
        void Dummy();
    }
    public class DummyService : IDummyService
    {
        public DummyService(IDateTimeService dateTimeService)
        {
            Debug.WriteLine("[@DummyService]  instance created");
        }
        public void Dummy(){
            Debug.WriteLine("[@DummyService] - Dummy method invoked");
        }
    }
}

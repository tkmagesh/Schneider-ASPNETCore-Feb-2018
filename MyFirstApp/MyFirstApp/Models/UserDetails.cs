using System;
namespace MyFirstApp.Models
{
    public class UserDetails
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public UserDetails()
        {
            
        }
        public string Message
        {
            get;
            set;
        }
        public void Greet(){
            this.Message = $"Hi {this.FirstName} {this.LastName}, Have a nice day!";
        }
    }
}

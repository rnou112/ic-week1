using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoftwareDev_Week1.Classes
{
    public delegate void UserRegisteredEventHandler(object sender, UserRegisteredEventArgs e);

    public class UserRegisteredEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class UserService  // publiser
    {
        public event UserRegisteredEventHandler UserRegistered;

       /* protected virtual void OnUserRegistered(UserRegisteredEventArgs e)
        {
            UserRegistered?.Invoke(this, e);  //2.
        }
       */
        public void RegisterUser(string email, string name)  
        {
            // code to register the user   //1.
            // ...

            // raise the UserRegistered event
            // OnUserRegistered(new UserRegisteredEventArgs { Email = email, Name = name });

            UserRegisteredEventArgs args = new UserRegisteredEventArgs { Email = email, Name = name };
            UserRegistered?.Invoke(this, args);
        }
    }  

    public class EmailService  //subscriber
    {
        public void SendWelcomeEmail(string email, string name)
        {
            // code to send the welcome email
            Console.WriteLine($"Welcome email sent to {name} at {email}");
        }
    }
}

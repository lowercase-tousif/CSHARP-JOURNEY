using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public class EmailService
    {
        public void SendEmail(){
            Connect();
            Authenticate();
            Console.WriteLine("Sending Email...");
            Console.WriteLine("Email Sent!");
            Disconnect();
        }

        private void Connect(){
            Console.WriteLine("Connecting to Email Server...");
        }

        private void Authenticate(){
            Console.WriteLine("Authenticating Email Server...");
        }
        private void Disconnect(){
            Console.WriteLine("Disconnecting from Email Server...");
        }
    }
}
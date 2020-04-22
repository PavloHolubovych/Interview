using System;
using System.Text;

namespace InterviewTest
{
    public class WelcomeEmailBuilder
    {
        public string Build(string name, string permissions)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(GetHeader(name));
            builder.Append(GetBody(permissions));
            builder.Append(GetFooter());
            return builder.ToString();
        }

        private string GetHeader(string name)
        {
            return $"Welcome to our system {name}";
        }

        private string GetBody(string permissions)
        {
            return $"Your account was created at {DateTime.Now.Date} by our Admin and granted you {permissions} permissions";
        }

        private string GetFooter()
        {
            return $"Best regards, perfect system team";
        }
    }
}
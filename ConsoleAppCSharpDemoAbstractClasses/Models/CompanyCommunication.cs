using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoAbstractClasses.Models
{
    internal abstract class CompanyCommunication
    {       
        internal void SendMailToTeamMember(string teamMemberName)
        {
            //Normally we'd have code here to look at the team member's address, call a mail handler, etc.
            Console.WriteLine($"Mail sent via USPS to team member {teamMemberName}");
        }

        //Virtual lets us override if we want to, but we don't have to
        internal virtual void SendEmailToTeamMember(string teamMemberName)
        {
            //Normally we'd have code here to look at the team member's email address, call an email handler, etc.
            Console.WriteLine($"Email sent to team member {teamMemberName}");
        }

        internal virtual string AddVerbiage()
        {
            return "Dear team member, Thank you for joining our amazing company!";
        }

        internal abstract void SendOncallAlert(string oncallNumber);

    }
}

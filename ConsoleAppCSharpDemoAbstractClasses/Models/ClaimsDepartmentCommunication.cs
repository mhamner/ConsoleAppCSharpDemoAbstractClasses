using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoAbstractClasses.Models
{
    internal class ClaimsDepartmentCommunication : CompanyCommunication
    {        
        internal override void SendOncallAlert(string oncallNumber)
        {
            //Here we'd add code to call an SMS handler to text the oncall person
            Console.WriteLine($"Text sent to {oncallNumber}.");
        }

        internal override void SendEmailToTeamMember(string teamMemberName)
        {
            Console.WriteLine($"Sending email to team member {teamMemberName} from derived class.");

            //Call the version from our base class
            base.SendEmailToTeamMember(teamMemberName);
        }

        internal override string AddVerbiage()
        {
            string verbiageSoFar = base.AddVerbiage();
            return verbiageSoFar += "We know you will do great on the Claims Team!";
        }
    }
}

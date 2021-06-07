using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppCSharpDemoAbstractClasses.Models;

namespace ConsoleAppCSharpDemoAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimsDepartmentCommunication comm = new ClaimsDepartmentCommunication();
            comm.SendEmailToTeamMember("Mickey Mouse");
            comm.SendMailToTeamMember("Minnie Mouse");
            comm.SendOncallAlert("502.555.7272");

            string s = comm.AddVerbiage();
            Console.WriteLine($"Verbiage is: {s}");
            
            Console.ReadKey();
        }
    }
}

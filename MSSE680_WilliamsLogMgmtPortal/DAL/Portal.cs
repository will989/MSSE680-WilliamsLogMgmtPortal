using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.DAL
{
    class Portal
    {
        static void Main(string[] args)
        {
            using (var db = new MSSE680_WilliamsLogMgmtPortal.DAL.andy680Entities())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Organization: ");
                var organization = Console.ReadLine();

            }
        }//end main
    }//end Portal
}
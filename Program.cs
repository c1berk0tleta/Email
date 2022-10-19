using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Pksrch;

namespace NetConsoleApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CodeMail lolo = new CodeMail();
            lolo.CodeInit();
            lolo.verify();
            
        }
    }
}

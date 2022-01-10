using System;
using MailContainerTest.Common.Models;
using MailContainerTest.Services.Implementation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var makeMailTransferRequest = new MailTransferService();
            makeMailTransferRequest.MakeMailTransfer(new MakeMailTransferRequest());
            Console.WriteLine("Hello World!");
        }
    }
}

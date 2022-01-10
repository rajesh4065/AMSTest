using MailContainerTest.Services.Implementation;
using System;
using System.Configuration;
using MailContainerTest.Common.Models;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var mailTransferService = new MailTransferService();
            var makeMailTransferRequest = new MakeMailTransferRequest();
            var ff = ConfigurationManager.AppSettings["DataStoreType"];
            //Act
            var result = mailTransferService.MakeMailTransfer(makeMailTransferRequest);
            Console.WriteLine("Hello World!");

        }

    }
}


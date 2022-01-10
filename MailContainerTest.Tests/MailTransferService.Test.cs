
namespace MailContainerTest.Tests
{
    using Common.Models;
    using Data.Interfaces;
    using Services.Implementation;
    using Services.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Rhino.Mocks;

    [TestClass]
    public class MailTransferServiceTest
    {
        private readonly IMailTransferService _mailTransferServiceMock = MockRepository.GenerateMock<IMailTransferService>();

        private readonly IContainerDataStore _containerDataStore = MockRepository.GenerateMock<IContainerDataStore>();

        [TestMethod]
        public void MakeMailTransfer_AssertWasCalled()
        {
            //Arrange
            var mailTransferService = new MailTransferService();
            var makeMailTransferRequest = new MakeMailTransferRequest();

            //Act
            var result = mailTransferService.MakeMailTransfer(makeMailTransferRequest);

            //Assert

        }
    }


}

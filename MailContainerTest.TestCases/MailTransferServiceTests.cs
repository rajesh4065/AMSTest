

namespace MailContainerTest.TestCases
{
    using Common.Models;
    using Common.Types;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Services.Implementation;
    using Services.Interfaces;

    [TestClass]
    public class MailTransferServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockConfig = new Mock<IFileConfig>();
            mockConfig.Setup(x => x.DataStoreType).Returns("BackUp");
            var mailTransferService = new MailTransferService(mockConfig.Object);
            var makeMailTransferRequest = new MakeMailTransferRequest();
            makeMailTransferRequest.MailType = MailType.LargeLetter;

            //Act
            var result = mailTransferService.MakeMailTransfer(makeMailTransferRequest);

            //Assert
        }

    }
}

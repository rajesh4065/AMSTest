
namespace MailContainerTest.Services.Interfaces
{
    using Common.Models;
    public interface IMailTransferService
    {
        MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request);
    }
}
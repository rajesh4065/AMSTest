namespace MailContainerTest.Data.Interfaces
{
    using Common.Models;
    public interface IContainerDataStore
    {

        MailContainer GetMailContainer(string mailContainerNumber);

        void UpdateMailContainer(MailContainer mailContainer);
    }
}

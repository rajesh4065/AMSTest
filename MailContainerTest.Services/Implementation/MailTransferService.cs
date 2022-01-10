

namespace MailContainerTest.Services.Implementation
{
    using Common.Models;
    using Common.Types;
    using Interfaces;
    using Data;

    public class MailTransferService : IMailTransferService
    {
        private readonly IFileConfig _fileConfig;
        public MailTransferService(IFileConfig fileConfig)
        {
            _fileConfig = fileConfig;
        }

        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var result = new MakeMailTransferResult();
            var containerDataStore = DataStoreFactory.GetDataStore(_fileConfig.DataStoreType);
            var mailContainer = containerDataStore.GetMailContainer(request.SourceMailContainerNumber);
            switch (request.MailType)
            {
                case MailType.StandardLetter:
                    if (mailContainer == null)
                    {
                        result.Success = false;
                    }
                    else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
                    {
                        result.Success = false;
                    }

                    break;

                case MailType.LargeLetter:
                    if (mailContainer == null)
                    {
                        result.Success = false;
                    }
                    else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.LargeLetter))
                    {
                        result.Success = false;
                    }
                    else if (mailContainer.Capacity < request.NumberOfMailItems)
                    {
                        result.Success = false;
                    }

                    break;

                case MailType.SmallParcel:
                    if (mailContainer == null)
                    {
                        result.Success = false;
                    }
                    else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.SmallParcel))
                    {
                        result.Success = false;
                    }
                    else if (mailContainer.Status != MailContainerStatus.Operational)
                    {
                        result.Success = false;
                    }

                    break;
            }

            if (result.Success)
            {
                if (mailContainer != null)
                {
                    mailContainer.Capacity -= request.NumberOfMailItems;
                    containerDataStore.UpdateMailContainer(mailContainer);
                }
            }

            return result;
        }
    }
}


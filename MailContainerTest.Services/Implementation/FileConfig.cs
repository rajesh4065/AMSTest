
namespace MailContainerTest.Services.Implementation
{
    using Common;
    using Interfaces;
    using System.Configuration;

    public class FileConfig : IFileConfig
    {
        public string DataStoreType => ConfigurationManager.AppSettings[Constants.DataStoreType];
    }
}

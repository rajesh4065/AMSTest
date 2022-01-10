using MailContainerTest.Common;

namespace MailContainerTest.Data
{

    using MailContainerTest.Data.Interfaces;
    public static  class DataStoreFactory
    {
        public static IContainerDataStore GetDataStore(string dataStoreType)
        {
            switch (dataStoreType)
            {
                case Constants.Backup:
                    return new BackupMailContainerDataStore();
                default:
                    return new MailContainerDataStore();
            }
        }
    }
}

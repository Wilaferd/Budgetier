using System.Collections.Generic;
using GPT.MadMoney.Interfaces.Factories;
using GPT.MadMoney.Interfaces.Repositories.LocalFile.DataRetrieval;

namespace GPT.MadMoney.Repositories.LocalFile.DataRetrieval
{
    public class AccountDataRepository : IAccountDataRepository
    {
        private readonly IFileStreamFactory _fileStreamFactory;

        public AccountDataRepository(IFileStreamFactory fileStreamFactory)
        {
            _fileStreamFactory = fileStreamFactory;
        }

        public List<string> GetAccountTypes()
        {
            var accountTypes = new List<string>();



            return accountTypes;
        }
    }
}
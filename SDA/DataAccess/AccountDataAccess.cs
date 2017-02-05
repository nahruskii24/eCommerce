using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDA.Model;

namespace SDA.DataAccess
{
    public class AccountDataAccess
    {
       private readonly StoreDbModel _db=new StoreDbModel();

        public void CreateAccount(Account account)
        {
            _db.Accounts.Add(account);
            _db.SaveChanges();
        }

        public Account GetAccount(string id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(string id)
        {
            throw new NotImplementedException();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Epf.Core.Data;
using Epf.Core.Model;

namespace Epf.Core.Manager
{
    public class AccountManager
    {
        private AccountContext _accountContext;
        public AccountManager(AccountContext accountContext)
        {
            _accountContext = accountContext;
        }

        public void Add(Account account)
        {
            _accountContext.Add(account);            
            _accountContext.SaveChanges();
        }
        
    }   
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Epf.Core.Model;

namespace Epf.Core.Data
{
    public class AccountContext : DbContext
    {
        public AccountContext()
        { }

        public AccountContext(DbContextOptions<AccountContext> options)
        : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
    }
}

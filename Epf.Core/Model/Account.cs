using System;
using System.Collections.Generic;
using System.Text;

namespace Epf.Core.Model
{
    public class Account
    {
        public int Id{ get; set; }
        public AccountType AccountType { get; set; }
        public Person User { get; set; }
    }
    public enum AccountType
    {
        Employee,
        Employer
    }
}

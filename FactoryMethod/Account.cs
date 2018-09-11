using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.NetMentoring.FactoryMethod
{
    public class Account
    {
        string Name;
        public Account(string name)
        {
            Name = name;
        }
    }
    public class AccountDB
    {
        public static Dictionary<int, Account> Accounts { get; set; }
    }
}

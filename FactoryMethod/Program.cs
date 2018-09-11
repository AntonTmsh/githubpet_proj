using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.NetMentoring.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountDB.Accounts.Add(1, new Account("test1"));
        }
    }
}

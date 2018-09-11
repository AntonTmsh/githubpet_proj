using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.NetMentoring.Factory
{
     public class Trade
    {
        private int _amount;
        private string _type;
        private string _sybType;
        public Trade(int amount,string type, string SybType)
        {
            _amount = amount;
            _type = type;
            _sybType = SybType;
        }

        public int Amount { get; private set; }
        public string Type { get; private set; }
        public string SybType { get; private set; }
    }
}

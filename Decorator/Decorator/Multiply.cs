﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaceEpam.NetMentoring.Calculator
{
    class Multiply : BinaryOperation
    {
        public Multiply(IOperation operator1, IOperation operator2) : base(operator1, operator2)
        {

        }
        public override double GetResult()
        {
            return _operator1.GetResult() * _operator2.GetResult();
        }
    }
}

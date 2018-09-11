using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaceEpam.NetMentoring.CalculationService
{
    public class CalculationServiceWithCorrection : CalculationServiceDecorator
    {
        private readonly int _corretion = 10;
        public CalculationServiceWithCorrection(ICalculationService calculationService) : base(calculationService)
        { }

        public override decimal Calculate(decimal firstParameter, decimal secondParameter)
        {
            return _calculationService.Calculate(firstParameter, secondParameter) + _corretion;
        }
    }
}

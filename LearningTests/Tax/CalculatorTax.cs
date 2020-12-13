using System.Threading.Tasks;

namespace LearningTests.Tax
{
    public class CalculatorTax
    {
        private readonly IServiceTaxIncome _serviceTaxIncome;

        public CalculatorTax(IServiceTaxIncome serviceTaxIncome)
        {
            _serviceTaxIncome = serviceTaxIncome;
        }

        public async Task<decimal> CalculateSalaryLiquid(decimal salary)
        {
            var aliquot = await _serviceTaxIncome.GetAliquot(salary);

            return salary - salary * aliquot / 100;
        }
    }
}
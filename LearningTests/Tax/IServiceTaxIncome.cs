using System.Threading.Tasks;

namespace LearningTests.Tax
{
    public interface IServiceTaxIncome
    {
        Task<decimal> GetAliquot(decimal value);
    }
}
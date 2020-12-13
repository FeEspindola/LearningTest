using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearningTests.Tax
{
    public class ServiceTaxIncome : IServiceTaxIncome
    {
        public async Task<decimal> GetAliquot(decimal value)
        {
            var tableJson = await File.ReadAllTextAsync("TableTax.json");
            var tableTax = JsonSerializer.Deserialize<TableTax>(tableJson, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });

            var faixa = tableTax.BannerTaxs.First(x => ( value >= x.ValueStart && value <= x.ValueEnd) || 
                                                                               (value >= x.ValueStart && x.ValueEnd == null));
            return faixa.Aliquot;
        }
    }
}
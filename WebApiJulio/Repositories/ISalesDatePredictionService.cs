using WebApiJulio.Models;

namespace WebApiJulio.Repositories
{
    public interface ISalesDatePredictionService
    {
        public Task<IEnumerable<SalesDatePrediction>> GetSalesDatePredictionAsync(int CustId);

    }
}

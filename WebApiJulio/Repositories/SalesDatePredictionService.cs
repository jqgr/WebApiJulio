using Azure.Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApiJulio.Models;

namespace WebApiJulio.Repositories
{
    public class SalesDatePredictionService : ISalesDatePredictionService
    {
        private readonly CallSPDBContext _callSPDBContext;

        public SalesDatePredictionService(CallSPDBContext callSPDBContext)
        {
            _callSPDBContext = callSPDBContext;
        }

        public async Task<IEnumerable<SalesDatePrediction>> GetSalesDatePredictionAsync(int CustId)
        {
            var param = new SqlParameter("@custId", CustId);
            var salesDatePrediction = await Task.Run(() => _callSPDBContext.SalesDatePrediction
            .FromSqlRaw(@"exec SalesDatePrediction @custId", param).ToListAsync());

            return salesDatePrediction;
        }
    }
}

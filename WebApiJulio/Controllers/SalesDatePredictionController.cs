using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJulio.Models;
using WebApiJulio.Repositories;

namespace WebApiJulio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesDatePredictionController : ControllerBase
    {
        private readonly ISalesDatePredictionService salesDatePredictionService;

        public SalesDatePredictionController(ISalesDatePredictionService salesDatePredictionService)
        {
            this.salesDatePredictionService = salesDatePredictionService;
        }

        [HttpGet("SalesDatePrediction")]
        public async Task<IEnumerable<SalesDatePrediction>> GetSalesDatePredictionAsync(int CustId)
        {
            try
            {
                var response = await salesDatePredictionService.GetSalesDatePredictionAsync(CustId);

                if (response == null)
                    return null;

                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

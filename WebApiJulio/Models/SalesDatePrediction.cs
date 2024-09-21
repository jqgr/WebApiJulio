using Microsoft.EntityFrameworkCore;

namespace WebApiJulio.Models
{
    [Keyless]
    public class SalesDatePrediction
    {

        public string companyName { get; set; }
        public string orderdate { get; set; }
        public string nextPredictedOrder { get; set; }

    }
}

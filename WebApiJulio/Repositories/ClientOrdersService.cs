using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApiJulio.Models;

namespace WebApiJulio.Repositories
{
    public class ClientOrdersService : IClientOrdersService
    {
        private readonly CallSPDBContext _callSPDBContext;

        public ClientOrdersService(CallSPDBContext callSPDBContext)
        {
            _callSPDBContext = callSPDBContext;
        }

        public async Task<List<ClientOrders>> GetClientOrdersAsync(int CustId)
        {
            var param = new SqlParameter("@custId", CustId);
            var clientOrders = await Task.Run(() => _callSPDBContext.ClientOrders
            .FromSqlRaw(@"exec GetClientOrders @custId", param).ToListAsync());

            return clientOrders;
        }
    }
}

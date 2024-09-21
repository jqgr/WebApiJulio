using WebApiJulio.Models;

namespace WebApiJulio.Repositories
{
    public interface IClientOrdersService
    {
        public Task<List<ClientOrders>> GetClientOrdersAsync(int CustId);
    }
}
